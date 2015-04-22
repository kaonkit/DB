using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Course
{
    public partial class Report : Form
    {
        private string owner;
        private string querry;
        private DataTable dt;

        private Excel.Application xlApp;
        private Excel.Worksheet xlSheet;
        private Excel.Range xlSheetRange;

        public Report()
        {
            InitializeComponent();
        }

        public Report(string owner, string querry)
            : this()
        {

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.owner = owner;
            this.querry = querry;
        }

        private string completeSql(string filter)
        {
            StringBuilder res = new StringBuilder();
            if (filter == "") return querry;
            if (!querry.Contains("GROUP BY"))
            {
                res.Append(querry.Substring(0, querry.Length - 1) + filter + ";");
                return res.ToString();
            }
            string[] words = querry.Split();
            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i] == "GROUP" && words[i + 1] == "BY")
                {
                    for (int k = 0; k < i; k++)
                    {
                        res.Append(words[k] + " ");
                    }
                    res.Append(filter + " ");
                    for (int k = i; k < words.Length; k++)
                    {
                        res.Append(words[k] + " ");
                    }
                }
            }
            return res.ToString();
        }

        private void doSql(string filter)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(Main.Connection))
                {
                    sqlCon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(completeSql(filter), sqlCon);
                    dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private object[] getFilter(string querr)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(Main.Connection))
                {
                    sqlCon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(querr, sqlCon);
                    DataTable dt1 = new DataTable();
                    sda.Fill(dt1);
                    object[] obj = new object[dt1.Rows.Count];
                    for (int i = 0; i < dt1.Rows.Count; i++)
                    {
                        obj[i] = dt1.Rows[i][0];
                    }
                    return obj;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
                return null;
            }
        }

        public void toExcel(DataTable dtDataTable)
        {

            xlApp = new Excel.Application();
            try
            {
                //добавляем книгу
                xlApp.Workbooks.Add(Type.Missing);

                //делаем временно неактивным документ
                xlApp.Interactive = false;
                xlApp.EnableEvents = false;

                //выбираем лист на котором будем работать (Лист 1)
                xlSheet = (Excel.Worksheet)xlApp.Sheets[1];
                //Название листа
                xlSheet.Name = "Данные";

                int collInd = 0;
                int rowInd = 0;
                string data = "";

                //называем колонки
                for (int i = 0; i < dtDataTable.Columns.Count; i++)
                {
                    data = dtDataTable.Columns[i].ColumnName.ToString();
                    xlSheet.Cells[1, i + 1] = data;

                    //выделяем первую строку
                    xlSheetRange = xlSheet.Range["A1:Z1", Type.Missing];

                    //делаем полужирный текст и перенос слов
                    xlSheetRange.WrapText = true;
                    xlSheetRange.Font.Bold = true;
                }

                //заполняем строки
                for (rowInd = 0; rowInd < dtDataTable.Rows.Count; rowInd++)
                {
                    for (collInd = 0; collInd < dtDataTable.Columns.Count; collInd++)
                    {
                        data = dtDataTable.Rows[rowInd].ItemArray[collInd].ToString();
                        xlSheet.Cells[rowInd + 2, collInd + 1] = data;
                    }
                }

                //выбираем всю область данных
                xlSheetRange = xlSheet.UsedRange;

                //выравниваем строки и колонки по их содержимому
                xlSheetRange.Columns.AutoFit();
                xlSheetRange.Rows.AutoFit();

                if (owner == "курсы")
                {
                    //xlArea, xlBar, xlColumn, xlLine, xlPie, xlRadar, xlXYScatter, xlCombination, xl3DArea, xl3DBar, xl3DColumn, xl3DLine, xl3DPie, xl3DSurface, xlDoughnut, xlDefaultAutoFormat.
                    Excel.ChartObjects chartsobjrcts =
                        (Excel.ChartObjects)xlSheet.ChartObjects(Type.Missing);
                    Excel.ChartObject chartsobjrct = chartsobjrcts.Add(10, 200, 500, 400);
                    chartsobjrct.Chart.ChartWizard(xlSheet.get_Range("a1", "b" + (dtDataTable.Rows.Count + 1)),
                        Excel.XlChartType.xlPie,
                        Type.Missing,
                        Excel.XlRowCol.xlColumns,
                        Type.Missing,
                        Type.Missing,
                        true,
                        "Посещаемость курсов",
                        Type.Missing,
                        Type.Missing,
                        Type.Missing
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                //Показываем ексель
                xlApp.Visible = true;

                xlApp.Interactive = true;
                xlApp.ScreenUpdating = true;
                xlApp.UserControl = true;

                //Отсоединяемся от Excel
                releaseObject(xlSheetRange);
                releaseObject(xlSheet);
                releaseObject(xlApp);
            }
        }

        private void createDiagr()
        {
            Excel.Application excelapp;
            Excel.Workbooks excelappworkbooks;
            Excel.Workbook excelappworkbook;
            Excel.Sheets excelsheets;
            Excel.Worksheet excelworksheet;
            Excel.Range excelcells;
            Excel.Window excelWindow;

            excelapp = new Excel.Application();
            excelapp.Visible = true;


            excelworksheet = xlSheet;
            Excel.ChartObjects chartsobjrcts =
             (Excel.ChartObjects)excelworksheet.ChartObjects(Type.Missing);
            Excel.ChartObject chartsobjrct = chartsobjrcts.Add(10, 200, 500, 400);
            chartsobjrct.Chart.ChartWizard(excelworksheet.get_Range("D8", "K10"),
            Excel.XlChartType.xl3DArea, 2, Excel.XlRowCol.xlRows, Type.Missing,
              0, true, "Продажа рогов и копыт за неделю", "Дни недели", "Рога\\Копыта", Type.Missing);
        }

        private void btneExcel_Click(object sender, EventArgs e)
        {
            toExcel(dt);
            //createDiagr();
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show(ex.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                GC.Collect();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            switch (owner)
            {
                case "слушатели":
                    clbFilter.Items.AddRange(getFilter("SELECT CourseFulName FROM Course;"));
                    break;
                case "преподаватели":
                    clbFilter.Items.AddRange(getFilter("SELECT CourseFulName FROM Course;"));
                    break;
            }
            doSql("");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            switch (owner)
            {
                case "слушатели":
                    doSql(" AND C.CourseFulName = N'" + clbFilter.Text + "'");
                    break;
                case "преподаватели":
                    doSql(" AND C.CourseFulName = N'" + clbFilter.Text + "'");
                    break;
            }
        }

        private void clbFilter_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var list = sender as CheckedListBox;
            if (e.NewValue == CheckState.Checked)
                foreach (var index in list.CheckedIndices.Cast<int>().Where(index => index != e.Index))
                    list.SetItemChecked(index, false);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            doSql("");
        }

    }
}
