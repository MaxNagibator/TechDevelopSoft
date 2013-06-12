using System;
using System.Collections.Generic;
using SchoolManagement.SqlProviderFolder;

namespace MyFirstTest
{
    internal class MockSqlProvider : ISqlProvider
    {
        public IList<string> Queries = new List<string>();

        public bool ExecuteBooleanWithNullAsFalse(string sql)
        {
            Queries.Add(sql);
            return true;
        }

        public int ExecuteInt32WithNullAsZero(string sql)
        {
            Queries.Add(sql);
            return 0;
        }

        public void ExecuteNonQuery(string sql)
        {
            Queries.Add(sql);
        }

        public void ExecuteQuery(string sql)
        {
            Queries.Add(sql);
        }

        public int ExecuteScalar(string sql)
        {
            Queries.Add(sql);
            return 0;
        }

        public string ExecuteString(string sql)
        {
            Queries.Add(sql);
            return "";
        }

        public IQueryResultRow FirstRow
        {
            get
            {
                return new MockQueryResultRow();
            }
        }

        public bool HasRows
        {
            get
            {
                return true;
            }
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<IQueryResultRow> Rows
        {
            get
            {
                return new List<IQueryResultRow>().AsReadOnly();
            }
        }

        public void SetParameter(string parameterName, object value)
        {
        }

        public void Dispose()
        {
        }

        public System.Collections.ObjectModel.ReadOnlyCollection<string> ColumnNames
        {
            get { throw new NotImplementedException(); }
        }

        public System.Data.SqlClient.SqlCommand Command
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public System.Data.DataTable DataTable
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void ExecuteDataTable(string sql)
        {
            throw new NotImplementedException();
        }

        public void ExecuteProcedure(string procedureName)
        {
            throw new NotImplementedException();
        }

        public void ExeuteInOneTransaction(System.Collections.Specialized.StringCollection scripts)
        {
            throw new NotImplementedException();
        }

        public void SetParameterImage(string parameterName, object value)
        {
            throw new NotImplementedException();
        }

        public void AddCommand(string command)
        {
            throw new NotImplementedException();
        }

        public void Commit()
        {
            throw new NotImplementedException();
        }
    }
}