using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Course
{
    public partial class Information : Form
    {
        private BindingSource currentBindingSource;
        private string forFilter, forSort;
        private int colnum;
        private bool forSearch;
        private string owner;
        public Information()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnNext.Visible = false;
        }

        public Information(string sourse)
            : this()
        {
            owner = sourse;
            switch (owner)
            {
                case "btnTrainees":
                    currentBindingSource = traineesBindingSource;
                    clbSearch.Items.AddRange(new object[] { "ФИО", "Группа", "E-mail" });
                    clbSort.Items.AddRange(new object[] { "ФИО", "Группа", "Дата рождения", "E-mail" });
                    break;
                case "btnLectures":
                    currentBindingSource = lecturerBindingSource;
                    clbSearch.Items.AddRange(new object[] { "ФИО", "Квалификация", "Стаж работы", "E-mail" });
                    clbSort.Items.AddRange(new object[] { "ФИО", "Квалификация", "Стаж работы", "E-mail" });
                    break;
                case "btnExams":
                    currentBindingSource = examBindingSource;
                    clbSearch.Items.AddRange(new object[] { "ID слушателя", "ID дисциплины", "Оценка" });
                    clbSort.Items.AddRange(new object[] { "ID слушателя", "ID дисциплины", "Оценка" });
                    break;
                case "btnGroup":
                    currentBindingSource = groupBindingSource;
                    clbSearch.Items.AddRange(new object[] { "Группа", "Курс", "Количество слушателей" });
                    clbSort.Items.AddRange(new object[] { "Группа", "Курс", "Количество слушателей" });
                    break;
                case "btnCourses":
                    currentBindingSource = courseBindingSource;
                    clbSearch.Items.AddRange(new object[] { "Аббревиатура курса", "Полное название курса" });
                    clbSort.Items.AddRange(new object[] { "Аббревиатура курса", "Полное название курса" });
                    break;
                case "btnDiscipline":
                    currentBindingSource = disciplineBindingSource;
                    clbSearch.Items.AddRange(new object[] { "ID дисциплины", "Группа", "Количество часов", "Курс" });
                    clbSort.Items.AddRange(new object[] { "ID дисциплины", "Группа", "Количество часов", "Курс" });
                    break;
                case "btnPayment":
                    currentBindingSource = paymentBindingSource;
                    clbSearch.Items.AddRange(new object[] { "ID слушателя", "ID дисциплины", "Дата", "Сумма" });
                    clbSort.Items.AddRange(new object[] { "ID слушателя", "ID дисциплины", "Дата", "Сумма" });
                    break;
                case "btnTimeSheet":
                    currentBindingSource = timeSheetBindingSource;
                    clbSearch.Items.AddRange(new object[] { "ID нагрузки", "ID дисциплины", "ID преподавателя", "Вид занятия", "Количество часов", "Оплата" });
                    clbSort.Items.AddRange(new object[] { "ID нагрузки", "ID дисциплины", "ID преподавателя", "Вид занятия", "Количество часов", "Оплата" });
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
                case "Курс":
                case "Аббревиатура курса":
                    forSort = "CourseAbbr";
                    break;
                case "Количество слушателей":
                    forSort = "NumberOfTrainees";
                    break;
                case "Полное название курса":
                    forSort = "CourseFulName";
                    break;
                case "Количество часов":
                case "Часы":
                    forSort = "NumberOfHours";
                    break;
                case "Сумма":
                    forSort = "Summa";
                    break;
                case "Вид занятия":
                    forSort = "TypeOfTraining";
                    break;
                case "Оплата":
                    forSort = "Payment";
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
                case "Курс":
                    forFilter = "CourseAbbr";
                    colnum = 3;
                    break;
                case "Аббревиатура курса":
                    forFilter = "CourseAbbr";
                    colnum = 0;
                    break;
                case "Полное название курса":
                    forFilter = "CourseFulName";
                    colnum = 1;
                    break;
                case "Количество слушателей":
                    forFilter = "NumberOfTrainees";
                    colnum = 2;
                    break;
                case "Количество часов":
                    forFilter = "NumberOfHours";
                    colnum = 2;//disc
                    break;
                case "Часы":
                    forFilter = "NumberOfHours";
                    colnum = 4;//timesh
                    break;
                case "Сумма":
                    forFilter = "Summa";
                    colnum = 3;
                    break;
                case "Вид занятия":
                    forFilter = "TypeOfTraining";
                    colnum = 3;
                    break;
                case "Оплата":
                    forFilter = "Payment";
                    colnum = 5;
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main.firstNeedOpen = true;
            Close();
        }
        public void UpdateDb()
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

        public void FillDb()
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
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Goldenrod;
                    btnNext.Visible = true;
                }
            }
        }

        private void btnStopSearch_Click(object sender, EventArgs e)
        {
            btnNext.Visible = false;
            dataGridView1.ClearSelection();
            txtSearch.Clear();
            forSearch = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnNext.Visible = false;
            UpdateDb();
            (new Edit(owner)).ShowDialog();
            coursesDataSet.AcceptChanges();
            FillDb();
            this.Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnNext.Visible = false;
            object[] args = null;
            UpdateDb();
            switch (owner)
            {
                case "btnTrainees":
                    var st = new CoursesDataSet.TraineesDataTable();
                    traineesTableAdapter.FillBy(st, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    args = st.Rows[0].ItemArray;
                    break;
                case "btnLectures":
                    var st1 = new CoursesDataSet.LecturerDataTable();
                    lecturerTableAdapter.FillBy(st1, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    args = st1.Rows[0].ItemArray;
                    break;
                case "btnGroup":
                    var st2 = new CoursesDataSet.GroupDataTable();
                    groupTableAdapter.FillBy(st2, dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    args = st2.Rows[0].ItemArray;
                    break;
                case "btnCourses":
                    var st3 = new CoursesDataSet.CourseDataTable();
                    courseTableAdapter.FillBy(st3, dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    args = st3.Rows[0].ItemArray;
                    break;
                case "btnExams":
                    var st4 = new CoursesDataSet.ExamDataTable();
                    examTableAdapter.FillBy(st4, dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value), Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value));
                    args = st4.Rows[0].ItemArray;
                    break;
                case "btnDiscipline":
                    var st5 = new CoursesDataSet.DisciplineDataTable();
                    disciplineTableAdapter.FillBy(st5, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    args = st5.Rows[0].ItemArray;
                    break;
                case "btnPayment":
                    var st6 = new CoursesDataSet.PaymentDataTable();
                    paymentTableAdapter.FillBy(st6, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value));
                    args = st6.Rows[0].ItemArray;
                    break;
                case "btnTimeSheet":
                    var st7 = new CoursesDataSet.TimeSheetDataTable();
                    timeSheetTableAdapter.FillBy(st7, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    args = st7.Rows[0].ItemArray;
                    break;
            }
            (new Edit(owner, args)).ShowDialog();
            coursesDataSet.AcceptChanges();
            FillDb();
            this.Refresh();
        }

        private void bthDel_Click(object sender, EventArgs e)
        {
            btnNext.Visible = false;
            switch (owner)
            {
                case "btnTrainees":
                    traineesTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    break;
                case "btnLectures":
                    lecturerTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    break;
                case "btnGroup":
                    groupTableAdapter.DeleteQuery(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    break;
                case "btnCourses":
                    courseTableAdapter.DeleteQuery(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                    break;
                case "btnExams":
                    examTableAdapter.DeleteQuery(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value), Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value));
                    break;
                case "btnDiscipline":
                    disciplineTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    break;
                case "btnPayment":
                    paymentTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value), Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value));
                    break;
                case "btnTimeSheet":
                    timeSheetTableAdapter.DeleteQuery(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                    break;
            }
            coursesDataSet.AcceptChanges();
            FillDb();
            this.Refresh();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bool enter = true;
            int i = 0;
            if (dataGridView1.SelectedRows.Count != 0)
                i = dataGridView1.SelectedRows[0].Cells[0].RowIndex;
            else
            {
                dataGridView1.Rows[0].Selected = true;
                return;
            }
            if (i == dataGridView1.Rows.Count - 1) {i = 0;
                enter = false;
            }
            for (; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].DefaultCellStyle.BackColor == Color.Goldenrod)
                {
                    if (enter)
                    {
                        enter = false; continue;
                    }
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[i].Selected = true;
                    break;
                }
            }
        }

    }
}
