using System;
using SchoolManagement.SqlProviderFolder;

namespace MyFirstTest
{
    public class MockQueryResultRow : IQueryResultRow
    {
        public T Field<T>(string fieldName)
        {
            return default(T);
        }

        public dynamic Field(string fieldName)
        {
            return null;
        }

        public T FieldOrDefault<T>(string fieldName)
        {
            throw new NotImplementedException();
        }

        public bool IsNull(string fieldName)
        {
            throw new NotImplementedException();
        }
    }
}