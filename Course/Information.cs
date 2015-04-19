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
        private BindingSource currentBindingSource;
        private string forFilter;
        private string forSort;
        public Information()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public Information(string sourse) : this()
        {
            switch (sourse)
            {
                case "слушатели":
                    currentBindingSource = traineesBindingSource;
                    clbFilter.Items.AddRange(new object[]{"ФИО слушателя","Группа", "E-mail"});
                    
                    break;
                case "преподаватели":
                    currentBindingSource = lecturerBindingSource;
                    break;
                case "экзамены":
                    currentBindingSource = examBindingSource;
                    break;
            }
            dataGridView1.DataSource = currentBindingSource;
        }

        private void getFilter()
        {
            switch (clbFilter.Text)
            {
                case "ФИО слушателя":
                    forFilter = "FIO";
                    break;
                case "Группа":
                    forFilter = "Group";
                    break;
                case "E-mail":
                    forFilter = "Email";
                    break;

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Information_Load(object sender, EventArgs e)
        {
            traineesTableAdapter.Fill(coursesDataSet.Trainees);
            timeSheetTableAdapter.Fill(coursesDataSet.TimeSheet);
            paymentTableAdapter.Fill(coursesDataSet.Payment);
            lecturerTableAdapter.Fill(coursesDataSet.Lecturer);
            groupTableAdapter.Fill(coursesDataSet.Group);
            examTableAdapter.Fill(coursesDataSet.Exam);
            disciplineTableAdapter.Fill(coursesDataSet.Discipline);
            courseTableAdapter.Fill(coursesDataSet.Course);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                getFilter();
                currentBindingSource.Filter = forFilter + " LIKE '%" + txtSearch.Text + "%'";
            }
            catch (Exception)
            {
                MessageBox.Show("\tВыберите поле для поиска\t", "Ошибка");
            }
            
        }

        private void clbFilter_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var list = sender as CheckedListBox;
            if (e.NewValue == CheckState.Checked)
                foreach (var index in list.CheckedIndices.Cast<int>().Where(index => index != e.Index))
                    list.SetItemChecked(index, false);
        }
    }
}
