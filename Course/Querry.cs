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
                Location = new Point(50, 20),
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseDataSet.Course". При необходимости она может быть перемещена или удалена.
            this.courseTableAdapter.Fill(this.courseDataSet.Course);
            main = (Main)this.MdiParent;
            main.Size = new Size(1130, 450);
            main.Location = new Point(100, 100);
            lists = new List<ListBox>() {listBox2, listBox3, listBox4, listBox5, listBox6, listBox7, listBox8, listBox9 };
            listBox2.Items.AddRange(new string[] { "CourseAbbr", "CourseFulName" });
            listBox3.Items.AddRange(new string[] { "Id", "Group", "NumberOfHours", "CourseAbbr" });
            listBox4.Items.AddRange(new string[] { "TraineeID", "DiscID", "Data", "Mark" });
            listBox5.Items.AddRange(new string[] { "GroupNum", "Course", "NumberOfHours", "CourseAbbr" });
            listBox6.Items.AddRange(new string[] { "Id", "FIO", "Qualification", "RecordOfService", "Phone", "Email" });
            listBox7.Items.AddRange(new string[] { "TraineesID", "DisciplineID", "Data", "Summa" });
            listBox8.Items.AddRange(new string[] { "Id", "DisciplineID", "LectureID", "TypeOfTraining", "NumberOfHours", "Payment" });
            listBox9.Items.AddRange(new string[] { "Id", "FIO", "Group", "DOB", "Phone", "Email" });
        }

        private void OnCheck(object sender, EventArgs e) {
            ListBox list = (ListBox)sender;
            txtInput.Text += list.SelectedItem != null ? list.SelectedItem.ToString():"";
            foreach (ListBox l in lists) {
                if (list != l) {
                    l.ClearSelected();
                }
            }
        }
    }

}

