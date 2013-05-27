using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;

namespace SchoolManagement.SqlProviderFolder
{
    public interface ISqlProvider : IDisposable
    {
        void ExecuteNonQuery(string sql);

        int ExecuteScalar(string sql);

        int ExecuteInt32WithNullAsZero(string sql);

        bool ExecuteBooleanWithNullAsFalse(string sql);

        void SetParameter(string parameterName, object value);

        void SetParameterImage(string parameterName, object value);

        void ExecuteQuery(string sql);

        void ExecuteProcedure(string procedureName);

        string ExecuteString(string sql);

        ReadOnlyCollection<IQueryResultRow> Rows { get; }

        ReadOnlyCollection<string> ColumnNames { get; }

        bool HasRows { get; }

        IQueryResultRow FirstRow { get; }

        [Obsolete("use SetParameter()!")]
        SqlCommand Command { get; set; }

        [Obsolete("use 'Rows' property with 'ExecuteQuery()' method!")]
        DataTable DataTable { get; set; }

        [Obsolete("use ExecuteQuery()!")]
        void ExecuteDataTable(string sql);

        void ExeuteInOneTransaction(StringCollection scripts);
    }
}