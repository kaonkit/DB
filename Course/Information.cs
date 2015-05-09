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
        private BindingSource currentBindingSource, forSearchBindingSource;
        private string forFilter, forSort;
        private int colnum;
        private bool forSearch;
        public Information()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public Information(string sourse)
            : this()
        {
            switch (sourse)
            {
                case "слушатели":
                    currentBindingSource = traineesBindingSource;
                    clbSearch.Items.AddRange(new object[] { "ФИО", "Группа", "E-mail" });
                    clbSort.Items.AddRange(new object[] { "ФИО", "Группа", "Дата рождения", "E-mail" });
                    break;
                case "преподаватели":
                    currentBindingSource = lecturerBindingSource;
                    clbSearch.Items.AddRange(new object[] { "ФИО", "Квалификация", "Стаж работы", "E-mail" });
                    clbSort.Items.AddRange(new object[] { "ФИО", "Квалификация", "Стаж работы", "E-mail" });
                    break;
                case "экзамены":
                    currentBindingSource = examBindingSource;
                    clbSearch.Items.AddRange(new object[] { "ID слушателя", "ID дисциплины", "Оценка" });
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
            forSearch = true;
            switch (clbSearch.Text)
            {
                case "ФИО":
                    forFilter = "FIO";
                    colnum = 1;
                    break;
                case "Группа":
                    forFilter = "Group";
                    colnum = 2;
                    break;
                case "E-mail":
                    forFilter = "Email";
                    colnum = 5;
                    break;
                case "Квалификация":
                    forFilter = "Qualification";
                    colnum = 2;
                    break;
                case "Стаж работы":
                    forFilter = "RecordOfService";
                    colnum = 3;
                    break;
                case "ID слушателя":
                    forFilter = "TraineeID";
                    colnum = 0;
                    break;
                case "ID дисциплины":
                    forFilter = "DiscID";
                    colnum = 1;
                    break;
                case "Дата":
                    forFilter = "Data";
                    colnum = 2;
                    break;
                case "Оценка":
                    forFilter = "Mark";
                    colnum = 3;
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
            getFilter();
            if (!forSearch)
            {
                MessageBox.Show("\tВыберите поле для поиска\t", "Ошибка");
                return;
            }
            dataGridView1.ClearSelection();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[colnum, i].Value.ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
                    dataGridView1.Rows[i].Selected = true;
            }
        }

        private void btnStopSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            txtSearch.Clear();
            forSearch = false;
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
            if (clbSearch.CheckedItems == null)
                forSearch = false;
            try
            {
                getSort();
                currentBindingSource.Sort = forSort;
                if (forSearch)
                    btnSearch_Click(this, EventArgs.Empty);
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
