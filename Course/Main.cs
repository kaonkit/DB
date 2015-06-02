using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.ComponentModel;

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
            btnDiscipline.Visible = false;
            timetableThread = new Thread(genTimetable);
            timetableThread.Start();
            pictureBox1.Visible = false;
            label5.Visible = false;
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

        public void CloseForms()
        {
            grpBoxMain.Visible = false;
            firstNeedOpen = false;
            foreach (Form mdicf in this.MdiChildren)
                mdicf.Close();
            if (info != null)
            {
                info.Close();
            }
        }

        public void UpdateDb()
        {
            traineesTableAdapter.Update(CourseDataSet);
            lecturerTableAdapter.Update(CourseDataSet);
            groupTableAdapter.Update(CourseDataSet);
            disciplineTableAdapter.Update(CourseDataSet);
            timeSheetTableAdapter.Update(CourseDataSet);
            examTableAdapter.Update(CourseDataSet);
            paymentTableAdapter.Update(CourseDataSet);
            courseTableAdapter.Update(CourseDataSet);
        }

        public void FillDb()
        {
            traineesTableAdapter.Fill(CourseDataSet.Trainees);
            lecturerTableAdapter.Fill(CourseDataSet.Lecturer);
            groupTableAdapter.Fill(CourseDataSet.Group);
            disciplineTableAdapter.Fill(CourseDataSet.Discipline);
            timeSheetTableAdapter.Fill(CourseDataSet.TimeSheet);
            examTableAdapter.Fill(CourseDataSet.Exam);
            paymentTableAdapter.Fill(CourseDataSet.Payment);
            courseTableAdapter.Fill(CourseDataSet.Course);
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
                info.ClientSize = new Size(ClientSize.Width - 5, ClientSize.Height - 28);
                info.Location = new Point(0, 0);

            }
            if (querry != null)
            {
                querry.ClientSize = new Size(ClientSize.Width - 5, ClientSize.Height - 28);
                querry.Location = new Point(0, 0);
            }
            if (report != null)
            {
                report.ClientSize = new Size(ClientSize.Width - 5, ClientSize.Height - 28);
                report.Location = new Point(0, 0);
            }
        }

        public void open(string owner)
        {
            CloseForms();
            try
            {
                info = new Information(owner) { MdiParent = this };
                info.Show();
                Main_Resize(this, EventArgs.Empty);
            }
            catch (InvalidOperationException ex)
            {
                this.Refresh();
                open(owner);
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            owner = ((Button)sender).Name;
            open(owner);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
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
            ReportForm(sqlquerry, "trainees");
        }

        private void btnLcInfo_Click(object sender, EventArgs e)
        {
            sqlquerry = "SELECT DISTINCT L.FIO as 'ФИО преподавателя', L.Qualification as 'Квалификация', C.CourseFulName as 'Курс', L.Phone as 'Номер телефона', L.Email as 'E-mail' " +
                        "FROM Lecturer L, TimeSheet TS, Discipline D, Course C " +
                        "WHERE L.Id = TS.LectureID AND TS.DisciplineID = D.Id AND D.CourseAbbr = C.CourseAbbr;";
            ReportForm(sqlquerry, "lecturer");
        }

        private void btnTimeSheetStat_Click(object sender, EventArgs e)
        {
            sqlquerry = "SELECT L.FIO as 'ФИО преподавателя', C.CourseFulName as 'Курс', SUM(TS.NumberOfHours) as 'Количество часов' " +
                        "FROM Lecturer L, TimeSheet TS, Discipline D, Course C " +
                        "WHERE L.Id = TS.LectureID AND TS.DisciplineID = D.Id AND D.CourseAbbr = C.CourseAbbr " +
                        "GROUP BY L.FIO, C.CourseFulName;";
            ReportForm(sqlquerry, "timesheet");
        }

        private void btnCoursesStat_Click(object sender, EventArgs e)
        {
            sqlquerry = "SELECT C.CourseFulName as 'Название курса', SUM(G.NumberOfTrainees) as 'Количество слушателей' " +
            "FROM [Group] G, Discipline D, Course C " +
            "WHERE C.CourseAbbr = D.CourseAbbr AND D.[Group] = G.GroupNum " +
            "GROUP BY C.CourseFulName;";
            ReportForm(sqlquerry, "courses");
        }

        private void btnTimeTable_Click(object sender, EventArgs e)
        {

            (new Report() { MdiParent = this }).toExcel(timetabledt);
            timetable.Clear();

        }

        private void btmPayment_Click(object sender, EventArgs e)
        {
            sqlquerry = "SELECT T.FIO as 'ФИО слушателя', C.CourseFulName as 'Название курса', P.Data as 'Дата оплаты', P.Summa as 'Сумма' " +
                        "FROM Trainees T, Discipline D, Course C, Payment P " +
                        "WHERE C.CourseAbbr = D.CourseAbbr AND P.DisciplineID = D.Id AND T.Id = P.TraineesID;";
            ReportForm(sqlquerry, "payment");
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            sqlquerry = "SELECT C.CourseFulName as 'Название курса', T.FIO as 'ФИО слушателя', E.Mark as 'Оценка', E.Data as 'Дата сдачи'" +
                        "FROM Trainees T, Discipline D, Course C, Exam E " +
                        "WHERE C.CourseAbbr = D.CourseAbbr AND E.DiscID = D.Id AND T.Id = E.TraineeID;";
            ReportForm(sqlquerry, "exam");
        }
        #endregion

        public void showgrp()
        {
            grpBoxMain.Visible = true;
            this.Size = new Size(781, 506);
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                                      (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);

        }
        public void showPicture(bool b)
        {
            pictureBox1.Visible = b;
            label5.Visible = b;
        }
    }
}