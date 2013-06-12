using System;
using System.Collections.Generic;
using SchoolManagement.SqlProviderFolder;

namespace MyFirstTest
{
    public class MockLocalSettings
    {
        private MockSqlProvider _currentMockSqlProvider;

        public string ConnectionString
        {
            get { throw new NotImplementedException(); }
        }

        public ISqlProvider GetSqlProvider()
        {
            _currentMockSqlProvider = new MockSqlProvider();
            return _currentMockSqlProvider;
        }

        public IList<string> SqlQueries
        {
            get
            {
                return _currentMockSqlProvider.Queries;
            }
        }
    }
}