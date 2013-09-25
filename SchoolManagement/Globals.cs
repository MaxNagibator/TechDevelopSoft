using System.Drawing;
using System.Windows.Forms;
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


        public static void SetColumnWidthAndFormHeight(Form form, DataGridView uiMainDataGridView, Control uiMainToolStrip)
        {
            for (int i = 1; i < uiMainDataGridView.ColumnCount; i++)
            {
                uiMainDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            Rectangle screenRectangle = form.RectangleToScreen(form.ClientRectangle);
            int titleHeight = screenRectangle.Top - form.Top + 10;
            var height = (uiMainToolStrip.Height + uiMainDataGridView.Rows.GetRowsHeight(DataGridViewElementStates.None) +
                          uiMainDataGridView.ColumnHeadersHeight + titleHeight);
            form.Height = height > 600 ? 600 : height;
        }
    }
}
