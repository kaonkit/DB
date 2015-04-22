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
        private string forFilter, forSort;
        private bool isInt;
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
                    clbFilter.Items.AddRange(new object[]{"ФИО","Группа", "E-mail"});
                    clbSort.Items.AddRange(new object[] { "ФИО", "Группа", "Дата рождения", "E-mail" });
                    break;
                case "преподаватели":
                    currentBindingSource = lecturerBindingSource;
                    clbFilter.Items.AddRange(new object[]{"ФИО","Квалификация","Стаж работы", "E-mail"});
                    clbSort.Items.AddRange(new object[] { "ФИО", "Квалификация", "Стаж работы", "E-mail" });
                    break;
                case "экзамены":
                    currentBindingSource = examBindingSource;
                    clbFilter.Items.AddRange(new object[] { "ID слушателя", "ID дисциплины", "Оценка" });
                    clbSort.Items.AddRange(new object[] { "ID слушателя", "ID дисциплины", "Оценка" });
                    break;
            }
            dataGridView1.DataSource = currentBindingSource;
        }

        private void getSort()
        {
            switch (clbSort.Text)
            {
                case "ФИО":
                    forSort = "FIO";
                    break;
                case "Группа":
                    forSort = "Group";
                    break;
                case "Дата рождения":
                    forSort = "DOB";
                    break;
                case "E-mail":
                    forSort = "Email";
                    break;
                case "Квалификация":
                    forSort = "Qualification";
                    break;
                case "Стаж работы":
                    forSort = "RecordOfService";
                    break;
                case "ID слушателя":
                    forSort = "TraineeID";
                    break;
                case "ID дисциплины":
                    forSort = "DiscID";
                    break;
                case "Дата":
                    forSort = "Data";
                    break;
                case "Оценка":
                    forSort = "Mark";
                    break;
            }
        }

        private void getFilter()
        {
            switch (clbFilter.Text)
            {
                case "ФИО":
                    forFilter = "FIO";
                    break;
                case "Группа":
                    forFilter = "Group";
                    break;
                case "E-mail":
                    forFilter = "Email";
                    break;
                case "Квалификация":
                    forFilter = "Qualification";
                    break;
                case "Стаж работы":
                    forFilter = "RecordOfService";
                    isInt = true;
                    break;
                case "ID слушателя":
                    forFilter = "TraineeID";
                    isInt = true;
                    break;
                case "ID дисциплины":
                    forFilter = "DiscID";
                    isInt = true;
                    break;
                case "Дата":
                    forFilter = "Data";
                    break;
                case "Оценка":
                    forFilter = "Mark";
                    isInt = true;
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
                currentBindingSource.Filter = forFilter + (isInt ? ("=" + txtSearch.Text) : (" LIKE '%" + txtSearch.Text + "%'"));
            }
            catch (Exception ex)
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

        private void btnSort_Click(object sender, EventArgs e)
        {
            try
            {
                getSort();
                currentBindingSource.Sort = forSort;
            }
            catch (Exception ex)
            {
                MessageBox.Show("\tВыберите поле для сортировки\t", "Ошибка");
            }
        }

        private void clbSort_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var list = sender as CheckedListBox;
            if (e.NewValue == CheckState.Checked)
                foreach (var index in list.CheckedIndices.Cast<int>().Where(index => index != e.Index))
                    list.SetItemChecked(index, false);
        }

        private void Information_FormClosing(object sender, FormClosingEventArgs e)
        {
            traineesTableAdapter.Dispose();
            timeSheetTableAdapter.Dispose();
            paymentTableAdapter.Dispose();
            lecturerTableAdapter.Dispose();
            groupTableAdapter.Dispose();
            examTableAdapter.Dispose();
            disciplineTableAdapter.Dispose();
            courseTableAdapter.Dispose();
        }
    }
}
