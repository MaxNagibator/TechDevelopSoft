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


        public static void SetColumnWidthAndFormHeight(Form form, DataGridView uiMainDataGridView, ToolStrip uiMainToolStrip)
        {
            uiMainDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            uiMainDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Rectangle screenRectangle = form.RectangleToScreen(form.ClientRectangle);
            int titleHeight = screenRectangle.Top - form.Top + 8;
            var height = (uiMainToolStrip.Height + uiMainDataGridView.Rows.GetRowsHeight(DataGridViewElementStates.None) +
                          uiMainDataGridView.ColumnHeadersHeight + titleHeight);
            form.Height = height > 600 ? 600 : height;
        }
    }
}
