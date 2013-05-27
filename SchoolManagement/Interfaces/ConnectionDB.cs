using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

namespace Interfaces
{
    public static class ConnectionDB
    {
        private static SqlConnection connection;

        public static string ConnectionString
        {
            get;
            set;
        }

        public static DbConnection Connection
        {
            get
            {
                return connection;
            }
        }

        public static DbCommand NewCommand(string commandText)
        {
            return new SqlCommand(commandText, connection);
        }

        public static DbCommand NewCommand()
        {
            return new SqlCommand
                   {
                       Connection = connection
                   };
        }

        public static void InitSql(string connectionString)
        {
            ConnectionString = connectionString;
            if (connection == null)
            {
                connection = new SqlConnection(ConnectionString);
            }
            else
            {
                CloseSql();
                Connection.ConnectionString = ConnectionString;
            }
        }

        public static void OpenSql()
        {
            if (Connection.State != ConnectionState.Open)
            {
                Connection.Open();
            }
        }

        public static void CloseSql()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        public static TransactionDB NewTransaction()
        {
            return new TransactionDB(ConnectionString);
        }

        public static TransactionDB BeginTransaction()
        {
            var transaction = new TransactionDB(ConnectionString);
            transaction.BeginTransaction();
            return transaction;
        }

        public static DbDataAdapter NewDataAdapter(DbCommand command)
        {
            return new SqlDataAdapter((SqlCommand)command);
        }

        private static bool TryConnect()
        {
            try
            {
                Connection.Close();
            }
            catch
            {
            }

            try
            {
                Connection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static int ExecuteNonQuery(DbCommand cmd)
        {
            var result = 0;
            var allRight = false;
            try
            {
                result = cmd.ExecuteNonQuery();
                allRight = true;
            }
            catch (Exception)
            {
                if (cmd.Connection != Connection)
                {
                    throw;
                }
            }

            if (!allRight)
            {
                if (TryConnect())
                {
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    throw new Exception("Отсутствует связь с СУБД! \nНеобходимо перезапустить приложение!");
                }
            }
            return result;
        }

        public static bool TryExecuteNonQuery(DbCommand cmd)
        {
            if (Connection.State != ConnectionState.Open
                && !TryConnect())
            {
                return false;
            }
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static DbDataReader ExecuteReader(DbCommand cmd)
        {
            DbDataReader result = null;
            var allRight = false;
            try
            {
                result = cmd.ExecuteReader();
                allRight = true;
            }
            catch (Exception)
            {
                if (cmd.Connection != Connection)
                {
                    throw;
                }
            }
            if (!allRight)
            {
                if (TryConnect())
                {
                    result = cmd.ExecuteReader();
                }
                else
                {
                    throw new Exception("Отсутствует связь с СУБД! \nНеобходимо перезапустить приложение!");
                }
            }
            return result;
        }

        public static object ExecuteScalar(DbCommand command)
        {
            object result = null;
            var allRight = false;
            try
            {
                result = command.ExecuteScalar();
                allRight = true;
            }
            catch (Exception)
            {
                if (command.Connection != Connection)
                {
                    throw;
                }
            }

            if (!allRight)
            {
                if (TryConnect())
                {
                    result = command.ExecuteScalar();
                }
                else
                {
                    throw new Exception("Отсутствует связь с СУБД! \nНеобходимо перезапустить приложение!");
                }
            }
            return result;
        }

        public static int Fill(DbDataAdapter adapter, DataTable table)
        {
            var rowCount = -1;
            var allRight = false;
            try
            {
                rowCount = adapter.Fill(table);
                allRight = true;
            }
            catch (Exception)
            {
                if (adapter.SelectCommand.Connection != Connection)
                {
                    throw;
                }
            }

            if (!allRight)
            {
                if (TryConnect())
                {
                    rowCount = adapter.Fill(table);
                }
                else
                {
                    throw new Exception("Отсутствует связь с СУБД! \nНеобходимо перезапустить приложение!");
                }
            }
            return rowCount;
        }

        public static void AddWithValue(DbParameterCollection parameterCollection, string name, object value)
        {
            var sqlParameterCollection = parameterCollection as SqlParameterCollection;
            sqlParameterCollection.AddWithValue(name, value);
        }

        public static void AddWithValueNullableString(this DbCommand command, string name, string value)
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                command.AddAsDBNull(name);
            }
            else
            {
                command.AddWithValue(name, value.Trim());
            }
        }
        public static void AddWithValueTrimmedString(this DbCommand command, string name, string value)
        {
            command.AddWithValue(name, value.Trim());
        }

        public static void AddWithValueNullableObject(this DbCommand command, string name, object value)
        {
            if (value == null)
            {
                command.AddAsDBNull(name);
            }
            else
            {
                command.AddWithValue(name, value);
            }
        }

        public static void AddAsDBNull(this DbCommand command, string name)
        {
            command.AddWithValue(name, DBNull.Value);
        }

        public static void AddWithValueNullableImage(this DbCommand command, string name, Image image)
        {
            if (image == null)
            {
                command.AddWithValueOfType(name, DBNull.Value, SqlDbType.Image);
            }
            else
            {
                var memoryStream = new MemoryStream();
                image.Save(memoryStream, ImageFormat.Bmp);
                byte[] imageByteArray = memoryStream.ToArray();
                command.AddWithValueOfType(name, imageByteArray, SqlDbType.Image);
            }
        }

        private static void AddWithValueOfType(this DbCommand command, string name, object value, SqlDbType type)
        {
            var sqlCommand = command as SqlCommand;
            sqlCommand.Parameters.Add(name, type).Value = value;
        }

        public static void AddWithValue(this DbCommand command, string name, object value)
        {
            var sqlCommand = command as SqlCommand;
            sqlCommand.Parameters.AddWithValue(name, value);
        }

        public static DataTable GetDataTable(this DbCommand command)
        {
            DataTable dataTable = new DataTable();
            command.Connection = Connection;
            try
            {
                Fill(NewDataAdapter(command), dataTable);
            }
            catch (SystemException e)
            {
                throw e;
            }
            return dataTable;
        }

        public static DataRow GetFirstRowOrDefault(this DbCommand command)
        {
            return command.GetDataTable()
                .AsEnumerable()
                .FirstOrDefault();
        }

        public static int ExecuteNonQueryEx(this DbCommand command)
        {
            return ExecuteNonQuery(command);
        }

        public static bool TryExecuteNonQueryEx(this DbCommand command)
        {
            return TryExecuteNonQuery(command);
        }

        public static object ExecuteScalarEx(this DbCommand command)
        {
            return ExecuteScalar(command);
        }

        public static int FillDataTable(this DbCommand command, DataTable target)
        {
            using (DbDataAdapter adapter = NewDataAdapter(command))
            {
                return Fill(adapter, target);
            }
        }
    }
}
