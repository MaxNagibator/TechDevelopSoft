using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using Interfaces.Exceptions;
using System.Linq;
using System.Collections.ObjectModel;

namespace Interfaces
{
    public class SqlProvider : ISqlProvider
    {
        public class QueryRow : IQueryResultRow
        {
            private Dictionary<string, object> fields = new Dictionary<string, object>();

            internal void AddField(string fieldName, object value)
            {
                fields.Add(fieldName.ToLower(), value);
            }

            public T FieldOrDefault<T>(string fieldName)
            {
                try
                {
                    return Field<T>(fieldName);
                }
                catch
                {
                    return default(T);
                }
            }

            public T Field<T>(string fieldName)
            {
                var value = fields[fieldName.ToLower()];
                if (IsNullableType(typeof(T)))
                {
                    return GetNullableValue<T>(value);
                }
                return GetNotNullableValue<T>(value);
            }

            private T GetNullableValue<T>(object value)
            {
                Type nullableType = Nullable.GetUnderlyingType(typeof(T));
                return DBNull.Value.Equals(value) ?
                        default(T) : (T)Convert.ChangeType(value, nullableType);
            }

            private T GetNotNullableValue<T>(object value)
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }

            private bool IsNullableType(Type type)
            {
                return Nullable.GetUnderlyingType(type) != null;
            }
        }

        private readonly SqlConnection _connection;
        private SqlCommand _command;
        private SqlDataReader _reader;
        private DataTable _dataTable;
        private readonly List<IQueryResultRow> _rows = new List<IQueryResultRow>();

        public ReadOnlyCollection<IQueryResultRow> Rows
        {
            get
            {
                return _rows.AsReadOnly();
            }
        }

        public bool HasRows
        {
            get
            {
                return _rows.Any();
            }
        }

        [Obsolete("use SetParameter()!", false)]
        public SqlCommand Command
        {
            get
            {
                return _command;
            }
            set
            {
                _command = value;
            }
        }

        [Obsolete("use 'Rows' property with 'ExecuteQuery()' method!", true)]
        public SqlDataReader Reader
        {
            get
            {
                return _reader;
            }
            set
            {
                _reader = value;
            }
        }

        public IQueryResultRow FirstRow
        {
            get
            {
                return _rows.FirstOrDefault();
            }
        }

        [Obsolete("use 'Rows' property with 'ExecuteQuery()' method!")]
        public DataTable DataTable
        {
            get
            {
                return _dataTable;
            }
            set
            {
                _dataTable = value;
            }
        }

        [Obsolete("use ExecuteQuery()!", true)]
        public void ExecuteReader(string sql)
        {
            try
            {
                _command.CommandText = sql;
                _reader = _command.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public SqlProvider(ILocalSettings localSettings)
        {
            try
            {
                _connection = new SqlConnection(localSettings.ConnectionString);
                _command = new SqlCommand("", _connection);
                _connection.Open();
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public SqlConnection Connection
        {
            get
            {
                return _connection;
            }
        }

        public void ExecuteNonQuery(string sql)
        {
            try
            {
                _command.CommandText = sql;
                _command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public int ExecuteScalar(string sql)
        {
            try
            {
                _command.CommandText = sql;
                object commandResult = _command.ExecuteScalar();
                int intResult = 0;
                if (!int.TryParse(commandResult.ToString(), out intResult))
                {
                    throw new ResultIsNotInt32Exception(commandResult);
                }
                return intResult;
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public int ExecuteInt32WithNullAsZero(string sql)
        {
            try
            {
                _command.CommandText = sql;
                object commandResult = _command.ExecuteScalar();
                if (commandResult is int?)
                {
                    return Convert.ToInt32(commandResult);
                }
                if (commandResult == DBNull.Value
                    || commandResult == null)
                {
                    return 0;
                }
                throw new ResultIsNotInt32Exception(commandResult);
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public bool ExecuteBooleanWithNullAsFalse(string sql)
        {
            try
            {
                _command.CommandText = sql;
                object commandResult = _command.ExecuteScalar();
                if (commandResult is bool?)
                {
                    return Convert.ToBoolean(commandResult);
                }
                if (commandResult == DBNull.Value
                    || commandResult == null)
                {
                    return false;
                }
                throw new ResultIsNotBooleanException(commandResult);
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public void SetParameter(string parameterName, object value)
        {
            object sqlValue = value ?? DBNull.Value;
            if (_command.Parameters.OfType<SqlParameter>().Any(p => p.ParameterName == parameterName))
            {
                _command.Parameters[parameterName].Value = sqlValue;
            }
            else
            {
                _command.Parameters.AddWithValue(parameterName, sqlValue);
            }
        }

        public void ExecuteQuery(string sql)
        {
            try
            {
                _command.CommandText = sql;
                _reader = _command.ExecuteReader();
                _rows.Clear();
                while (_reader.Read())
                {
                    var row = new QueryRow();
                    for (int i = 0; i < _reader.FieldCount; i++)
                    {
                        row.AddField(_reader.GetName(i), _reader[i]);
                    }
                    _rows.Add(row);
                }
                _reader.Close();
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public string ExecuteString(string sql)
        {
            try
            {
                _command.CommandText = sql;
                _reader = _command.ExecuteReader();
                if (_reader.Read())
                {
                    return _reader[0].ToString();
                }
                _reader.Close();
                return null;
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        [Obsolete("use ExecuteQuery()!")]
        public void ExecuteDataTable(string sql)
        {
            try
            {
                _dataTable = new DataTable();
                _command.CommandText = sql;
                using (var dataAdapter = new SqlDataAdapter(_command))
                {
                    dataAdapter.Fill(_dataTable);
                }
            }
            catch (SqlException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public void ExeuteInOneTransaction(StringCollection scripts)
        {
            SqlTransaction transaction = _command.Connection.BeginTransaction(IsolationLevel.ReadUncommitted);
            try
            {
                foreach (string script in scripts)
                {
                    ExecuteNonQueryTransacted(script, transaction);
                }
                transaction.Commit();
            }
            catch (SqlException ex)
            {
                try
                {
                    transaction.Rollback();
                }
                finally
                {
                    throw new SqlProviderException(ex);
                }
            }
        }

        private void ExecuteNonQueryTransacted(string sql, SqlTransaction transaction)
        {
            _command.Transaction = transaction;
            _command.CommandText = sql;
            _command.ExecuteNonQuery();
        }

        public void ExecuteInOneTransaction(IEnumerable<SqlProviderCommand> commands)
        {
            using (SqlTransaction transaction = _connection.BeginTransaction())
            {
                foreach (SqlProviderCommand command in commands)
                {
                    using (SqlCommand sqlCommand = ConvertToSqlCommandInTransaction(command, transaction))
                    {
                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            throw new SqlProviderException(ex);
                        }
                    }
                }
            }
        }

        private SqlCommand ConvertToSqlCommandInTransaction(SqlProviderCommand command, SqlTransaction transaction)
        {
            SqlCommand sqlCommand = new SqlCommand(command.Instruction, _connection, transaction);
            foreach (SqlProviderCommand.Parameter parameter in command.Parameters)
            {
                sqlCommand.AddWithValue(parameter.Name, parameter.Value);
            }
            return sqlCommand;
        }

        public void Dispose()
        {
            if (_reader != null)
            {
                _reader.Dispose();
            }
            if (_command != null)
            {
                _command.Dispose();
            }
            if (_dataTable != null)
            {
                _dataTable.Dispose();
            }
            if (_connection != null)
            {
                _connection.Dispose();
            }
        }
    }
}
