using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Course
{

    public partial class Main : Form
    {
        private Information info;
        private Querry querry;
        private Report report;
        private string sqlquerry;
        private DataTable dt, timetabledt;
        private string owner;
        public static bool firstNeedOpen = false;
        private bool close = false;
        private Thread htThread, timetableThread;
        List<List<string>> timetable = new List<List<string>>(30);

        public static readonly string Connection = @ConfigurationManager.ConnectionStrings["Course.Properties.Settings.CoursesConnectionString"].ToString();

        public Main()
        {
            InitializeComponent();
            htThread = new Thread(check);
            htThread.Start();
            timetableThread = new Thread(genTimetable);
            timetableThread.Start();
        }
        #region timetable
        private void genTimetable()
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(Connection))
                {
                    string querr = "SELECT L.FIO, C.CourseFulName, D.[Group], TS.TypeOfTraining, TS.NumberOfHours " +
                                   "FROM Lecturer L, TimeSheet TS, Discipline D, Course C " +
                                   "WHERE L.Id = TS.LectureID AND TS.DisciplineID = D.Id AND D.CourseAbbr = C.CourseAbbr" +
                                   " ORDER BY L.FIO;";
                    sqlCon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(querr, sqlCon);
                    dt = new DataTable();
                    sda.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            //int countall = 0;
            //int count = 0;

            for (int i = 0; i < 30; i++)
                timetable.Add(new List<string>());

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int quantity = Int32.Parse(dt.Rows[i][4].ToString()) / 2;
                int t1 = 30 / quantity;
                FillTimetable(t1, i, quantity);
                // countall += quantity;
            }
            //foreach (var c in timetable)
            //   count += c.Count;
            timetabledt = GetTable();
        }

        private void FillTimetable(int step, int row, int quantity)
        {
            int count = 0;
            var max = timetable.Max(x => x.Count);
            double avg = 0;
            try
            {
                avg = (from List<string> lst in timetable
                       where lst.Count != 0
                       select lst).Average(x => x.Count);
            }
            catch (Exception)
            {
                // ignored
            }
            int c = 1;
            int repeat = 0;
            for (int i = 0; count < quantity; )
            {
                if (i >= 30) i = 0;
                if (timetable[i].Count + 1 > max + c || timetable[i].Count + 1 > avg + 1)
                {
                    i++;
                    if (i >= 30)
                    {
                        i = 0;
                        repeat++;
                        if (repeat == 2) c++;
                    }
                    continue;
                }
                timetable[i].Add(dt.Rows[row][0] + "_" +
                    dt.Rows[row][1] + "_" +
                    dt.Rows[row][2] + "_" +
                    dt.Rows[row][3]);
                count++;
                i += step;
                repeat = 0;
                c = 1;
            }
        }

        private DataTable GetTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("День");
            table.Columns.Add("ФИО");
            table.Columns.Add("Курс");
            table.Columns.Add("Группа");
            table.Columns.Add("Тип занятия");

            for (int i = 0; i < timetable.Count; i++)
            {
                for (int k = 0; k < timetable[i].Count; k++)
                {
                    string[] str = timetable[i][k].Split('_');
                    table.Rows.Add(i + 1 + "-е число", str[0], str[1], str[2], str[3]);
                }
                table.Rows.Add();
            }
            return table;
        }
        #endregion

        private void check()
        {
            while (!close)
            {
                if (firstNeedOpen) grpBoxMain.Show();
                Thread.Sleep(1000);
            }
        }

        public void CloseForms()
        {
            grpBoxMain.Hide();
            firstNeedOpen = false;
            foreach (Form mdicf in this.MdiChildren)
                mdicf.Close();
        }

        public void UpdateDb()
        {
            traineesTableAdapter.Update(coursesDataSet);
            lecturerTableAdapter.Update(coursesDataSet);
            groupTableAdapter.Update(coursesDataSet);
            disciplineTableAdapter.Update(coursesDataSet);
            timeSheetTableAdapter.Update(coursesDataSet);
            examTableAdapter.Update(coursesDataSet);
            paymentTableAdapter.Update(coursesDataSet);
            courseTableAdapter.Update(coursesDataSet);
        }

        public void FillDb()
        {
            traineesTableAdapter.Fill(coursesDataSet.Trainees);
            lecturerTableAdapter.Fill(coursesDataSet.Lecturer);
            groupTableAdapter.Fill(coursesDataSet.Group);
            disciplineTableAdapter.Fill(coursesDataSet.Discipline);
            timeSheetTableAdapter.Fill(coursesDataSet.TimeSheet);
            examTableAdapter.Fill(coursesDataSet.Exam);
            paymentTableAdapter.Fill(coursesDataSet.Payment);
            courseTableAdapter.Fill(coursesDataSet.Course);
        }

        private void ReportForm(string querr, string owner)
        {
            CloseForms();
            report = new Report(owner, querr) { MdiParent = this };
            report.Show();
            Main_Resize(this, EventArgs.Empty);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FillDb();
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (info != null)
            {
                info.ClientSize = new Size(ClientSize.Width - 10, ClientSize.Height - 30);
                info.Location = new Point(0, 0);
            }
            if (querry != null)
            {
                querry.ClientSize = new Size(ClientSize.Width - 10, ClientSize.Height - 30);
                querry.Location = new Point(0, 0);
            }
            if (report != null)
            {
                report.ClientSize = new Size(ClientSize.Width - 10, ClientSize.Height - 30);
                report.Location = new Point(0, 0);
            }
        }

        public void open(string owner)
        {
            CloseForms();
            info = new Information(owner) { MdiParent = this };
            Main_Resize(this, EventArgs.Empty);
            info.Show();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            owner = ((Button)sender).Name;
            open(owner);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            close = true;
            htThread.Abort(); 
            
            UpdateDb();
            traineesTableAdapter.Dispose();
            timeSheetTableAdapter.Dispose();
            paymentTableAdapter.Dispose();
            lecturerTableAdapter.Dispose();
            groupTableAdapter.Dispose();
            examTableAdapter.Dispose();
            disciplineTableAdapter.Dispose();
            courseTableAdapter.Dispose();
            Dispose();
            
        }

        private void запросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForms();
            querry = new Querry { MdiParent = this };
            querry.Show();
            Main_Resize(this, EventArgs.Empty);
        }

