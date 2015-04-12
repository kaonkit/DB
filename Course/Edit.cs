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

        public Edit()
        {
            InitializeComponent();
            forTrainees();
        }

        public Edit(int id, string name, string gender, string address, string group, string pass, int benCode,
            int rNum, DateTime colDate)
            : this()
        {
            forEdit = true;
            /*
            this.id = id;
            txtFIO.Text = name;
            dtpColDate.Value = colDate;
            cmbGender.SelectedIndex = gender.ToUpper() == "женский" ? 1 : 0;
            txtAddress.Text = address;
            txtGroup.Text = group;
            txtPass.Text = pass;
            cmbRoom.SelectedValue = rNum;*/
        }

        private void forTrainees()
        {
            TextBox txtFIO = new TextBox();
            txtFIO.Location = new Point(this.ClientSize.Width / 2 - txtFIO.ClientSize.Width / 2, 30);
            ComboBox cmbGroup = new ComboBox();
            cmbGroup.Location = new Point(this.ClientSize.Width / 2 - cmbGroup.ClientSize.Width / 2, 70);
            cmbGroup.DataSource = groupBindingSource;
            cmbGroup.ValueMember = "GroupNum";
            cmbGroup.DisplayMember = cmbGroup.ValueMember;
            //cmbGroup.BindingContext = this.BindingContext;

            DateTimePicker datetimeDOB = new DateTimePicker();
            datetimeDOB.Location = new Point(this.ClientSize.Width / 2 - datetimeDOB.ClientSize.Width / 2, 110);
            MaskedTextBox mtxtPhone = new MaskedTextBox();
            mtxtPhone.Location = new Point(this.ClientSize.Width / 2 - mtxtPhone.ClientSize.Width / 2, 150);
            mtxtPhone.Mask = "+38 (000) 000 0000";
            TextBox txtEmail = new TextBox();
            txtEmail.Location = new Point(this.ClientSize.Width / 2 - txtEmail.ClientSize.Width / 2, 190);

            this.Controls.AddRange(new Control[] { txtFIO, cmbGroup, datetimeDOB, mtxtPhone, txtEmail });

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           try
            {
                traineesTableAdapter.Insert(Controls[2].Text,
                    Controls[3].Text,
                    ((DateTimePicker)Controls[4]).Value,
                    Controls[5].Text,
                    Controls[6].Text
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
            Close();
        }
    }
}
