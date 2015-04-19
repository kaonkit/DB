﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using Course.CoursesDataSetTableAdapters;

namespace Course
{

    public partial class Main : Form
    {
        private Information info;
        private Querry querry;
        private Report report;
        private string sqlquerry;
        public static readonly string Connection = @ConfigurationManager.ConnectionStrings["Course.Properties.Settings.CoursesConnectionString"].ToString();

        public Main()
        {
            InitializeComponent();
        }

        private void CloseForms()
        {
            if (info != null)
            {
                info.Close();
                info = null;
            }
            if (querry != null)
            {
                querry.Close();
                querry = null;
            }
        }

        private void UpdateDb()
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

        private void FillDb()
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

        private void DoSql(string querr)
        {

            try
            {
                using (SqlConnection sqlCon = new SqlConnection(Connection))
                {
                    sqlCon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(querr, sqlCon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    report = new Report(dt);
                    report.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }

        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (info != null)
            {
                info.ClientSize = new Size(this.ClientSize.Width - 10, this.ClientSize.Height - 30);
                info.Location = new Point(0, 0);
            }
            if (querry != null)
            {
                querry.ClientSize = new Size(this.ClientSize.Width - 10, this.ClientSize.Height - 30);
                querry.Location = new Point(0, 0);
            }

            if (report != null)
            {
                report.ClientSize = new Size(this.ClientSize.Width - 10, this.ClientSize.Height - 30);
                report.Location = new Point(0, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseForms();
            info = new Information(cmbInfo.Text) { MdiParent = this };
            info.Show();
            Main_Resize(this, EventArgs.Empty);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateDb();
            Dispose();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDb();
            (new Edit(cmbInfo.Text)).ShowDialog();
            coursesDataSet.AcceptChanges();
            FillDb();
            button1_Click(this, EventArgs.Empty);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object[] args = null;
            UpdateDb();
            switch (cmbInfo.Text)
            {
                case "слушатели":
                    var st = new CoursesDataSet.TraineesDataTable();
                    traineesTableAdapter.FillBy(st, Convert.ToInt32(info.dataGridView1.SelectedRows[0].Cells[0].Value));
                    args = st.Rows[0].ItemArray;
                    break;
            }
            (new Edit(cmbInfo.Text, args)).ShowDialog();
            coursesDataSet.AcceptChanges();
            FillDb();
            button1_Click(this, EventArgs.Empty);
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (cmbInfo.Text)
            {
                case "слушатели":
                    traineesTableAdapter.DeleteQuery(Convert.ToInt32(info.dataGridView1.SelectedRows[0].Cells[0].Value));
                    break;
            }
            coursesDataSet.AcceptChanges();
            FillDb();
            button1_Click(this, EventArgs.Empty);
        }

        private void запросToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForms();
            querry = new Querry() { MdiParent = this };
            querry.Show();
        }

        private void слушателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlquerry =
                "SELECT T.FIO as 'ФИО слушателя', C.CourseFulName as 'Курс', T.Phone as 'Номер телефона', T.Email as 'E-mail' " +
                "FROM Trainees T, [Group] G, [Course] C " +
                "WHERE T.[Group] = G.GroupNum AND C.CourseAbbr = G.[Course];";
            DoSql(sqlquerry);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FillDb();
        }

    }
}
