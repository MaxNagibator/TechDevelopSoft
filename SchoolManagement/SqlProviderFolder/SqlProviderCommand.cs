using System.Collections.Generic;
using System.Linq;

namespace SchoolManagement.SqlProviderFolder
{
    public class SqlProviderCommand
    {
        public class Parameter
        {
            public Parameter(string name, object value)
            {
                Name = name;
                Value = value;
            }

            public string Name { get; set; }
            public object Value { get; set; }
        }

        private Dictionary<string, object> _parameters;

        public SqlProviderCommand(Dictionary<string, object> parameters)
        {
            _parameters = parameters;
        }

        public string Instruction { get; set; }

        public void AddParameterWithValue(string name, object value)
        {
            _parameters.Add(name, value);
        }

        public IEnumerable<Parameter> Parameters
        {
            get
            {
                return _parameters.Select(keyValue => new Parameter(keyValue.Key, keyValue.Value));
            }
        }
    }
}
