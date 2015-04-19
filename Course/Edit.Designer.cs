namespace Course
{
    partial class Edit
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coursesDataSet = new Course.CoursesDataSet();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplineTableAdapter = new Course.CoursesDataSetTableAdapters.DisciplineTableAdapter();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Course.CoursesDataSetTableAdapters.CourseTableAdapter();
            this.examBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examTableAdapter = new Course.CoursesDataSetTableAdapters.ExamTableAdapter();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupTableAdapter = new Course.CoursesDataSetTableAdapters.GroupTableAdapter();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturerTableAdapter = new Course.CoursesDataSetTableAdapters.LecturerTableAdapter();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Course.CoursesDataSetTableAdapters.PaymentTableAdapter();
            this.specialityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeSheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeSheetTableAdapter = new Course.CoursesDataSetTableAdapters.TimeSheetTableAdapter();
            this.traineesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traineesTableAdapter = new Course.CoursesDataSetTableAdapters.TraineesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(73, 293);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(304, 293);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataMember = "Discipline";
            this.disciplineBindingSource.DataSource = this.bindingSource1;
            // 
            // disciplineTableAdapter
            // 
            this.disciplineTableAdapter.ClearBeforeFill = true;
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.bindingSource1;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
            // 
            // examBindingSource
            // 
            this.examBindingSource.DataMember = "Exam";
            this.examBindingSource.DataSource = this.bindingSource1;
            // 
            // examTableAdapter
            // 
            this.examTableAdapter.ClearBeforeFill = true;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataMember = "Group";
            this.groupBindingSource.DataSource = this.bindingSource1;
            // 
            // groupTableAdapter
            // 
            this.groupTableAdapter.ClearBeforeFill = true;
            // 
            // lecturerBindingSource
            // 
            this.lecturerBindingSource.DataMember = "Lecturer";
            this.lecturerBindingSource.DataSource = this.bindingSource1;
            // 
            // lecturerTableAdapter
            // 
            this.lecturerTableAdapter.ClearBeforeFill = true;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.bindingSource1;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // timeSheetBindingSource
            // 
            this.timeSheetBindingSource.DataMember = "TimeSheet";
            this.timeSheetBindingSource.DataSource = this.bindingSource1;
            // 
            // timeSheetTableAdapter
            // 
            this.timeSheetTableAdapter.ClearBeforeFill = true;
            // 
            // traineesBindingSource
            // 
            this.traineesBindingSource.DataMember = "Trainees";
            this.traineesBindingSource.DataSource = this.bindingSource1;
            // 
            // traineesTableAdapter
            // 
            this.traineesTableAdapter.ClearBeforeFill = true;
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 333);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Name = "Edit";
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CoursesDataSet coursesDataSet;
        private System.Windows.Forms.BindingSource disciplineBindingSource;
        private CoursesDataSetTableAdapters.DisciplineTableAdapter disciplineTableAdapter;
        private System.Windows.Forms.BindingSource courseBindingSource;
        private CoursesDataSetTableAdapters.CourseTableAdapter courseTableAdapter;
        private System.Windows.Forms.BindingSource examBindingSource;
        private CoursesDataSetTableAdapters.ExamTableAdapter examTableAdapter;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private CoursesDataSetTableAdapters.GroupTableAdapter groupTableAdapter;
        private System.Windows.Forms.BindingSource lecturerBindingSource;
        private CoursesDataSetTableAdapters.LecturerTableAdapter lecturerTableAdapter;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private CoursesDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private System.Windows.Forms.BindingSource specialityBindingSource;
        private System.Windows.Forms.BindingSource timeSheetBindingSource;
        private CoursesDataSetTableAdapters.TimeSheetTableAdapter timeSheetTableAdapter;
        private System.Windows.Forms.BindingSource traineesBindingSource;
        private CoursesDataSetTableAdapters.TraineesTableAdapter traineesTableAdapter;
    }
}