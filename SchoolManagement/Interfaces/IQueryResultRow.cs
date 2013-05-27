using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public interface IQueryResultRow
    {
        T Field<T>(string fieldName);
        T FieldOrDefault<T>(string fieldName);
    }
}
