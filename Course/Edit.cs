using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Course.CoursesDataSetTableAdapters;
using System.Data.SqlClient;


namespace Course
{
    public partial class Edit : Form
    {
        private readonly int id;
        private readonly bool forEdit;
        private readonly string owner;

        public Edit(string s, object[] args = null)
        {
            InitializeComponent();
            owner = s;
            id = args != null ? Int32.Parse(args[0].ToString()) : 0;
            forEdit = args != null;
            switch (owner)
            {
                case "слушатели":
                    forTrainees(args);
                    break;
                case "преподаватели":
                    forLectures(args);
                    break;
            }
        }

        private void forTrainees(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "Введите ФИО", Location = new Point(50, 33) };

            TextBox txtFIO = new TextBox
            {
                Location = new Point(lbl1.Width + 65, 30),
                Text = args == null ? "Введите ФИО" : args[1].ToString(),
                ForeColor = !forEdit ? SystemColors.GrayText : SystemColors.WindowText
            };
            txtFIO.GotFocus += new EventHandler(delegate
                {
                    if (txtFIO.Text == "Введите ФИО")
                        txtFIO.Text = "";
                    txtFIO.ForeColor = SystemColors.WindowText;
                });
            txtFIO.LostFocus += new EventHandler(delegate
            {
                if (txtFIO.Text == "")
                    txtFIO.Text = "Введите ФИО";
                txtFIO.ForeColor = SystemColors.GrayText;
            });

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
                Value = !forEdit ? System.DateTime.Now : DateTime.Parse(args[3].ToString())
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
            txtEmail.GotFocus += new EventHandler(delegate
            {
                if (txtEmail.Text == "Введите e-mail")
                    txtEmail.Text = "";
                txtEmail.ForeColor = SystemColors.WindowText;
            });
            txtEmail.LostFocus += new EventHandler(delegate
            {
                if (txtEmail.Text == "")
                    txtEmail.Text = "Введите e-mail";
                txtEmail.ForeColor = SystemColors.GrayText;
            });

            this.Controls.AddRange(new Control[] { txtFIO, cmbGroup, datetimeDOB, mtxtPhone, txtEmail, lbl1, lbl2, lbl3, lbl4, lbl5 });

        }

        private void forLectures(object[] args = null)
        {
            Label lbl1 = new Label { AutoSize = true, Text = "Введите ФИО", Location = new Point(50, 33) };

            TextBox txtFIO = new TextBox
            {
                Location = new Point(lbl1.Width + 65, 30),
                Text = args == null ? "Введите ФИО" : args[1].ToString(),
                ForeColor = !forEdit ? SystemColors.GrayText : SystemColors.WindowText
            };
            txtFIO.GotFocus += new EventHandler(delegate
            {
                if (txtFIO.Text == "Введите ФИО")
                    txtFIO.Text = "";
                txtFIO.ForeColor = SystemColors.WindowText;
            });
            txtFIO.LostFocus += new EventHandler(delegate
            {
                if (txtFIO.Text == "")
                    txtFIO.Text = "Введите ФИО";
                txtFIO.ForeColor = SystemColors.GrayText;
            });

            Label lbl2 = new Label { AutoSize = true, Text = "Введите квалификацию", Location = new Point(50, 73) };

            TextBox txtQual = new TextBox
            {
                Location = new Point(lbl1.Width + 65, 73),
                Text = args == null ? "Введите квалификацию" : args[1].ToString(),
                ForeColor = !forEdit ? SystemColors.GrayText : SystemColors.WindowText
            };
            txtQual.GotFocus += new EventHandler(delegate
            {
                if (txtQual.Text == "Введите квалификацию")
                    txtQual.Text = "";
                txtQual.ForeColor = SystemColors.WindowText;
            });
            txtQual.LostFocus += new EventHandler(delegate
            {
                if (txtQual.Text == "")
                    txtQual.Text = "Введите квалификацию";
                txtQual.ForeColor = SystemColors.GrayText;
            });

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
            txtEmail.GotFocus += new EventHandler(delegate
            {
                if (txtEmail.Text == "Введите e-mail")
                    txtEmail.Text = "";
                txtEmail.ForeColor = SystemColors.WindowText;
            });
            txtEmail.LostFocus += new EventHandler(delegate
            {
                if (txtEmail.Text == "")
                    txtEmail.Text = "Введите e-mail";
                txtEmail.ForeColor = SystemColors.GrayText;
            });

            this.Controls.AddRange(new Control[] { txtFIO, txtQual, nudRecordOfService, mtxtPhone, txtEmail, lbl1, lbl2, lbl3, lbl4, lbl5 });

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!forEdit)
            {
                try
                {
                    switch (owner)
                    {
                        case "слушатели":
                            traineesTableAdapter.Insert(Controls[2].Text,
                                Controls[3].Text,
                                ((DateTimePicker)Controls[4]).Value,
                                Controls[5].Text,
                                Controls[6].Text
                                );
                            break;
                        case "преподаватели":
                            lecturerTableAdapter.Insert(Controls[2].Text,
                                Controls[3].Text,
                                Int32.Parse(Controls[4].Text),
                                Controls[5].Text,
                                Controls[6].Text
                                );
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    switch (owner)
                    {
                        case "слушатели":
                            traineesTableAdapter.UpdateQuery(Controls[2].Text,
                                Controls[3].Text,
                                ((DateTimePicker)Controls[4]).Value,
                                Controls[5].Text,
                                Controls[6].Text,
                                id
                                );
                            break;
                        case "преподаватели":
                            lecturerTableAdapter.UpdateQuery(Controls[2].Text,
                                Controls[3].Text,
                                Int32.Parse(Controls[4].Text),
                                Controls[5].Text,
                                Controls[6].Text,
                                id
                                );
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(@"Error: " + ex.Message);
                }
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            this.traineesTableAdapter.Fill(this.coursesDataSet.Trainees);
            this.timeSheetTableAdapter.Fill(this.coursesDataSet.TimeSheet);
            this.paymentTableAdapter.Fill(this.coursesDataSet.Payment);
            this.lecturerTableAdapter.Fill(this.coursesDataSet.Lecturer);
            this.groupTableAdapter.Fill(this.coursesDataSet.Group);
            this.examTableAdapter.Fill(this.coursesDataSet.Exam);
            this.courseTableAdapter.Fill(this.coursesDataSet.Course);
            this.disciplineTableAdapter.Fill(this.coursesDataSet.Discipline);
            this.disciplineTableAdapter.Fill(this.coursesDataSet.Discipline);
        }
    }
}
