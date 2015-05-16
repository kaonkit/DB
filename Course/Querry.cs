using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Course
{
    public partial class Querry : Form
    {
        public Querry()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            autoComplete();
        }

        private void autoComplete(string s = null)
        {

            //AddRange(new string[]{"SELECT","SELECcsacascascT","UPDATE","DELETE"});
            comboBox1.AutoCompleteCustomSource.AddRange(new[] { "SELECT", "UPDATE", "DELETE" });
        }

        private void txtDo_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(Main.Connection))
                {
                    sqlCon.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(txtInput.Text, sqlCon);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "SELECT";
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.Space))
            {
                ListBox tip = new ListBox
                {
                    Location =
                        new Point(txtInput.Left + txtInput.TextLength * 2, txtInput.Right + txtInput.SelectionStart)
                };
                tip.Items.AddRange(new object[] { "select", "update" });
                Controls.Add(tip);
            }
            Keys keysmod2 = ModifierKeys;

            if (keysmod2 == Keys.Shift)
            {

                if (e.KeyCode == Keys.X)
                {
                    ListBox tip = new ListBox
                    {
                        Location =
                            new Point(5,5)
                    };
                    tip.Items.AddRange(new object[] { "select", "update" });
                    Controls.Add(tip);
                }

            }
        }
    }

}

