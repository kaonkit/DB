using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Course
{
    public partial class Querry : Form
    {
        private IntelliSenseTextBox txtInput;
        private Main main;
        List<ListBox> lists;
        public Querry()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtInput = new IntelliSenseTextBox(listBox1)
            {
                Location = new Point(41, 60),
                Size = new Size(600, 100),
                Multiline = true,
                Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)))
            };
            Controls.Add(txtInput);
            autoComplete();
        }

        private void autoComplete(string s = null)
        {
            List<string> ISList = new List<string>(new string[] { "SELECT", "FROM", "WHERE", "COUNT", "HAVING", "GROUP BY", "MAX", "MIN", "AVG", "SUM", "ANY", "ALL" });
            ISList.AddRange(new string[] { "Course", "Discipline", "Exam", "Group", "Lecturer", "Payment", "TimeSheet", "Trainees" });
            ISList.AddRange(new string[] { "CourseAbbr", "CourseFulName", "Id", "NumberOfHours", "TraineeID", "DiscID", "Data", "Mark", "GroupNum", "NumberOfTrainees", "FIO", "Qualification", "RecordOfService", "Phone", "Email", "DisciplineID", "TraineesID", "Summa", "LectureID", "TypeOfTraining", "Payment", "DOB" });

            txtInput.Dictionary = ISList;

        }

        private void txtDo_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(Main.Connection))
                {
                    sqlCon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(txtInput.Text, sqlCon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            main.showgrp();
            Close();
        }

        private void Querry_Load(object sender, EventArgs e)
        {
            main = (Main)this.MdiParent;
            main.Size = new Size(1130, 450);
            main.Location = new Point(100, 100);
            lists = new List<ListBox>() { lstCourse, lstDiscipline, lstExam, lstGroupe, lstLecturer, lstPayment, lstTimeSheet, lstTrainees };
            lstCourse.Items.AddRange(new string[] { "CourseAbbr", "CourseFulName" });
            lstDiscipline.Items.AddRange(new string[] { "Id", "Group", "NumberOfHours", "CourseAbbr" });
            lstExam.Items.AddRange(new string[] { "TraineeID", "DiscID", "Data", "Mark" });
            lstGroupe.Items.AddRange(new string[] { "GroupNum", "Course", "NumberOfHours", "CourseAbbr" });
            lstLecturer.Items.AddRange(new string[] { "Id", "FIO", "Qualification", "RecordOfService", "Phone", "Email" });
            lstPayment.Items.AddRange(new string[] { "TraineesID", "DisciplineID", "Data", "Summa" });
            lstTimeSheet.Items.AddRange(new string[] { "Id", "DisciplineID", "LectureID", "TypeOfTraining", "NumberOfHours", "Payment" });
            lstTrainees.Items.AddRange(new string[] { "Id", "FIO", "Group", "DOB", "Phone", "Email" });
        }

        private void OnCheck(object sender, EventArgs e)
        {
            ListBox list = (ListBox)sender;
            string c = "", res = "";
            c = list.SelectedItem != null ? list.SelectedItem.ToString() : "";
            if (c == "") return;
            switch (list.Name)
            {
                case "lstCourse":
                    res = "Course.";
                    break;
                case "lstDiscipline":
                    res = "Discipline.";
                    break;
                case "lstExam":
                    res = "Exam.";
                    break;
                case "lstGroupe":
                    res = "Groupe.";
                    break;
                case "lstLecturer":
                    res = "Lecturer.";
                    break;
                case "lstPayment":
                    res = "Payment.";
                    break;
                case "lstTimeSheet":
                    res = "TimeSheet.";
                    break;
                case "lstTrainees":
                    res = "Trainees.";
                    break;
            }
            res += c;
            txtInput.AppendText(res);
            list.ClearSelected();
            listBox1.Visible = false;
            txtInput.Focus();
        }
    }

}

