using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Course
{

    public partial class Main : Form
    {
        private Information info;
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            info = new Information(cmbInfo.Text) { MdiParent = this };
            info.Show();
            Main_Resize(this, EventArgs.Empty);
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (info != null)
            {
                info.ClientSize = new Size(this.ClientSize.Width - 10, this.ClientSize.Height - 30);
                info.Location = new Point(0, 0);
            }
        }

    }
}
