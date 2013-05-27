using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlServerCe;
using System.Linq;
using KioskQuestionnaeriServer.Exceptions;

namespace KioskQuestionnaeriServer.SqlProvider
{
    public class SqlProvider : ISqlProvider
    {
        private const string SQL_CONNECTION_STRING = @"Data Source=D:\MyDatabase#9.sdf";
        public class QueryRow : IQueryResultRow
        {
            private readonly Dictionary<string, object> _fields = new Dictionary<string, object>();

            internal void AddField(string fieldName, object value)
            {
                _fields.Add(fieldName.ToLower(), value);
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

            public dynamic Field(string fieldName)
            {
                var value = Field<object>(fieldName);
                return DBNull.Value.Equals(value) ? null : value;
            }

            public T Field<T>(string fieldName)
            {
                var value = _fields[fieldName.ToLower()];
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

            public bool IsNull(string fieldName)
            {
                return DBNull.Value.Equals(_fields[fieldName]);
            }
        }

        private readonly SqlCeConnection _connection;
        private SqlCeCommand _command;
        private SqlCeDataReader _reader;
        private DataTable _dataTable;
        private readonly List<IQueryResultRow> _rows = new List<IQueryResultRow>();
        private readonly List<string> _columnNames = new List<string>();

        public ReadOnlyCollection<IQueryResultRow> Rows
        {
            get
            {
                return _rows.AsReadOnly();
            }
        }

        public ReadOnlyCollection<string> ColumnNames
        {
            get
            {
                return _columnNames.AsReadOnly();
            }
        }

        public bool HasRows
        {
            get
            {
                return _rows.Any();
            }
        }

        [Obsolete("use SetParameter()!")]
        public SqlCeCommand Command
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

        [Obsolete("use 'Rows' property with 'ExecuteQuery()' method!")]
        public SqlCeDataReader Reader
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

        [Obsolete("use ExecuteQuery()!")]
        public void ExecuteReader(string sql)
        {
            try
            {
                _command.CommandText = sql;
                _reader = _command.ExecuteReader();
            }
            catch (SqlCeException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public SqlProvider()
        {
            try
            {
                _connection = new SqlCeConnection(SQL_CONNECTION_STRING);
                _command = new SqlCeCommand("", _connection);
                _connection.Open();
            }
            catch (SqlCeException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public SqlCeConnection Connection
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
            catch (SqlCeException ex)
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
                int intResult;
                if (!int.TryParse(commandResult.ToString(), out intResult))
                {
                    throw new ResultIsNotInt32Exception(commandResult);
                }
                return intResult;
            }
            catch (SqlCeException ex)
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
            catch (SqlCeException ex)
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
            catch (SqlCeException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public void SetParameterImage(string parameterName, object value)
        {
            SetParameter(parameterName, value, SqlDbType.Image);
        }

        private void SetParameter(string parameterName, object value, SqlDbType sqlDbType)
        {
            object sqlValue = value ?? DBNull.Value;
            if (_command.Parameters.OfType<SqlParameter>().Any(p => p.ParameterName == parameterName))
            {
                _command.Parameters[parameterName].SqlDbType = sqlDbType;
            }
            else
            {
                _command.Parameters.AddWithValue(parameterName, sqlValue);
            }
            _command.Parameters[parameterName].SqlDbType = sqlDbType;
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
                GenerateColumnsAndRows();
            }
            catch (SqlCeException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public void ExecuteProcedure(string procedureName)
        {
            try
            {
                _command.CommandType = CommandType.StoredProcedure;
                _command.CommandText = procedureName;
                GenerateColumnsAndRows();
            }
            catch (SqlCeException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        private void GenerateColumnsAndRows()
        {
            _reader = _command.ExecuteReader();
            GenerateColumsFromReader();
            GenerateRowsFromReader();
            _reader.Close();
        }

        private void GenerateColumsFromReader()
        {
            _columnNames.Clear();
            for (int i = 0; i < _reader.FieldCount; i++)
            {
                _columnNames.Add(_reader.GetName(i));
            }
        }

        private void GenerateRowsFromReader()
        {
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
            catch (SqlCeException ex)
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
                using (var dataAdapter = new SqlCeDataAdapter(_command))
                {
                    dataAdapter.Fill(_dataTable);
                }
            }
            catch (SqlCeException ex)
            {
                throw new SqlProviderException(ex);
            }
        }

        public void ExeuteInOneTransaction(StringCollection scripts)
        {
            SqlCeTransaction transaction = _command.Connection.BeginTransaction(IsolationLevel.ReadUncommitted);
            try
            {
                foreach (string script in scripts)
                {
                    ExecuteNonQueryTransacted(script, transaction);
                }
                transaction.Commit();
            }
            catch (SqlCeException ex)
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

        private void ExecuteNonQueryTransacted(string sql, SqlCeTransaction transaction)
        {
            _command.Transaction = transaction;
            _command.CommandText = sql;
            _command.ExecuteNonQuery();
        }

        public void ExecuteInOneTransaction(IEnumerable<SqlCeProviderCommand> commands)
        {
            using (SqlCeTransaction transaction = _connection.BeginTransaction())
            {
                foreach (SqlCeProviderCommand command in commands)
                {
                    using (SqlCeCommand sqlCommand = ConvertToSqlCommandInTransaction(command, transaction))
                    {
                        try
                        {
                            sqlCommand.ExecuteNonQuery();
                        }
                        catch (SqlCeException ex)
                        {
                            throw new SqlProviderException(ex);
                        }
                    }
                }
            }
        }

        private SqlCeCommand ConvertToSqlCommandInTransaction(SqlCeProviderCommand command, SqlCeTransaction transaction)
        {
            var sqlCommand = new SqlCeCommand(command.Instruction, _connection, transaction);
            foreach (var parameter in command.Parameters)
            {
                sqlCommand.Parameters.AddWithValue(parameter.Name, parameter.Value);
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