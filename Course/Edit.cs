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
                case "btnTrainees":
                    ForTrainees(args);
                    break;
                case "btnLectures":
                    ForLectures(args);
                    break;
                case "btnExams":
                    ForExams(args);
                    break;
                case "btnGroup":
                    ForGroups(args);
                    break;
                case "btnCourses":
                    ForCourses(args);
                    break;
                case "btnDiscipline":
                    ForDisciplines(args);
                    break;
                case "btnPayment":
                    ForPayment(args);
                    break;
                case "btnTimeSheet":
                    ForTimeSheets(args);
                    break;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("\tВы уверены?", "\tУдаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
                                case "btnTrainees":
                                    traineesTableAdapter.Insert(
                                        Controls[2].Text,
                                        Controls[3].Text,
                                        ((DateTimePicker)Controls[4]).Value,
                                        Controls[5].Text,
                                        Controls[6].Text
                                        );
                                    break;
                                case "btnLectures":
                                    lecturerTableAdapter.Insert(
                                        Controls[2].Text,
                                        Controls[3].Text,
                                        Int32.Parse(Controls[4].Text),
                                        Controls[5].Text,
                                        Controls[6].Text
                                        );
                                    break;
                                case "btnGroup":
                                    groupTableAdapter.Insert(
                                        Controls[2].Text,
                                        Controls[3].Text,
                                        Int32.Parse(Controls[4].Text));
                                    break;
                                case "btnCourses":
                                    courseTableAdapter.Insert(
                                        Controls[2].Text,
                                        Controls[3].Text);
                                    break;
                                case "btnExams":
                                    examTableAdapter.Insert(
                                        Int32.Parse(Controls[6].Text.Substring(4)),
                                        Int32.Parse(Controls[3].Text),
                                        ((DateTimePicker)Controls[4]).Value,
                                        Int32.Parse(Controls[5].Text));
                                    break;
                                case "btnDiscipline":
                                    disciplineTableAdapter.Insert(
                                        Controls[2].Text,
                                        Int32.Parse(Controls[3].Text),
                                        Controls[5].Text);
                                    break;
                                case "btnPayment":
                                    paymentTableAdapter.Insert(
                                        Int32.Parse(Controls[6].Text.Substring(4)),
                                        Int32.Parse(Controls[3].Text),
                                        ((DateTimePicker)Controls[4]).Value,
                                        Int32.Parse(Controls[5].Text));
                                    break;
                                case "btnTimeSheet":
                                    timeSheetTableAdapter.Insert(
                                        Int32.Parse(Controls[2].Text),
                                        Int32.Parse(Controls[7].Text.Substring(4)),
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
                                case "btnTrainees":
                                    traineesTableAdapter.UpdateQuery(
                                        Controls[2].Text,
                                        Controls[3].Text,
                                        ((DateTimePicker)Controls[4]).Value,
                                        Controls[5].Text,
                                        Controls[6].Text,
                                        Int32.Parse(id));
                                    break;
                                case "btnLectures":
                                    lecturerTableAdapter.UpdateQuery(
                                        Controls[2].Text,
                                        Controls[3].Text,
                                        Int32.Parse(Controls[4].Text),
                                        Controls[5].Text,
                                        Controls[6].Text,
                                        Int32.Parse(id));
                                    break;
                                case "btnGroup":
                                    groupTableAdapter.UpdateQuery(
                                        Controls[2].Text,
                                        Controls[3].Text,
                                        Int32.Parse(Controls[4].Text));
                                    break;
                                case "btnCourses":
                                    courseTableAdapter.UpdateQuery(
                                        Controls[2].Text,
                                        Controls[3].Text);
                                    break;
                                case "btnExams":
                                    examTableAdapter.UpdateQuery(
                                        Int32.Parse(Controls[6].Text.Substring(4)),
                                        Int32.Parse(Controls[3].Text),
                                        ((DateTimePicker)Controls[4]).Value.ToString(),
                                        Int32.Parse(Controls[5].Text));
                                    break;
                                case "btnDiscipline":
                                    disciplineTableAdapter.UpdateQuery(
                                        Controls[2].Text.Trim(),
                                        Int32.Parse(Controls[3].Text),
                                        Controls[5].Text,
                                        Int32.Parse(id));
                                    break;
                                case "btnPayment":
                                    paymentTableAdapter.UpdateQuery(
                                        Int32.Parse(Controls[6].Text.Substring(4)),
                                        Int32.Parse(Controls[3].Text),
                                        ((DateTimePicker)Controls[4]).Value.ToString(),
                                        Int32.Parse(Controls[5].Text));
                                    break;
                                case "btnTimeSheet":
                                    timeSheetTableAdapter.UpdateQuery(
                                        Int32.Parse(Controls[2].Text),
                                        Int32.Parse(Controls[7].Text.Substring(4)),
                                        Controls[4].Text,
                                        Int32.Parse(Controls[5].Text),
                                        Int32.Parse(Controls[6].Text),
                                        Int32.Parse(id));
                                    break;
                            }
                        } 
                        CourseDataSet.AcceptChanges();
                        Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }                
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            traineesTableAdapter.Fill(CourseDataSet.Trainees);
            timeSheetTableAdapter.Fill(CourseDataSet.TimeSheet);
            paymentTableAdapter.Fill(CourseDataSet.Payment);
            lecturerTableAdapter.Fill(CourseDataSet.Lecturer);
            groupTableAdapter.Fill(CourseDataSet.Group);
            examTableAdapter.Fill(CourseDataSet.Exam);
            courseTableAdapter.Fill(CourseDataSet.Course);
            disciplineTableAdapter.Fill(CourseDataSet.Discipline);
            disciplineTableAdapter.Fill(CourseDataSet.Discipline);
        }

        private void ForTrainees(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "Введите ФИО", Location = new Point(100, 33) };
            TextBox txtFIO = new TextBox
            {
                Location = new Point(lbl1.Width + 160, 30),
                Text = args == null ? "" : args[1].ToString(),
                ForeColor = !forEdit ? SystemColors.GrayText : SystemColors.WindowText,
                Size = new Size(200, 20)
            };
            txtFIO.GotFocus += delegate
            {
                if (txtFIO.Text == "Заполните поле")
                {
                    txtFIO.Text = "";
                    txtFIO.ForeColor = Color.Black;
                }
            };
            txtFIO.LostFocus += delegate
            {
                if (txtFIO.Text == "")
                {
                    txtFIO.Text = "Заполните поле";
                    txtFIO.ForeColor = Color.Red;
                }
            };

            Label lbl2 = new Label { AutoSize = true, Text = "Выберите группу", Location = new Point(100, 83) };
            ComboBox cmbGroup = new ComboBox
            {
                Text = !forEdit ? "" : args[2].ToString(),
                Location = new Point(lbl1.Width + 160, 80),
                Size = new Size(200, 20)
            };
            cmbGroup.GotFocus += delegate
            {
                cmbGroup.DataSource = groupBindingSource;
                cmbGroup.DisplayMember = "GroupNum";
                cmbGroup.FormattingEnabled = true;
                cmbGroup.ValueMember = "GroupNum";
            };
            Label lbl3 = new Label { AutoSize = true, Text = "Выберите дату рождения", Location = new Point(20, 133) };
            DateTimePicker datetimeDOB = new DateTimePicker
            {
                Location = new Point(lbl3.Width + 160, 130),
                Size = new Size(200, 20),
                Value = !forEdit ? DateTime.Now : DateTime.Parse(args[3].ToString())
            };

            Label lbl4 = new Label { AutoSize = true, Text = "Введите номер телефлона", Location = new Point(20, 183) };
            MaskedTextBox mtxtPhone = new MaskedTextBox
            {
                Location = new Point(lbl4.Width + 160, 180),
                Mask = "+38(000)0000000",
                Text = !forEdit ? "" : args[4].ToString(),
                Size = new Size(200, 20)
            };

            Label lbl5 = new Label { AutoSize = true, Text = "Введите e-mail", Location = new Point(100, 233) };
            TextBox txtEmail = new TextBox
            {
                Location = new Point(lbl5.Width + 160, 230),
                Text = !forEdit ? "" : args[5].ToString(),
                ForeColor = args == null ? SystemColors.GrayText : SystemColors.WindowText,
                Size = new Size(200, 20)
            };

            Controls.AddRange(new Control[] { txtFIO, cmbGroup, datetimeDOB, mtxtPhone, txtEmail, lbl1, lbl2, lbl3, lbl4, lbl5 });

        }

        private void ForLectures(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "Введите ФИО", Location = new Point(100, 33) };
            TextBox txtFIO = new TextBox
            {
                Location = new Point(lbl1.Width + 160, 30),
                Text = args == null ? "" : args[1].ToString(),
                ForeColor = !forEdit ? SystemColors.GrayText : SystemColors.WindowText,
                Size = new Size(200, 20)
            };
            txtFIO.GotFocus += delegate
            {
                if (txtFIO.Text == "Заполните поле")
                {
                    txtFIO.Text = "";
                    txtFIO.ForeColor = Color.Black;
                }
            };
            txtFIO.LostFocus += delegate
            {
                if (txtFIO.Text == "")
                {
                    txtFIO.Text = "Заполните поле";
                    txtFIO.ForeColor = Color.Red;
                }
            };

            Label lbl2 = new Label { AutoSize = true, Text = "Введите квалификацию", Location = new Point(70, 83) };
            TextBox txtQual = new TextBox
            {
                Location = new Point(lbl1.Width + 160, 83),
                Text = args == null ? "" : args[2].ToString(),
                ForeColor = !forEdit ? SystemColors.GrayText : SystemColors.WindowText,
                Size = new Size(200, 20)
            };
            txtQual.LostFocus += delegate
            {
                if (txtQual.Text == "")
                {
                    txtQual.Text = "Заполните поле";
                    txtQual.ForeColor = Color.Red;
                }
            };
            txtQual.GotFocus += delegate
            {
                if (txtQual.Text == "Заполните поле")
                {
                    txtQual.Text = "";
                    txtQual.ForeColor = Color.Black;
                }
            };
            Label lbl3 = new Label { AutoSize = true, Text = "Введите стаж работы", Location = new Point(100, 133) };

            NumericUpDown nudRecordOfService = new NumericUpDown
            {
                Location = new Point(lbl3.Width + 160, 130),
                Size = new Size(200, 20),
                Value = !forEdit ? 0 : Int32.Parse(args[3].ToString())
            };

            Label lbl4 = new Label { AutoSize = true, Text = "Введите номер телефлона", Location = new Point(70, 183) };

            MaskedTextBox mtxtPhone = new MaskedTextBox
            {
                Location = new Point(lbl4.Width + 160, 180),
                Mask = "+38(000)0000000",
                Text = !forEdit ? "" : args[4].ToString()
            };

            Label lbl5 = new Label { AutoSize = true, Text = "Введите e-mail", Location = new Point(100, 223) };

            TextBox txtEmail = new TextBox
            {
                Location = new Point(lbl5.Width + 160, 220),
                Text = !forEdit ? "" : args[5].ToString(),
                ForeColor = args == null ? SystemColors.GrayText : SystemColors.WindowText,
                Size = new Size(200, 20)
            };

            Controls.AddRange(new Control[] { txtFIO, txtQual, nudRecordOfService, mtxtPhone, txtEmail, lbl1, lbl2, lbl3, lbl4, lbl5 });

        }

        private void ForExams(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "Слушатель", Location = new Point(100, 33) };
            ComboBox cmbTrainee = new ComboBox
            {
                Text = !forEdit ? "" : args[0].ToString(),
                Location = new Point(lbl1.Width + 160, 30),
                Size = new Size(150, 20),
                Enabled = !forEdit
            };
            cmbTrainee.GotFocus += delegate
            {
                cmbTrainee.DataSource = traineesBindingSource;
                cmbTrainee.DisplayMember = "FIO";
                cmbTrainee.FormattingEnabled = true;
                cmbTrainee.ValueMember = "FIO";
            };
            Label lbl11 = new Label { AutoSize = true, Location = new Point(450, 33) };
            cmbTrainee.TextChanged += delegate
            {
                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(Main.Connection))
                    {
                        sqlCon.Open();
                        lbl11.Text = "ID: ";
                        lbl11.Text += (string)new SqlCommand(("SELECT Id FROM Trainees WHERE FIO LIKE N'" + cmbTrainee.Text + "';"), sqlCon).ExecuteScalar().ToString();
                    };
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(@"Error: " + ex.Message);
                }
            };
            Label lbl2 = new Label { AutoSize = true, Text = "ID дисциплины", Location = new Point(100, 103) };
            ComboBox cmbDisc = new ComboBox
            {
                Text = !forEdit ? "" : args[1].ToString(),
                Location = new Point(lbl2.Width + 160, 100),
                Size = new Size(100, 20),
                Enabled = !forEdit
            };
            cmbDisc.GotFocus += delegate
            {
                cmbDisc.DataSource = disciplineBindingSource;
                cmbDisc.DisplayMember = "Id";
                cmbDisc.FormattingEnabled = true;
                cmbDisc.ValueMember = "Id";
            };

            Label lbl3 = new Label { AutoSize = true, Text = "Выберите дату", Location = new Point(100, 173) };
            DateTimePicker date = new DateTimePicker
            {
                Location = new Point(lbl3.Width + 160, 170),
                Size = new Size(200, 20),
                Value = !forEdit ? DateTime.Now : DateTime.Parse(args[2].ToString()),
                Enabled = !forEdit
            };

            Label lbl4 = new Label { AutoSize = true, Text = "Введите оценку", Location = new Point(100, 243) };
            NumericUpDown nudMark = new NumericUpDown
            {
                Minimum = 0,
                Maximum = 5,
                Location = new Point(lbl4.Width + 160, 240),
                Text = !forEdit ? "0" : args[3].ToString()
            };

            Controls.AddRange(new Control[] { cmbTrainee, cmbDisc, date, nudMark, lbl11, lbl1, lbl2, lbl3, lbl4 });
        }

        private void ForGroups(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "Название группы", Location = new Point(100, 33) };

            TextBox txtGroup = new TextBox
            {
                Location = new Point(lbl1.Width + 160, 30),
                Text = args == null ? "Введите группу" : args[0].ToString(),
                ForeColor = !forEdit ? SystemColors.GrayText : SystemColors.WindowText,
                Size = new Size(200, 20)
            };
            txtGroup.GotFocus += delegate
            {
                if (txtGroup.Text == "Заполните поле")
                {
                    txtGroup.Text = "";
                    txtGroup.ForeColor = Color.Black;
                }
            };
            txtGroup.LostFocus += delegate
            {
                if (txtGroup.Text == "")
                {
                    txtGroup.Text = "Заполните поле";
                    txtGroup.ForeColor = Color.Red;
                }
            };

            Label lbl2 = new Label { AutoSize = true, Text = "Выберите курс", Location = new Point(100, 113) };

            ComboBox cmbCourse = new ComboBox
            {
                Text = !forEdit ? "Выберите курс" : args[1].ToString().Trim(),
                Location = new Point(lbl1.Width + 160, 100),
            };
            cmbCourse.GotFocus += delegate
            {
                cmbCourse.DataSource = courseBindingSource;
                cmbCourse.DisplayMember = "CourseAbbr";
                cmbCourse.FormattingEnabled = true;
                cmbCourse.ValueMember = "CourseAbbr";
            };
            Label lbl3 = new Label { AutoSize = true, Text = "Выберите количество\n слушателей", Location = new Point(20, 183) };

            NumericUpDown nudNumberOfTr = new NumericUpDown
            {
                Location = new Point(lbl3.Width + 160, 180),
                Text = !forEdit ? "0" : args[2].ToString()
            };

            Controls.AddRange(new Control[] { txtGroup, cmbCourse, nudNumberOfTr, lbl1, lbl2, lbl3 });
        }

        private void ForCourses(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "Введите аббревиатуру курса", Location = new Point(50, 83) };

            TextBox txtCourse = new TextBox
            {
                Location = new Point(lbl1.Width + 160, 80),
                Text = args == null ? "" : args[0].ToString(),
                ForeColor = !forEdit ? SystemColors.GrayText : SystemColors.WindowText,
                Size = new Size(200, 20)
            };
            txtCourse.GotFocus += delegate
            {
                if (txtCourse.Text == "Заполните поле")
                {
                    txtCourse.Text = "";
                    txtCourse.ForeColor = Color.Black;
                }
            };
            txtCourse.LostFocus += delegate
            {
                if (txtCourse.Text == "")
                {
                    txtCourse.Text = "Заполните поле";
                    txtCourse.ForeColor = Color.Red;
                }
            };

            Label lbl2 = new Label { AutoSize = true, Text = "Введите название курса", Location = new Point(60, 163) };

            TextBox txtFull = new TextBox
            {
                Location = new Point(lbl2.Width + 160, 160),
                Text = !forEdit ? "" : args[1].ToString(),
                ForeColor = args == null ? SystemColors.GrayText : SystemColors.WindowText,
                Size = new Size(200, 20)
            };
            txtFull.GotFocus += delegate
            {
                if (txtFull.Text == "Заполните поле")
                {
                    txtFull.Text = "";
                    txtFull.ForeColor = Color.Black;
                }
            };
            txtFull.LostFocus += delegate
            {
                if (txtFull.Text == "")
                {
                    txtFull.Text = "Заполните поле";
                    txtFull.ForeColor = Color.Red;
                }
            };

            Controls.AddRange(new Control[] { txtCourse, txtFull, lbl1, lbl2 });
        }

        private void ForDisciplines(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "Выберите группу", Location = new Point(100, 33) };
            ComboBox cmbGroup = new ComboBox
            {
                Text = !forEdit ? "" : args[1].ToString(),
                Location = new Point(lbl1.Width + 160, 30)
            };
            cmbGroup.GotFocus += delegate
            {
                cmbGroup.DataSource = groupBindingSource;
                cmbGroup.DisplayMember = "GroupNum";
                cmbGroup.FormattingEnabled = true;
                cmbGroup.ValueMember = "GroupNum";
            };

            Label lbl2 = new Label { AutoSize = true, Text = "Количество часов", Location = new Point(100, 103) };
            NumericUpDown nudNumbOfHours = new NumericUpDown
            {
                Minimum = 0,
                Location = new Point(lbl2.Width + 160, 100),
                Text = !forEdit ? "0" : args[2].ToString()
            };

            Label lbl3 = new Label { AutoSize = true, Text = "Выберите курс", Location = new Point(100, 173) };
            ComboBox cmbCourse = new ComboBox
            {
                Text = !forEdit ? "" : args[3].ToString(),
                Location = new Point(lbl3.Width + 160, 170)
            };
            cmbCourse.GotFocus += delegate
            {
                cmbCourse.DataSource = courseBindingSource;
                cmbCourse.DisplayMember = "CourseAbbr";
                cmbCourse.FormattingEnabled = true;
                cmbCourse.ValueMember = "CourseAbbr";
            };

            Controls.AddRange(new Control[] { cmbGroup, nudNumbOfHours, cmbCourse, lbl1, lbl2, lbl3 });
        }

        private void ForPayment(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "Слушатель", Location = new Point(100, 33) };
            ComboBox cmbTrainee = new ComboBox
            {
                Text = !forEdit ? "" : args[0].ToString(),
                Location = new Point(lbl1.Width + 160, 30),
                Enabled = !forEdit
            };
            cmbTrainee.Click += delegate
            {
                cmbTrainee.DataSource = traineesBindingSource;
                cmbTrainee.DisplayMember = "FIO";
                cmbTrainee.FormattingEnabled = true;
                cmbTrainee.ValueMember = "FIO";
            };

            Label lbl11 = new Label { AutoSize = true, Location = new Point(400, 33) };
            cmbTrainee.TextChanged += delegate
            {
                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(Main.Connection))
                    {
                        sqlCon.Open();
                        lbl11.Text = "ID: ";
                        lbl11.Text += (string)new SqlCommand(("SELECT Id FROM Trainees WHERE FIO LIKE N'" + cmbTrainee.Text + "';"), sqlCon).ExecuteScalar().ToString();
                    };
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(@"Error: " + ex.Message);
                }
            };


            Label lbl2 = new Label { AutoSize = true, Text = "ID дисциплины", Location = new Point(100, 93) };
            ComboBox cmbDisc = new ComboBox
            {
                Text = !forEdit ? "" : args[1].ToString(),
                Location = new Point(lbl2.Width + 160, 90),
                Enabled = !forEdit
            };
            cmbDisc.GotFocus += delegate
            {
                cmbDisc.DataSource = disciplineBindingSource;
                cmbDisc.DisplayMember = "Id";
                cmbDisc.FormattingEnabled = true;
                cmbDisc.ValueMember = "Id";
            };
            cmbDisc.LostFocus += delegate
            {
                if (cmbDisc.Text == "")
                {
                    cmbDisc.Text = "Заполните поле";
                    cmbDisc.ForeColor = Color.Red;
                }
            };
            Label lbl3 = new Label { AutoSize = true, Text = "Выберите дату", Location = new Point(100, 153) };
            DateTimePicker date = new DateTimePicker
            {
                Location = new Point(lbl3.Width + 160, 150),
                Size = new Size(150, 10),
                Value = !forEdit ? DateTime.Now : DateTime.Parse(args[2].ToString())
            };

            Label lbl4 = new Label { AutoSize = true, Text = "Введите сумму", Location = new Point(100, 213) };
            NumericUpDown nudSum = new NumericUpDown
            {
                Maximum = 16000,
                Location = new Point(lbl4.Width + 160, 210),
                Text = !forEdit ? "0" : args[3].ToString()
            };

            Controls.AddRange(new Control[] { cmbTrainee, cmbDisc, date, nudSum, lbl11, lbl1, lbl2, lbl3, lbl4 });

        }

        private void ForTimeSheets(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "ID дисциплины", Location = new Point(100, 33) };
            ComboBox cmbDisc = new ComboBox
            {
                Text = !forEdit ? "" : args[1].ToString(),
                Location = new Point(lbl1.Width + 160, 30)
            };
            cmbDisc.GotFocus += delegate
            {
                cmbDisc.DataSource = disciplineBindingSource;
                cmbDisc.DisplayMember = "Id";
                cmbDisc.FormattingEnabled = true;
                cmbDisc.ValueMember = "Id";
            };

            Label lbl2 = new Label { AutoSize = true, Text = "Преподаватель", Location = new Point(100, 73) };
            ComboBox cmbLecturer = new ComboBox
            {
                Text = !forEdit ? "" : args[2].ToString(),
                Location = new Point(lbl2.Width + 160, 70)
            };
            cmbLecturer.GotFocus += delegate
            {
                cmbLecturer.DataSource = lecturerBindingSource;
                cmbLecturer.DisplayMember = "FIO";
                cmbLecturer.FormattingEnabled = true;
                cmbLecturer.ValueMember = "FIO";
            };
            Label lbl11 = new Label { AutoSize = true, Location = new Point(400, 73) };
            cmbLecturer.TextChanged += delegate
            {
                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(Main.Connection))
                    {
                        sqlCon.Open();
                        lbl11.Text = "ID: ";
                        lbl11.Text += (string)new SqlCommand(("SELECT Id FROM Lecturer WHERE FIO LIKE N'" + cmbLecturer.Text + "';"), sqlCon).ExecuteScalar().ToString();
                    };
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(@"Error: " + ex.Message);
                }
            };
            Label lbl3 = new Label { AutoSize = true, Text = "Выберите тип", Location = new Point(20, 113) };
            ComboBox cmbType = new ComboBox
            {
                Text = !forEdit ? "" : args[3].ToString(),
                Location = new Point(lbl3.Width + 160, 110),
                Items = { "лекция", "пз" }
            };

            Label lbl4 = new Label { AutoSize = true, Text = "Количество часов", Location = new Point(20, 153) };
            NumericUpDown nudNumbOfHours = new NumericUpDown
             {
                 Minimum = 0,
                 Location = new Point(lbl4.Width + 160, 150),
                 Text = !forEdit ? "0" : args[4].ToString()
             };

            Label lbl5 = new Label { AutoSize = true, Text = "Оплата", Location = new Point(100, 193) };
            NumericUpDown nudPayment = new NumericUpDown
            {
                Minimum = 0,
                Maximum = 16000,
                Location = new Point(lbl5.Width + 160, 190),
                Text = !forEdit ? "0" : args[5].ToString()
            };
            Controls.AddRange(new Control[] { cmbDisc, cmbLecturer, cmbType, nudNumbOfHours, nudPayment, lbl11, lbl1, lbl2, lbl3, lbl4, lbl5 });
        }
    }
}
