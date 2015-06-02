using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Course
{
    public partial class IntelliSenseTextBox : RichTextBox
    {
        List<string> dictionary;
        ListBox listbox;
        private List<string> ISList;
        string[] commands, tables, columns;
        private int changes = 0, deletions = 0;
        [DllImport("user32")]
        private extern static int GetCaretPos(out Point p);

        public IntelliSenseTextBox(ListBox listbox)
            : base()
        {

            this.ClearUndo();
            this.listbox = listbox;
            listbox.KeyUp += OnKeyUp;
            listbox.Visible = false;

            ISList = new List<string>();
            commands = new string[] { "SELECT", "FROM", "WHERE", "COUNT", "HAVING", "GROUP BY", "MAX", "MIN", "AVG", "SUM", "ANY", "ALL" };
            tables = new string[] { "Course", "Discipline", "Exam", "Group", "Lecturer", "Payment", "TimeSheet", "Trainees" };
            columns = new string[]
            {
                "CourseAbbr", "CourseFulName", "Id", "NumberOfHours", "TraineeID", "DiscID", "Data", "Mark", "GroupNum",
                "NumberOfTrainees", "FIO", "Qualification", "RecordOfService", "Phone", "Email", "DisciplineID",
                "TraineesID", "Summa", "LectureID", "TypeOfTraining", "Payment", "DOB"
            };
            ISList.AddRange(commands);
            ISList.AddRange(tables);
            ISList.AddRange(columns);
            this.dictionary = ISList;
        }

        public List<string> Dictionary
        {
            get { return this.dictionary; }
            set { this.dictionary = value; }
        }

        private static string GetLastString(string s)
        {
            string[] strArray = s.Split(' ');
            string[] res;
            if (strArray[strArray.Length - 1].Contains(','))
            {
                res = strArray[strArray.Length - 1].Split(',');
                if (res[res.Length - 1].Contains('.'))
                {
                    string[] r = res[res.Length - 1].Split('.');
                    return r[r.Length - 1] == "" ? r[r.Length - 2] : r[r.Length - 1];
                }
                else
                    return res[res.Length - 1];
            }
            if (strArray[strArray.Length - 1].Contains('.'))
            {
                string[] r = strArray[strArray.Length - 1].Split('.');
                return r[r.Length - 1] == "" ? r[r.Length - 2] : r[r.Length - 1];
            }
            else
                return strArray[strArray.Length - 1];
            return strArray[strArray.Length - 1];
        }

        private bool lastIsInDictionary()
        {
            return ISList.Any(item => GetLastString(this.Text).Equals(item, StringComparison.OrdinalIgnoreCase));
        }

        private void ChangeColor(string s)
        {
            this.SelectionStart = this.Text.Length - s.Length;
            this.SelectionLength = s.Length;
            if (commands.Contains(s))
                this.SelectionColor = Color.DarkGreen;
            if (tables.Contains(s))
                this.SelectionColor = Color.DarkRed;
            if (columns.Contains(s))
                this.SelectionColor = Color.DarkSlateBlue;

            this.Select(this.Text.Length, 0);
        }

        private void ChangeColor()
        {
            string s = this.Text;
            string[] strArray = s.Split(',', '.', ' ');
            int LIOLS = 0;
            for (int i = 0; i < strArray.Length; i++)
            {
                

                this.SelectionStart = LIOLS;
                this.SelectionLength = strArray[i].Length;
                if (commands.Contains(strArray[i]))
                    this.SelectionColor = Color.DarkGreen;

                if (columns.Contains(strArray[i]))
                    this.SelectionColor = Color.DarkSlateBlue;
                if (tables.Contains(strArray[i]))
                    this.SelectionColor = Color.DarkRed;
                this.Select(this.Text.Length, 0);
                this.SelectionColor = Color.Black;
                LIOLS += strArray[i].Length + 1;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Point cp;
            GetCaretPos(out cp);
            List<string> lstTemp = new List<string>();
            string last = GetLastString(this.Text);
            listbox.SetBounds(cp.X + this.Left, cp.Y + this.Top + 20, 150, 50);
            var TempFilteredList = dictionary.Where(n => n.ToUpper().StartsWith(last.ToUpper())).Select(r => r);

            lstTemp = TempFilteredList.ToList<string>();
            if (lstTemp.Count != 0 && last != "")
            {
                listbox.DataSource = lstTemp;
                listbox.Visible = true;
                listbox.ClearSelected();
                ChangeColor();
                //ChangeColor(last);
            }
            else
                listbox.Visible = false;
        }

        private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string item = ((ListBox)sender).SelectedItem.ToString();

                string StrLS = GetLastString(this.Text);
                int LIOLS = this.Text.LastIndexOf(StrLS);

                this.Text = this.Text.Remove(LIOLS);
                //this.AppendText((this.Text.Length != 0) ? " " : "");
                this.AppendText(item);
                //ChangeColor();
                //ChangeColor(item);
                this.Select(this.Text.Length, 0);
                this.SelectionColor = Color.Black;
                listbox.Hide();
            }
            if (e.KeyCode == Keys.Escape)
            {
                listbox.Visible = false;
                this.Focus();
                changes = 0;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (listbox.Visible == true)
            {
                if (keyData == Keys.Down || keyData == Keys.Up)
                {
                    listbox.Focus();
                    listbox.SelectedIndex = 0;
                }
                else
                    this.Focus();
            }
            if (keyData == Keys.Space || keyData == Keys.Oemcomma || keyData == Keys.OemPeriod)
            {
                //if (lastIsInDictionary())
                //{
                this.ClearUndo();
                changes = 0;
                //}
            }
            if (keyData == Keys.Back || keyData == Keys.Delete)
            {
                //if (lastIsInDictionary())
                //{
                this.ClearUndo();
                changes -= 2;
                deletions++;
                //}
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
