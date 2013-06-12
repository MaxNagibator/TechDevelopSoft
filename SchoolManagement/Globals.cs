using SchoolManagement.SqlProviderFolder;

namespace SchoolManagement
{
    public class Globals
    {
        public static LocalSettings LocalSettings = new LocalSettings();
        public static string SqlProviderConnectionString { get; set; }
        public static bool IsRootMode { get; set; }

        public static SqlProvider GetSqlProvider()
        {
            return new SqlProvider(LocalSettings.ConnectionString);
        }
    }
}
