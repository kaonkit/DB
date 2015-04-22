namespace Course
{
    partial class Information
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traineesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeSheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.clbSort = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clbFilter = new System.Windows.Forms.CheckedListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coursesDataSet = new Course.CoursesDataSet();
            this.courseTableAdapter = new Course.CoursesDataSetTableAdapters.CourseTableAdapter();
            this.disciplineTableAdapter = new Course.CoursesDataSetTableAdapters.DisciplineTableAdapter();
            this.examTableAdapter = new Course.CoursesDataSetTableAdapters.ExamTableAdapter();
            this.groupTableAdapter = new Course.CoursesDataSetTableAdapters.GroupTableAdapter();
            this.traineesTableAdapter = new Course.CoursesDataSetTableAdapters.TraineesTableAdapter();
            this.timeSheetTableAdapter = new Course.CoursesDataSetTableAdapters.TimeSheetTableAdapter();
            this.paymentTableAdapter = new Course.CoursesDataSetTableAdapters.PaymentTableAdapter();
            this.lecturerTableAdapter = new Course.CoursesDataSetTableAdapters.LecturerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(657, 165);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Course.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.bindingSource1;
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataMember = "Discipline";
            this.disciplineBindingSource.DataSource = this.bindingSource1;
            // 
            // examBindingSource
            // 
            this.examBindingSource.DataMember = "Exam";
            this.examBindingSource.DataSource = this.bindingSource1;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.bindingSource1;
            // 
            // traineesBindingSource
            // 
            this.traineesBindingSource.DataMember = "Trainees";
            this.traineesBindingSource.DataSource = this.bindingSource1;
            // 
            // timeSheetBindingSource
            // 
            this.timeSheetBindingSource.DataMember = "TimeSheet";
            this.timeSheetBindingSource.DataSource = this.bindingSource1;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.bindingSource1;
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "Lecturer";
            this.lecturerBindingSource.DataSource = this.bindingSource1;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 85);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(230, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(84, 111);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSort);
            this.groupBox1.Controls.Add(this.clbSort);
            this.groupBox1.Location = new System.Drawing.Point(478, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 140);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(79, 111);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(92, 23);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Сортировать";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // clbSort
            // 
            this.clbSort.CheckOnClick = true;
            this.clbSort.FormattingEnabled = true;
            this.clbSort.Location = new System.Drawing.Point(6, 19);
            this.clbSort.Name = "clbSort";
            this.clbSort.Size = new System.Drawing.Size(230, 79);
            this.clbSort.TabIndex = 0;
            this.clbSort.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbSort_ItemCheck);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.clbFilter);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Location = new System.Drawing.Point(230, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 140);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // clbFilter
            // 
            this.clbFilter.CheckOnClick = true;
            this.clbFilter.FormattingEnabled = true;
            this.clbFilter.Location = new System.Drawing.Point(6, 19);
            this.clbFilter.Name = "clbFilter";
            this.clbFilter.Size = new System.Drawing.Size(230, 64);
            this.clbFilter.TabIndex = 0;
            this.clbFilter.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbFilter_ItemCheck);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.coursesDataSet;
            this.bindingSource1.Position = 0;
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "CoursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // disciplineTableAdapter
            // 
            this.disciplineTableAdapter.ClearBeforeFill = true;
            // 
            // examTableAdapter
            // 
            this.examTableAdapter.ClearBeforeFill = true;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // traineesTableAdapter
            // 
            this.traineesTableAdapter.ClearBeforeFill = true;
            // 
            // timeSheetTableAdapter
            // 
            this.timeSheetTableAdapter.ClearBeforeFill = true;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // lecturerTableAdapter
            // 
            this.lecturerTableAdapter.ClearBeforeFill = true;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 326);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Information_FormClosing);
            this.Load += new System.EventHandler(this.Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

       private System.Windows.Forms.PictureBox pictureBox1;
       public System.Windows.Forms.DataGridView dataGridView1;
       private CoursesDataSet coursesDataSet;
       private System.Windows.Forms.BindingSource bindingSource1;
       private System.Windows.Forms.BindingSource courseBindingSource;
       private CoursesDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
       private System.Windows.Forms.BindingSource disciplineBindingSource;
       private CoursesDataSetTableAdapters.DisciplineTableAdapter disciplineTableAdapter;
       private System.Windows.Forms.BindingSource examBindingSource;
       private CoursesDataSetTableAdapters.ExamTableAdapter examTableAdapter;
       private System.Windows.Forms.BindingSource groupBindingSource;
       private CoursesDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
       private System.Windows.Forms.BindingSource traineesBindingSource;
       private CoursesDataSetTableAdapters.TraineesTableAdapter traineesTableAdapter;
       private System.Windows.Forms.BindingSource timeSheetBindingSource;
       private CoursesDataSetTableAdapters.TimeSheetTableAdapter timeSheetTableAdapter;
       private System.Windows.Forms.BindingSource paymentBindingSource;
       private CoursesDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
       private System.Windows.Forms.BindingSource lecturerBindingSource;
       private CoursesDataSetTableAdapters.LecturerTableAdapter lecturerTableAdapter;
       private System.Windows.Forms.TextBox txtSearch;
       private System.Windows.Forms.Button btnSearch;
       private System.Windows.Forms.GroupBox groupBox1;
       private System.Windows.Forms.GroupBox groupBox2;
       private System.Windows.Forms.CheckedListBox clbFilter;
       private System.Windows.Forms.CheckedListBox clbSort;
       private System.Windows.Forms.Button btnSort;
       }
}