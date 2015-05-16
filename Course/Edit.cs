using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Course
{
    public partial class Edit : Form
    {
        private readonly string id;
        private readonly bool forEdit;
        private readonly string owner;

        public Edit(string s, object[] args = null)
        {
            InitializeComponent();
            owner = s;
            id = args != null ? args[0].ToString() : null;
            forEdit = args != null;
            switch (owner)
            {
                case "слушатели":
                    ForTrainees(args);
                    break;
                case "преподаватели":
                    ForLectures(args);
                    break;
                case "экзамены":
                    ForExams(args);
                    break;
                case "группы":
                    ForGroups(args);
                    break;
                case "курсы":
                    ForCourses(args);
                    break;
                case "дисциплины":
                    ForDisciplines(args);
                    break;
                case "оплата":
                    ForPayment(args);
                    break;
                case "нагрузки":
                    ForTimeSheets(args);
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(Main.Connection))
                {
                    sqlCon.Open();

                    if (!forEdit)
                    {
                        switch (owner)
                        {
                            case "слушатели":
                                traineesTableAdapter.Insert(
                                    Controls[2].Text,
                                    Controls[3].Text,
                                    ((DateTimePicker)Controls[4]).Value,
                                    Controls[5].Text,
                                    Controls[6].Text
                                    );
                                break;
                            case "преподаватели":
                                lecturerTableAdapter.Insert(
                                    Controls[2].Text,
                                    Controls[3].Text,
                                    Int32.Parse(Controls[4].Text),
                                    Controls[5].Text,
                                    Controls[6].Text
                                    );
                                break;
                            case "группы":
                                groupTableAdapter.Insert(
                                    Controls[2].Text,
                                    Controls[3].Text,
                                    Int32.Parse(Controls[4].Text));
                                break;
                            case "курсы":
                                courseTableAdapter.Insert(
                                    Controls[2].Text,
                                    Controls[3].Text);
                                break;
                            case "экзамены":
                                examTableAdapter.Insert(
                                    Int32.Parse(Controls[2].Text),
                                    Int32.Parse(Controls[3].Text),
                                    ((DateTimePicker)Controls[4]).Value,
                                    Int32.Parse(Controls[5].Text));
                                break;
                            case "дисциплины":
                                disciplineTableAdapter.Insert(
                                    Controls[2].Text,
                                    Int32.Parse(Controls[3].Text),
                                    Controls[5].Text);
                                break;
                            case "оплата":
                                paymentTableAdapter.Insert(
                                    Int32.Parse(Controls[2].Text),
                                    Int32.Parse(Controls[3].Text),
                                    ((DateTimePicker)Controls[4]).Value,
                                    Int32.Parse(Controls[5].Text));
                                break;
                            case "нагрузки":
                                timeSheetTableAdapter.Insert(
                                    Int32.Parse(Controls[2].Text),
                                    Int32.Parse(((ComboBox)Controls[3]).Text),
                                    Controls[4].Text,
                                    Int32.Parse(Controls[5].Text),
                                    Int32.Parse(Controls[6].Text));
                                break;
                        }
                    }
                    else
                    {
                        switch (owner)
                        {
                            case "слушатели":
                                traineesTableAdapter.UpdateQuery(
                                    Controls[2].Text,
                                    Controls[3].Text,
                                    ((DateTimePicker)Controls[4]).Value,
                                    Controls[5].Text,
                                    Controls[6].Text,
                                    Int32.Parse(id));
                                break;
                            case "преподаватели":
                                lecturerTableAdapter.UpdateQuery(
                                    Controls[2].Text,
                                    Controls[3].Text,
                                    Int32.Parse(Controls[4].Text),
                                    Controls[5].Text,
                                    Controls[6].Text,
                                    Int32.Parse(id));
                                break;
                            case "группы":
                                groupTableAdapter.UpdateQuery(
                                    Controls[2].Text,
                                    Controls[3].Text,
                                    Int32.Parse(Controls[4].Text));
                                break;
                            case "курсы":
                                courseTableAdapter.UpdateQuery(
                                    Controls[2].Text,
                                    Controls[3].Text);
                                break;
                            case "экзамены":
                                examTableAdapter.UpdateQuery(
                                    Int32.Parse(Controls[2].Text),
                                    Int32.Parse(Controls[3].Text),
                                    ((DateTimePicker)Controls[4]).Value.ToString(),
                                    Int32.Parse(Controls[5].Text));
                                break;
                            case "дисциплины":
                                disciplineTableAdapter.UpdateQuery(
                                    Controls[2].Text,
                                    Int32.Parse(Controls[3].Text),
                                    Controls[5].Text,
                                    Int32.Parse(id));
                                break;
                            case "оплата":
                                paymentTableAdapter.UpdateQuery(
                                    (int)new SqlCommand(("SELECT Id FROM Trainees WHERE FIO LIKE N'" + Controls[2].Text + "';"), sqlCon).ExecuteScalar(),
                                    Int32.Parse(Controls[3].Text),
                                    ((DateTimePicker)Controls[4]).Value.ToString(),
                                    Int32.Parse(Controls[5].Text));
                                break;
                            case "нагрузки":
                                timeSheetTableAdapter.UpdateQuery(
                                    Int32.Parse(Controls[2].Text),
                                    (int)new SqlCommand(("SELECT Id FROM Lecturer WHERE FIO LIKE N'" + Controls[3].Text + "';"), sqlCon).ExecuteScalar(),
                                    Controls[4].Text,
                                    Int32.Parse(Controls[5].Text),
                                    Int32.Parse(Controls[6].Text),
                                    Int32.Parse(id));
                                break;
                        }
                    }coursesDataSet.AcceptChanges();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            traineesTableAdapter.Fill(coursesDataSet.Trainees);
            timeSheetTableAdapter.Fill(coursesDataSet.TimeSheet);
            paymentTableAdapter.Fill(coursesDataSet.Payment);
            lecturerTableAdapter.Fill(coursesDataSet.Lecturer);
            groupTableAdapter.Fill(coursesDataSet.Group);
            examTableAdapter.Fill(coursesDataSet.Exam);
            courseTableAdapter.Fill(coursesDataSet.Course);
            disciplineTableAdapter.Fill(coursesDataSet.Discipline);
            disciplineTableAdapter.Fill(coursesDataSet.Discipline);
        }

        private void ForTrainees(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "Введите ФИО", Location = new Point(50, 33) };
            TextBox txtFIO = new TextBox
            {
                Location = new Point(lbl1.Width + 65, 30),
                Text = args == null ? "Введите ФИО" : args[1].ToString(),
                ForeColor = !forEdit ? SystemColors.GrayText : SystemColors.WindowText
            };
            txtFIO.GotFocus += delegate
            {
                if (txtFIO.Text == "Введите ФИО")
                    txtFIO.Text = "";
                txtFIO.ForeColor = SystemColors.WindowText;
            };
            txtFIO.LostFocus += delegate
            {
                if (txtFIO.Text == "")
                    txtFIO.Text = "Введите ФИО";
                txtFIO.ForeColor = SystemColors.GrayText;
            };

            Label lbl2 = new Label { AutoSize = true, Text = "Выберите группу", Location = new Point(50, 73) };
            ComboBox cmbGroup = new ComboBox
            {
                Text = !forEdit ? "Выберите группу" : args[2].ToString(),
                Location = new Point(lbl1.Width + 65, 70),
                DataSource = groupBindingSource,
                DisplayMember = "GroupNum",
                FormattingEnabled = true,
                ValueMember = "GroupNum"
            };

            Label lbl3 = new Label { AutoSize = true, Text = "Выберите дату рождения", Location = new Point(20, 113) };
            DateTimePicker datetimeDOB = new DateTimePicker
            {
                Location = new Point(lbl3.Width + 65, 110),
                Size = new Size(150, 10),
                Value = !forEdit ? DateTime.Now : DateTime.Parse(args[3].ToString())
            };

            Label lbl4 = new Label { AutoSize = true, Text = "Введите номер телефлона", Location = new Point(20, 153) };
            MaskedTextBox mtxtPhone = new MaskedTextBox
            {
                Location = new Point(lbl4.Width + 65, 150),
                Mask = "+38 (000) 000 0000",
                Text = !forEdit ? "" : args[4].ToString()
            };

            Label lbl5 = new Label { AutoSize = true, Text = "Введите e-mail", Location = new Point(50, 193) };
            TextBox txtEmail = new TextBox
            {
                Location = new Point(lbl5.Width + 65, 190),
                Text = !forEdit ? "Введите e-mail" : args[5].ToString(),
                ForeColor = args == null ? SystemColors.GrayText : SystemColors.WindowText
            };
            txtEmail.GotFocus += delegate
            {
                if (txtEmail.Text == "Введите e-mail")
                    txtEmail.Text = "";
                txtEmail.ForeColor = SystemColors.WindowText;
            };
            txtEmail.LostFocus += delegate
            {
                if (txtEmail.Text == "")
                    txtEmail.Text = "Введите e-mail";
                txtEmail.ForeColor = SystemColors.GrayText;
            };

            Controls.AddRange(new Control[] { txtFIO, cmbGroup, datetimeDOB, mtxtPhone, txtEmail, lbl1, lbl2, lbl3, lbl4, lbl5 });

        }

        private void ForLectures(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "Введите ФИО", Location = new Point(50, 33) };
            TextBox txtFIO = new TextBox
            {
                Location = new Point(lbl1.Width + 65, 30),
                Text = args == null ? "Введите ФИО" : args[1].ToString(),
                ForeColor = !forEdit ? SystemColors.GrayText : SystemColors.WindowText
            };
            txtFIO.GotFocus += delegate
            {
                if (txtFIO.Text == "Введите ФИО")
                    txtFIO.Text = "";
                txtFIO.ForeColor = SystemColors.WindowText;
            };
            txtFIO.LostFocus += delegate
            {
                if (txtFIO.Text == "")
                    txtFIO.Text = "Введите ФИО";
                txtFIO.ForeColor = SystemColors.GrayText;
            };

            Label lbl2 = new Label { AutoSize = true, Text = "Введите квалификацию", Location = new Point(50, 73) };
            TextBox txtQual = new TextBox
            {
                Location = new Point(lbl1.Width + 65, 73),
                Text = args == null ? "Введите квалификацию" : args[1].ToString(),
                ForeColor = !forEdit ? SystemColors.GrayText : SystemColors.WindowText
            };
            txtQual.GotFocus += delegate
            {
                if (txtQual.Text == "Введите квалификацию")
                    txtQual.Text = "";
                txtQual.ForeColor = SystemColors.WindowText;
            };
            txtQual.LostFocus += delegate
            {
                if (txtQual.Text == "")
                    txtQual.Text = "Введите квалификацию";
                txtQual.ForeColor = SystemColors.GrayText;
            };

            Label lbl3 = new Label { AutoSize = true, Text = "Введите стаж работы", Location = new Point(20, 113) };

            NumericUpDown nudRecordOfService = new NumericUpDown
            {
                Location = new Point(lbl3.Width + 65, 110),
                Size = new Size(150, 10),
                Value = !forEdit ? 0 : Int32.Parse(args[3].ToString())
            };

            Label lbl4 = new Label { AutoSize = true, Text = "Введите номер телефлона", Location = new Point(20, 153) };

            MaskedTextBox mtxtPhone = new MaskedTextBox
            {
                Location = new Point(lbl4.Width + 65, 150),
                Mask = "+38 (000) 000 0000",
                Text = !forEdit ? "" : args[4].ToString()
            };

            Label lbl5 = new Label { AutoSize = true, Text = "Введите e-mail", Location = new Point(50, 193) };

            TextBox txtEmail = new TextBox
            {
                Location = new Point(lbl5.Width + 65, 190),
                Text = !forEdit ? "Введите e-mail" : args[5].ToString(),
                ForeColor = args == null ? SystemColors.GrayText : SystemColors.WindowText
            };
            txtEmail.GotFocus += delegate
            {
                if (txtEmail.Text == "Введите e-mail")
                    txtEmail.Text = "";
                txtEmail.ForeColor = SystemColors.WindowText;
            };
            txtEmail.LostFocus += delegate
            {
                if (txtEmail.Text == "")
                    txtEmail.Text = "Введите e-mail";
                txtEmail.ForeColor = SystemColors.GrayText;
            };

            Controls.AddRange(new Control[] { txtFIO, txtQual, nudRecordOfService, mtxtPhone, txtEmail, lbl1, lbl2, lbl3, lbl4, lbl5 });

        }

        private void ForExams(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "Слушатель", Location = new Point(50, 33) };
            ComboBox cmbTrainee = new ComboBox
            {
                Text = !forEdit ? "ID Слушателя" : args[0].ToString(),
                Location = new Point(lbl1.Width + 65, 30),
                DataSource = traineesBindingSource,
                DisplayMember = "FIO",
                FormattingEnabled = true,
                ValueMember = "Id",
                Enabled = !forEdit
            };

            Label lbl2 = new Label { AutoSize = true, Text = "ID дисциплины", Location = new Point(50, 73) };
            ComboBox cmbDisc = new ComboBox
            {
                Text = !forEdit ? "ID дисциплины" : args[1].ToString(),
                Location = new Point(lbl2.Width + 65, 70),
                DataSource = traineesBindingSource,
                DisplayMember = "Id",
                FormattingEnabled = true,
                ValueMember = "Id",
                Enabled = !forEdit
            };

            Label lbl3 = new Label { AutoSize = true, Text = "Выберите дату", Location = new Point(20, 113) };
            DateTimePicker date = new DateTimePicker
            {
                Location = new Point(lbl3.Width + 65, 110),
                Size = new Size(150, 10),
                Value = !forEdit ? DateTime.Now : DateTime.Parse(args[2].ToString()),
                Enabled = !forEdit
            };

            Label lbl4 = new Label { AutoSize = true, Text = "Введите оценку", Location = new Point(20, 153) };
            NumericUpDown nudMark = new NumericUpDown
            {
                Minimum = 0,
                Maximum = 5,
                Location = new Point(lbl4.Width + 65, 150),
                Text = !forEdit ? "0" : args[3].ToString()
            };

            Controls.AddRange(new Control[] { cmbTrainee, cmbDisc, date, nudMark, lbl1, lbl2, lbl3, lbl4 });
        }

        private void ForGroups(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "Название группы", Location = new Point(50, 33) };

            TextBox txtGroup = new TextBox
            {
                Location = new Point(lbl1.Width + 65, 30),
                Text = args == null ? "Введите группу" : args[0].ToString(),
                ForeColor = !forEdit ? SystemColors.GrayText : SystemColors.WindowText
            };
            txtGroup.GotFocus += delegate
            {
                if (txtGroup.Text == "Введите группу")
                    txtGroup.Text = "";
                txtGroup.ForeColor = SystemColors.WindowText;
            };
            txtGroup.LostFocus += delegate
            {
                if (txtGroup.Text == "")
                    txtGroup.Text = "Введите группу";
                txtGroup.ForeColor = SystemColors.GrayText;
            };

            Label lbl2 = new Label { AutoSize = true, Text = "Выберите курс", Location = new Point(50, 73) };

            ComboBox cmbCourse = new ComboBox
            {
                Text = !forEdit ? "Выберите курс" : args[1].ToString(),
                Location = new Point(lbl1.Width + 65, 70),
                DataSource = courseBindingSource,
                DisplayMember = "CourseAbbr",
                FormattingEnabled = true,
                ValueMember = "CourseAbbr"
            };

            Label lbl3 = new Label { AutoSize = true, Text = "Выберите количество\n слушателей", Location = new Point(20, 113) };

            NumericUpDown nudNumberOfTr = new NumericUpDown
            {
                Location = new Point(lbl3.Width + 65, 110),
                Text = !forEdit ? "0" : args[2].ToString()

            };

            Controls.AddRange(new Control[] { txtGroup, cmbCourse, nudNumberOfTr, lbl1, lbl2, lbl3 });
        }

        private void ForCourses(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "Введите аббревиатуру курса", Location = new Point(50, 33) };

            TextBox txtCourse = new TextBox
            {
                Location = new Point(lbl1.Width + 65, 30),
                Text = args == null ? "Введите аббревиатуру курса" : args[0].ToString(),
                ForeColor = !forEdit ? SystemColors.GrayText : SystemColors.WindowText
            };
            txtCourse.GotFocus += delegate
            {
                if (txtCourse.Text == "Введите аббревиатуру курса")
                    txtCourse.Text = "";
                txtCourse.ForeColor = SystemColors.WindowText;
            };
            txtCourse.LostFocus += delegate
            {
                if (txtCourse.Text == "")
                    txtCourse.Text = "Введите аббревиатуру курса";
                txtCourse.ForeColor = SystemColors.GrayText;
            };

            Label lbl2 = new Label { AutoSize = true, Text = "Введите название курса", Location = new Point(50, 73) };

            TextBox txtFull = new TextBox
            {
                Location = new Point(lbl2.Width + 65, 70),
                Text = !forEdit ? "Введите название курса" : args[1].ToString(),
                ForeColor = args == null ? SystemColors.GrayText : SystemColors.WindowText
            };
            txtFull.GotFocus += delegate
            {
                if (txtFull.Text == "Введите название курса")
                    txtFull.Text = "";
                txtFull.ForeColor = SystemColors.WindowText;
            };
            txtFull.LostFocus += delegate
            {
                if (txtFull.Text == "")
                    txtFull.Text = "Введите название курса";
                txtFull.ForeColor = SystemColors.GrayText;
            };

            Controls.AddRange(new Control[] { txtCourse, txtFull, lbl1, lbl2 });
        }

        private void ForDisciplines(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "Выберите группу", Location = new Point(50, 33) };
            ComboBox cmbGroup = new ComboBox
            {
                Text = !forEdit ? "Выберите группу" : args[1].ToString(),
                Location = new Point(lbl1.Width + 65, 30),
                DataSource = groupBindingSource,
                DisplayMember = "GroupNum",
                FormattingEnabled = true,
                ValueMember = "GroupNum"
            };

            Label lbl2 = new Label { AutoSize = true, Text = "Количество часов", Location = new Point(50, 73) };
            NumericUpDown nudNumbOfHours = new NumericUpDown
            {
                Minimum = 0,
                Location = new Point(lbl2.Width + 65, 70),
                Text = !forEdit ? "0" : args[2].ToString()
            };

            Label lbl3 = new Label { AutoSize = true, Text = "Выберите курс", Location = new Point(20, 113) };
            ComboBox cmbCourse = new ComboBox
            {
                Text = !forEdit ? "Выберите группу" : args[3].ToString(),
                Location = new Point(lbl1.Width + 65, 30),
                DataSource = coursesDataSet,
                DisplayMember = "CourseAbbr",
                FormattingEnabled = true,
                ValueMember = "CourseAbbr"
            };

            Controls.AddRange(new Control[] { cmbGroup, cmbCourse, lbl1, lbl2, lbl3 });
        }

        private void ForPayment(object[] args = null)
        {
            string s = "";
            using (SqlConnection sqlCon = new SqlConnection(Main.Connection))
            {
                sqlCon.Open();
                s = !forEdit
                    ? "ID Слушателя" : (string)
                        new SqlCommand(("SELECT FIO FROM Trainees WHERE Id = " + args[0] + ";"), sqlCon).ExecuteScalar();
            }

            Label lbl1 = new Label { AutoSize = true, Text = "Слушатель", Location = new Point(50, 33) };
            ComboBox cmbTrainee = new ComboBox
            {
                Text = s,
                Location = new Point(lbl1.Width + 65, 30),
                DataSource = traineesBindingSource,
                DisplayMember = "FIO",
                FormattingEnabled = true,
                ValueMember = "Id",
                Enabled = !forEdit
                
            };

            Label lbl2 = new Label { AutoSize = true, Text = "ID дисциплины", Location = new Point(50, 73) };
            ComboBox cmbDisc = new ComboBox
            {
                Text = !forEdit ? "ID дисциплины" : args[1].ToString(),
                Location = new Point(lbl2.Width + 65, 70),
                DataSource = disciplineBindingSource,
                DisplayMember = "Id",
                FormattingEnabled = true,
                ValueMember = "Id",
                Enabled = !forEdit
            };

            Label lbl3 = new Label { AutoSize = true, Text = "Выберите дату", Location = new Point(20, 113) };
            DateTimePicker date = new DateTimePicker
            {
                Location = new Point(lbl3.Width + 65, 110),
                Size = new Size(150, 10),
                Value = !forEdit ? DateTime.Now : DateTime.Parse(args[2].ToString())
            };

            Label lbl4 = new Label { AutoSize = true, Text = "Введите сумму", Location = new Point(20, 153) };
            NumericUpDown nudSum = new NumericUpDown
            {
                Maximum = 10000,
                Location = new Point(lbl4.Width + 65, 150),
                Text = !forEdit ? "0" : args[3].ToString()
            };

            Controls.AddRange(new Control[] { cmbTrainee, cmbDisc, date, nudSum, lbl1, lbl2, lbl3, lbl4 });

        }

        private void ForTimeSheets(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "ID дисциплины", Location = new Point(50, 33) };
            ComboBox cmbDisc = new ComboBox
            {
                Text = !forEdit ? "ID дисциплины" : args[1].ToString(),
                Location = new Point(lbl1.Width + 65, 30),
                DataSource = disciplineBindingSource,
                DisplayMember = "Id",
                FormattingEnabled = true,
                ValueMember = "Id"
            };
            string s = "";
            using (SqlConnection sqlCon = new SqlConnection(Main.Connection))
            {
                sqlCon.Open();
                s = !forEdit ? "ID Слушателя" : (string)new SqlCommand(("SELECT FIO FROM Lecturer WHERE Id = " + args[2] + ";"), sqlCon).ExecuteScalar();
            }

            Label lbl2 = new Label { AutoSize = true, Text = "Преподаватель", Location = new Point(50, 73) };
            ComboBox cmbLecturer = new ComboBox
            {
                Text = s,
                Location = new Point(lbl2.Width + 65, 70),
                DataSource = lecturerBindingSource,
                DisplayMember = "FIO",
                FormattingEnabled = true,
                ValueMember = "Id"
            };

            Label lbl3 = new Label { AutoSize = true, Text = "Выберите тип", Location = new Point(20, 113) };
            ComboBox cmbType = new ComboBox
            {
                Text = !forEdit ? "Выберите тип" : args[3].ToString(),
                Location = new Point(lbl3.Width + 65, 110),
                Items = { "лекция", "пз" }
            };

            Label lbl4 = new Label { AutoSize = true, Text = "Количество часов", Location = new Point(20, 153) };
            NumericUpDown nudNumbOfHours = new NumericUpDown
             {
                 Minimum = 0,
                 Location = new Point(lbl4.Width + 65, 150),
                 Text = !forEdit ? "0" : args[4].ToString()
             };

            Label lbl5 = new Label { AutoSize = true, Text = "Оплата", Location = new Point(50, 193) };
            NumericUpDown nudPayment = new NumericUpDown
            {
                Minimum = 0,
                Maximum = 10000,
                Location = new Point(lbl5.Width + 65, 190),
                Text = !forEdit ? "0" : args[5].ToString()
            };
            Controls.AddRange(new Control[] { cmbDisc, cmbLecturer, cmbType, nudNumbOfHours, nudPayment, lbl1, lbl2, lbl3, lbl4, lbl5 });
        }
    }
}
