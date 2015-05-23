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
        private int changes = 0;
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
                ChangeColor(last);
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
                string TempStr = this.Text.Remove(LIOLS);
                //this.Text = TempStr + item;

                for (; changes > 0; changes--)
                {
                    this.Undo();
                    //this.ClearUndo();
                }
                this.AppendText((this.Text.Length != 0)? " ":"");
                this.AppendText(item);
                ChangeColor(item);
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
            changes++;
            if (listbox.Visible == true)
            {
                if ((keyData == Keys.Down))
                {
                    listbox.Focus();
                    listbox.SelectedIndex = 0;
                    inList = true;
                }
                else
                    this.Focus();
            }
            if (keyData == Keys.Space || keyData == Keys.Back || keyData == Keys.Delete)
            {
                if (lastIsInDictionary())
                {
                    this.ClearUndo();
                    changes = 0;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
