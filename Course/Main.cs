using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Course.CoursesDataSetTableAdapters;

namespace Course
{

    public partial class Main : Form
    {
        private Information info;
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            info = new Information(cmbInfo.Text) { MdiParent = this };
            info.Show();
            Main_Resize(this, EventArgs.Empty);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (info != null)
            {
                info.ClientSize = new Size(this.ClientSize.Width - 10, this.ClientSize.Height - 30);
                info.Location = new Point(0, 0);
            }
        }

        private void UpdateDB()
        {
            traineesTableAdapter.Update(coursesDataSet);
            lecturerTableAdapter.Update(coursesDataSet);
            groupTableAdapter.Update(coursesDataSet);
            disciplineTableAdapter.Update(coursesDataSet);
            timeSheetTableAdapter.Update(coursesDataSet);
            examTableAdapter.Update(coursesDataSet);
            paymentTableAdapter.Update(coursesDataSet);
            specialityTableAdapter.Update(coursesDataSet);
            courseTableAdapter.Update(coursesDataSet);
        }

        private void FillDB()
        {
            traineesTableAdapter.Fill(coursesDataSet.Trainees);
            lecturerTableAdapter.Fill(coursesDataSet.Lecturer);
            groupTableAdapter.Fill(coursesDataSet.Group);
            disciplineTableAdapter.Fill(coursesDataSet.Discipline);
            timeSheetTableAdapter.Fill(coursesDataSet.TimeSheet);
            examTableAdapter.Fill(coursesDataSet.Exam);
            paymentTableAdapter.Fill(coursesDataSet.Payment);
            specialityTableAdapter.Fill(coursesDataSet.Speciality);
            courseTableAdapter.Fill(coursesDataSet.Course);

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDB();
            (new Edit()).ShowDialog();
            coursesDataSet.AcceptChanges();
            FillDB();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateDB();
            Dispose();
        }

    }
}
