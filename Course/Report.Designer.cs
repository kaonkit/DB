using System.ComponentModel;
using System.Windows.Forms;

namespace Course
{
    partial class Report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btneExcel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clbFilter = new System.Windows.Forms.CheckedListBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 159);
            this.dataGridView1.TabIndex = 0;
            // 
            // btneExcel
            // 
            this.btneExcel.Location = new System.Drawing.Point(197, 291);
            this.btneExcel.Name = "btneExcel";
            this.btneExcel.Size = new System.Drawing.Size(108, 23);
            this.btneExcel.TabIndex = 1;
            this.btneExcel.Text = "Экспорт в Excel";
            this.btneExcel.UseVisualStyleBackColor = true;
            this.btneExcel.Click += new System.EventHandler(this.btneExcel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Course.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnFilter);
            this.groupBox3.Controls.Add(this.clbFilter);
            this.groupBox3.Location = new System.Drawing.Point(229, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(362, 108);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Фильтр";
            // 
            // clbFilter
            // 
            this.clbFilter.CheckOnClick = true;
            this.clbFilter.FormattingEnabled = true;
            this.clbFilter.Location = new System.Drawing.Point(6, 19);
            this.clbFilter.Name = "clbFilter";
            this.clbFilter.Size = new System.Drawing.Size(350, 49);
            this.clbFilter.TabIndex = 1;
            this.clbFilter.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbFilter_ItemCheck);
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(42, 79);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(113, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Отфильтровать";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(209, 78);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Сбросить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 326);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btneExcel);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public DataGridView dataGridView1;
        private Button btneExcel;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private CheckedListBox clbFilter;
        private Button btnFilter;
        private Button btnReset;

    }
}