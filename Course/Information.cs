using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course
{
    public partial class Information : Form
    {
        public Information()
        {
            InitializeComponent();
        }

        public Information(string sourse) : this()
        {
            switch (sourse)
            {
                case "слушатели":
                    dataGridView1.DataSource = traineesBindingSource;
                    break;
                case "преподаватели":
                    dataGridView1.DataSource = lecturerBindingSource;
                    break;
                case "экзамены":
                    dataGridView1.DataSource = examBindingSource;
                    break;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.Lecturer". При необходимости она может быть перемещена или удалена.
            this.lecturerTableAdapter.Fill(this.coursesDataSet.Lecturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.Payment". При необходимости она может быть перемещена или удалена.
            this.paymentTableAdapter.Fill(this.coursesDataSet.Payment);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.TimeSheet". При необходимости она может быть перемещена или удалена.
            this.timeSheetTableAdapter.Fill(this.coursesDataSet.TimeSheet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.Trainees". При необходимости она может быть перемещена или удалена.
            this.traineesTableAdapter.Fill(this.coursesDataSet.Trainees);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.Group". При необходимости она может быть перемещена или удалена.
            this.groupTableAdapter.Fill(this.coursesDataSet.Group);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.Exam". При необходимости она может быть перемещена или удалена.
            this.examTableAdapter.Fill(this.coursesDataSet.Exam);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.Discipline". При необходимости она может быть перемещена или удалена.
            this.disciplineTableAdapter.Fill(this.coursesDataSet.Discipline);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "coursesDataSet.Course". При необходимости она может быть перемещена или удалена.
            this.courseTableAdapter.Fill(this.coursesDataSet.Course);
            traineesTableAdapter.Fill(coursesDataSet.Trainees);
            timeSheetTableAdapter.Fill(coursesDataSet.TimeSheet);
            paymentTableAdapter.Fill(coursesDataSet.Payment);
            lecturerTableAdapter.Fill(coursesDataSet.Lecturer);
            groupTableAdapter.Fill(coursesDataSet.Group);
            examTableAdapter.Fill(coursesDataSet.Exam);
            disciplineTableAdapter.Fill(coursesDataSet.Discipline);
            courseTableAdapter.Fill(coursesDataSet.Course);
        }

    }
}
