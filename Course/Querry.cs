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

        public Querry()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtInput = new IntelliSenseTextBox(listBox1)
            {
                Location = new Point(50, 20),
                Size = new Size(650, 105),
                Multiline = true
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

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {

            Keys keysmod2 = ModifierKeys;
            //tip;
            if (keysmod2 == Keys.Control)
            {

                if (e.KeyCode == Keys.Space)
                {
                    ListBox tip = new ListBox
                    {
                        Location =
                            new Point(Int32.Parse(txtInput.Location.X.ToString()) + 40, Int32.Parse(txtInput.Location.Y.ToString()) + 40)

                    };
                    tip.Items.AddRange(new object[] { "select", "update" });
                    Controls.Add(tip);
                }

            }
        }
    }

}

