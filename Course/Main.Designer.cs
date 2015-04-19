namespace Course
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.запросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.слушателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавателиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.курсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.результатыЭкзаменовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оплатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нагрузкаПреподавателейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbInfo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.coursesDataSet = new Course.CoursesDataSet();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Course.CoursesDataSetTableAdapters.CourseTableAdapter();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplineTableAdapter = new Course.CoursesDataSetTableAdapters.DisciplineTableAdapter();
            this.examBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examTableAdapter = new Course.CoursesDataSetTableAdapters.ExamTableAdapter();
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupTableAdapter = new Course.CoursesDataSetTableAdapters.GroupTableAdapter();
            this.traineesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traineesTableAdapter = new Course.CoursesDataSetTableAdapters.TraineesTableAdapter();
            this.timeSheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeSheetTableAdapter = new Course.CoursesDataSetTableAdapters.TimeSheetTableAdapter();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Course.CoursesDataSetTableAdapters.PaymentTableAdapter();
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturerTableAdapter = new Course.CoursesDataSetTableAdapters.LecturerTableAdapter();
            this.coursesDataSet1 = new Course.CoursesDataSet();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "&Правка";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.добавитьToolStripMenuItem.Text = "&Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "&Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "&Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.запросToolStripMenuItem,
            this.отчетыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(698, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // запросToolStripMenuItem
            // 
            this.запросToolStripMenuItem.Name = "запросToolStripMenuItem";
            this.запросToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.запросToolStripMenuItem.Text = "&Запрос";
            this.запросToolStripMenuItem.Click += new System.EventHandler(this.запросToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.слушателиToolStripMenuItem,
            this.преподавателиToolStripMenuItem,
            this.курсыToolStripMenuItem,
            this.результатыЭкзаменовToolStripMenuItem,
            this.оплатаToolStripMenuItem,
            this.нагрузкаПреподавателейToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.отчетыToolStripMenuItem.Text = "&Ведомости";
            // 
            // слушателиToolStripMenuItem
            // 
            this.слушателиToolStripMenuItem.Name = "слушателиToolStripMenuItem";
            this.слушателиToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.слушателиToolStripMenuItem.Text = "&Слушатели";
            this.слушателиToolStripMenuItem.Click += new System.EventHandler(this.слушателиToolStripMenuItem_Click);
            // 
            // преподавателиToolStripMenuItem
            // 
            this.преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            this.преподавателиToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.преподавателиToolStripMenuItem.Text = "&Преподаватели";
            // 
            // курсыToolStripMenuItem
            // 
            this.курсыToolStripMenuItem.Name = "курсыToolStripMenuItem";
            this.курсыToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.курсыToolStripMenuItem.Text = "&Курсы";
            // 
            // результатыЭкзаменовToolStripMenuItem
            // 
            this.результатыЭкзаменовToolStripMenuItem.Name = "результатыЭкзаменовToolStripMenuItem";
            this.результатыЭкзаменовToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.результатыЭкзаменовToolStripMenuItem.Text = "&Результаты экзаменов";
            // 
            // оплатаToolStripMenuItem
            // 
            this.оплатаToolStripMenuItem.Name = "оплатаToolStripMenuItem";
            this.оплатаToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.оплатаToolStripMenuItem.Text = "&Оплата";
            // 
            // нагрузкаПреподавателейToolStripMenuItem
            // 
            this.нагрузкаПреподавателейToolStripMenuItem.Name = "нагрузкаПреподавателейToolStripMenuItem";
            this.нагрузкаПреподавателейToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.нагрузкаПреподавателейToolStripMenuItem.Text = "&Нагрузка преподавателей";
            // 
            // cmbInfo
            // 
            this.cmbInfo.FormattingEnabled = true;
            this.cmbInfo.Items.AddRange(new object[] {
            "слушатели",
            "преподаватели",
            "экзамены"});
            this.cmbInfo.Location = new System.Drawing.Point(353, 0);
            this.cmbInfo.Name = "cmbInfo";
            this.cmbInfo.Size = new System.Drawing.Size(121, 21);
            this.cmbInfo.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Просмотр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.bindingSource1;
            // 
            // courseTableAdapter
            // 
            this.courseTableAdapter.ClearBeforeFill = true;
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
            // traineesBindingSource
            // 
            this.traineesBindingSource.DataMember = "Trainees";
            this.traineesBindingSource.DataSource = this.bindingSource1;
            // 
            // traineesTableAdapter
            // 
            this.traineesTableAdapter.ClearBeforeFill = true;
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
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.bindingSource1;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
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
            // coursesDataSet1
            // 
            this.coursesDataSet1.DataSetName = "CoursesDataSet";
            this.coursesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbInfo);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbInfo;
        private System.Windows.Forms.Button button1;
        
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem запросToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem слушателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem преподавателиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem курсыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem результатыЭкзаменовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оплатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нагрузкаПреподавателейToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CoursesDataSet coursesDataSet;
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
        private CoursesDataSet coursesDataSet1;
    }
}

