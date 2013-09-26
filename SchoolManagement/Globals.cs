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
            uiMainDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            uiMainDataGridView.BackgroundColor = Color.White;
            for (int i = 0; i < uiMainDataGridView.ColumnCount; i++)
            {
                uiMainDataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            Rectangle screenRectangle = form.RectangleToScreen(form.ClientRectangle);
            var bonus = 10;
            //if (form.Text == "Расписание уроков")
            //{
            //    bonus = 100;
            //}
            int titleHeight = screenRectangle.Top - form.Top + bonus;
            var height = (uiMainToolStrip.Height + uiMainDataGridView.Rows.GetRowsHeight(DataGridViewElementStates.None) +
                          uiMainDataGridView.ColumnHeadersHeight + titleHeight);
            form.Height = height > 1024 ? 1024 : height;
        }
    }
}
