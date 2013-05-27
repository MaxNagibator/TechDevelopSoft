using System.Xml.Linq;
using System.IO;
using AuroraWebServicesClient;
using System;
using System.Windows.Forms;

namespace Interfaces
{
	public class GuiLocalSettings : ILocalSettings
	{
        public string ConnectionString { get; set; }
        public SqlProvider GetSqlProvider()
        {
            return new SqlProvider(this);
        }
	}
}