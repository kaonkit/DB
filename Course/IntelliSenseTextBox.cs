using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Course
{
    public partial class IntelliSenseTextBox : TextBox
    {
        List<string> dictionary;
        ListBox listbox;

        [DllImport("user32")]
        private extern static int GetCaretPos(out Point p);

        public IntelliSenseTextBox(ListBox listbox)
            : base()
        {
            this.listbox = listbox;
            listbox.KeyUp += OnKeyUp;
            listbox.Visible = false;
            this.dictionary = new List<string>();
        }

        public List<string> Dictionary
        {
            get { return this.dictionary; }
            set { this.dictionary = value; }
        }

        private static string GetLastString(string s)
        {
            string[] strArray = s.Split(' ');
            return strArray[strArray.Length - 1];
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Point cp;
            GetCaretPos(out cp);
            List<string> lstTemp = new List<string>();

            listbox.SetBounds(cp.X + this.Left, cp.Y + this.Top + 20, 150, 50);
            var TempFilteredList = dictionary.Where(n => n.StartsWith(GetLastString(this.Text).ToUpper())).Select(r => r);

            lstTemp = TempFilteredList.ToList<string>();
            if (lstTemp.Count != 0 && GetLastString(this.Text) != "")
            {
                listbox.DataSource = lstTemp;
                listbox.Visible = true;
                listbox.Focus();
            }
            else
                listbox.Visible = false;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Down)
            {
                if (listbox.Visible == true)
                {
                    listbox.Focus();
                }
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Escape)
            {
                listbox.Visible = false;
                e.Handled = true;
            }
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string StrLS = GetLastString(this.Text);
                int LIOLS = this.Text.LastIndexOf(StrLS);
                string TempStr = this.Text.Remove(LIOLS);
                this.Text = TempStr + ((ListBox)sender).SelectedItem.ToString();
                this.Select(this.Text.Length, 0);
                listbox.Hide();
            }

        }

    }
}
