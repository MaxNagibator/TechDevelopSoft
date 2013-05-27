using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Interfaces
{
    public interface ISqlProvider : IDisposable
    {
        void ExecuteNonQuery(string sql);
        int ExecuteScalar(string sql);
        int ExecuteInt32WithNullAsZero(string sql);
        bool ExecuteBooleanWithNullAsFalse(string sql);
        void SetParameter(string parameterName, object value);
        void ExecuteQuery(string sql);
        string ExecuteString(string sql);
        ReadOnlyCollection<IQueryResultRow> Rows { get; }
        bool HasRows { get; }
        IQueryResultRow FirstRow { get; }
    }
}
