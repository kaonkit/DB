using System.ComponentModel;
using System.Windows.Forms;

namespace Course
{
    partial class Querry
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Querry));
            this.txtDo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox9 = new System.Windows.Forms.ListBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.courseDataSet = new Course.CourseDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Course.CourseDataSetTableAdapters.CourseTableAdapter();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDo
            // 
            this.txtDo.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDo.Location = new System.Drawing.Point(245, 135);
            this.txtDo.Name = "txtDo";
            this.txtDo.Size = new System.Drawing.Size(88, 23);
            this.txtDo.TabIndex = 1;
            this.txtDo.Text = "Выполнить";
            this.txtDo.UseVisualStyleBackColor = true;
            this.txtDo.Click += new System.EventHandler(this.txtDo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(372, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(50, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(600, 140);
            this.dataGridView1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(258, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 88);
            this.listBox1.TabIndex = 4;
            this.listBox1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.listBox6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBox7);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.listBox9);
            this.panel1.Controls.Add(this.listBox8);
            this.panel1.Controls.Add(this.listBox5);
            this.panel1.Controls.Add(this.listBox4);
            this.panel1.Controls.Add(this.listBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Location = new System.Drawing.Point(657, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 341);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(197, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Groupe";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Payment";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(202, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "TimeSheet";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(58, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Trainees";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(50, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lecturer";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(342, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Discipline";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(156, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Exam";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(325, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Course";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(325, 217);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(110, 69);
            this.listBox2.TabIndex = 0;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.OnCheck);
            // 
            // listBox9
            // 
            this.listBox9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox9.FormattingEnabled = true;
            this.listBox9.Location = new System.Drawing.Point(58, 243);
            this.listBox9.Name = "listBox9";
            this.listBox9.Size = new System.Drawing.Size(93, 95);
            this.listBox9.TabIndex = 0;
            this.listBox9.SelectedIndexChanged += new System.EventHandler(this.OnCheck);
            // 
            // listBox8
            // 
            this.listBox8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox8.FormattingEnabled = true;
            this.listBox8.Location = new System.Drawing.Point(202, 27);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(99, 95);
            this.listBox8.TabIndex = 0;
            this.listBox8.SelectedIndexChanged += new System.EventHandler(this.OnCheck);
            // 
            // listBox6
            // 
            this.listBox6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox6.FormattingEnabled = true;
            this.listBox6.Location = new System.Drawing.Point(50, 17);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(109, 95);
            this.listBox6.TabIndex = 0;
            this.listBox6.SelectedIndexChanged += new System.EventHandler(this.OnCheck);
            // 
            // listBox7
            // 
            this.listBox7.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox7.FormattingEnabled = true;
            this.listBox7.Location = new System.Drawing.Point(3, 143);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(82, 69);
            this.listBox7.TabIndex = 0;
            this.listBox7.SelectedIndexChanged += new System.EventHandler(this.OnCheck);
            // 
            // listBox5
            // 
            this.listBox5.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(197, 272);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(104, 69);
            this.listBox5.TabIndex = 0;
            this.listBox5.SelectedIndexChanged += new System.EventHandler(this.OnCheck);
            // 
            // listBox4
            // 
            this.listBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(156, 163);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(82, 69);
            this.listBox4.TabIndex = 0;
            this.listBox4.SelectedIndexChanged += new System.EventHandler(this.OnCheck);
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(342, 89);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(105, 69);
            this.listBox3.TabIndex = 0;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.OnCheck);
            // 
            // courseDataSet
            // 
            this.courseDataSet.DataSetName = "CourseDataSet";
            this.courseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.courseDataSet;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Course.Properties.Resources._30;
            this.pictureBox9.Location = new System.Drawing.Point(369, 159);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(41, 39);
            this.pictureBox9.TabIndex = 7;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(154, 269);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 32);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Course.Properties.Resources._50l;
            this.pictureBox3.Location = new System.Drawing.Point(11, 213);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(49, 50);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(154, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 50);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::Course.Properties.Resources._50ur;
            this.pictureBox7.Location = new System.Drawing.Point(118, 180);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(46, 42);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Course.Properties.Resources._50ld1;
            this.pictureBox8.Location = new System.Drawing.Point(276, 215);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(52, 41);
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Course.Properties.Resources._27r1;
            this.pictureBox6.Location = new System.Drawing.Point(301, 80);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(41, 39);
            this.pictureBox6.TabIndex = 7;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Course.Properties.Resources._27l;
            this.pictureBox5.Location = new System.Drawing.Point(162, 39);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(49, 41);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Querry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 365);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Querry";
            this.Text = "Querry";
            this.Load += new System.EventHandler(this.Querry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button txtDo;
        private Button btnClear;
        private DataGridView dataGridView1;
        private ListBox listBox1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private ListBox listBox8;
        private ListBox listBox6;
        private ListBox listBox7;
        private ListBox listBox5;
        private ListBox listBox4;
        private ListBox listBox3;
        private ListBox listBox2;
        private CourseDataSet courseDataSet;
        private BindingSource courseBindingSource;
        private CourseDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private ListBox listBox9;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private PictureBox pictureBox8;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}