namespace SchoolManagement.SqlProviderFolder
{
    public interface IQueryResultRow
    {
        T Field<T>(string fieldName);
        dynamic Field(string fieldName);
        T FieldOrDefault<T>(string fieldName);
        bool IsNull(string fieldName);
    }
}