#region querries

        private void btnTrInfo_Click(object sender, EventArgs e)
        {
            sqlquerry =
                "SELECT T.FIO as 'ФИО слушателя', C.CourseFulName as 'Курс', T.Phone as 'Номер телефона', T.Email as 'E-mail' " +
                "FROM Trainees T, [Group] G, [Course] C " +
                "WHERE T.[Group] = G.GroupNum AND C.CourseAbbr = G.[Course];";
            ReportForm(sqlquerry, "слушатели");
        }

        private void btnLcInfo_Click(object sender, EventArgs e)
        {
            sqlquerry = "SELECT DISTINCT L.FIO as 'ФИО преподавателя', L.Qualification as 'Квалификация', C.CourseFulName as 'Курс', L.Phone as 'Номер телефона', L.Email as 'E-mail' " +
                        "FROM Lecturer L, TimeSheet TS, Discipline D, Course C " +
                        "WHERE L.Id = TS.LectureID AND TS.DisciplineID = D.Id AND D.CourseAbbr = C.CourseAbbr;";
            ReportForm(sqlquerry, "преподаватели");
        }

        private void btnTimeSheetStat_Click(object sender, EventArgs e)
        {
            sqlquerry = "SELECT L.FIO as 'ФИО преподавателя', C.CourseFulName as 'Курс', SUM(TS.NumberOfHours) as 'Количество часов' " +
                        "FROM Lecturer L, TimeSheet TS, Discipline D, Course C " +
                        "WHERE L.Id = TS.LectureID AND TS.DisciplineID = D.Id AND D.CourseAbbr = C.CourseAbbr " +
                        "GROUP BY L.FIO, C.CourseFulName " +
                        "ORDER BY L.FIO;";
            ReportForm(sqlquerry, "преподаватели");
        }

        private void btnCoursesStat_Click(object sender, EventArgs e)
        {
            sqlquerry = "SELECT C.CourseFulName as 'Название курса', SUM(G.NumberOfTrainees) as 'Количество слушателей' " +
            "FROM [Group] G, Discipline D, Course C " +
            "WHERE C.CourseAbbr = D.CourseAbbr AND D.[Group] = G.GroupNum " +
            "GROUP BY C.CourseFulName " +
            "ORDER BY C.CourseFulName;";
            ReportForm(sqlquerry, "курсы");
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            (new Report()).toExcel(timetabledt);
            timetable.Clear();
        }
#endregion
    }
}
