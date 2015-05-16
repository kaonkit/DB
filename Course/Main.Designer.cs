using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Course.CoursesDataSetTableAdapters;

namespace Course
{
    partial class Main
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private IContainer components = null;

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
            this.components = new Container();
            this.файлToolStripMenuItem = new ToolStripMenuItem();
            this.правкаToolStripMenuItem = new ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new ToolStripMenuItem();
            this.menuStrip1 = new MenuStrip();
            this.запросToolStripMenuItem = new ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new ToolStripMenuItem();
            this.слушателиToolStripMenuItem = new ToolStripMenuItem();
            this.преподавателиToolStripMenuItem = new ToolStripMenuItem();
            this.расписаниеToolStripMenuItem = new ToolStripMenuItem();
            this.статистикиToolStripMenuItem = new ToolStripMenuItem();
            this.нагрузкаПреподавателейToolStripMenuItem = new ToolStripMenuItem();
            this.посещаемостьКурсовToolStripMenuItem = new ToolStripMenuItem();
            this.cmbInfo = new ComboBox();
            this.button1 = new Button();
            this.courseBindingSource = new BindingSource(this.components);
            this.disciplineBindingSource = new BindingSource(this.components);
            this.examBindingSource = new BindingSource(this.components);
            this.groupBindingSource = new BindingSource(this.components);
            this.traineesBindingSource = new BindingSource(this.components);
            this.timeSheetBindingSource = new BindingSource(this.components);
            this.paymentBindingSource = new BindingSource(this.components);
            this.lecturerBindingSource = new BindingSource(this.components);
            this.bindingSource1 = new BindingSource(this.components);
            this.coursesDataSet = new CoursesDataSet();
            this.courseTableAdapter = new CourseTableAdapter();
            this.disciplineTableAdapter = new DisciplineTableAdapter();
            this.examTableAdapter = new ExamTableAdapter();
            this.groupTableAdapter = new GroupTableAdapter();
            this.traineesTableAdapter = new TraineesTableAdapter();
            this.timeSheetTableAdapter = new TimeSheetTableAdapter();
            this.paymentTableAdapter = new PaymentTableAdapter();
            this.lecturerTableAdapter = new LecturerTableAdapter();
            this.coursesDataSet1 = new CoursesDataSet();
            this.menuStrip1.SuspendLayout();
            ((ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((ISupportInitialize)(this.examBindingSource)).BeginInit();
            ((ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((ISupportInitialize)(this.traineesBindingSource)).BeginInit();
            ((ISupportInitialize)(this.timeSheetBindingSource)).BeginInit();
            ((ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((ISupportInitialize)(this.coursesDataSet)).BeginInit();
            ((ISupportInitialize)(this.coursesDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new Size(59, 20);
            this.правкаToolStripMenuItem.Text = "&Правка";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new Size(154, 22);
            this.добавитьToolStripMenuItem.Text = "&Добавить";
            this.добавитьToolStripMenuItem.Click += new EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "&Редактировать";
            this.редактироватьToolStripMenuItem.Click += new EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "&Удалить";
            this.удалитьToolStripMenuItem.Click += new EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.запросToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.расписаниеToolStripMenuItem,
            this.статистикиToolStripMenuItem});
            this.menuStrip1.Location = new Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new Size(731, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // запросToolStripMenuItem
            // 
            this.запросToolStripMenuItem.Name = "запросToolStripMenuItem";
            this.запросToolStripMenuItem.Size = new Size(59, 20);
            this.запросToolStripMenuItem.Text = "&Запрос";
            this.запросToolStripMenuItem.Click += new EventHandler(this.запросToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.слушателиToolStripMenuItem,
            this.преподавателиToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new Size(79, 20);
            this.отчетыToolStripMenuItem.Text = "&Ведомости";
            // 
            // слушателиToolStripMenuItem
            // 
            this.слушателиToolStripMenuItem.Name = "слушателиToolStripMenuItem";
            this.слушателиToolStripMenuItem.Size = new Size(159, 22);
            this.слушателиToolStripMenuItem.Text = "&Слушатели";
            this.слушателиToolStripMenuItem.Click += new EventHandler(this.слушателиToolStripMenuItem_Click);
            // 
            // преподавателиToolStripMenuItem
            // 
            this.преподавателиToolStripMenuItem.Name = "преподавателиToolStripMenuItem";
            this.преподавателиToolStripMenuItem.Size = new Size(159, 22);
            this.преподавателиToolStripMenuItem.Text = "&Преподаватели";
            this.преподавателиToolStripMenuItem.Click += new EventHandler(this.преподавателиToolStripMenuItem_Click);
            // 
            // расписаниеToolStripMenuItem
            // 
            this.расписаниеToolStripMenuItem.Name = "расписаниеToolStripMenuItem";
            this.расписаниеToolStripMenuItem.Size = new Size(84, 20);
            this.расписаниеToolStripMenuItem.Text = "&Расписание";
            this.расписаниеToolStripMenuItem.Click += new EventHandler(this.расписаниеToolStripMenuItem_Click);
            // 
            // статистикиToolStripMenuItem
            // 
            this.статистикиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            this.нагрузкаПреподавателейToolStripMenuItem,
            this.посещаемостьКурсовToolStripMenuItem});
            this.статистикиToolStripMenuItem.Name = "статистикиToolStripMenuItem";
            this.статистикиToolStripMenuItem.Size = new Size(81, 20);
            this.статистикиToolStripMenuItem.Text = "&Статистики";
            // 
            // нагрузкаПреподавателейToolStripMenuItem
            // 
            this.нагрузкаПреподавателейToolStripMenuItem.Name = "нагрузкаПреподавателейToolStripMenuItem";
            this.нагрузкаПреподавателейToolStripMenuItem.Size = new Size(216, 22);
            this.нагрузкаПреподавателейToolStripMenuItem.Text = "&Нагрузка преподавателей";
            this.нагрузкаПреподавателейToolStripMenuItem.Click += new EventHandler(this.нагрузкаПреподавателейToolStripMenuItem_Click);
            // 
            // посещаемостьКурсовToolStripMenuItem
            // 
            this.посещаемостьКурсовToolStripMenuItem.Name = "посещаемостьКурсовToolStripMenuItem";
            this.посещаемостьКурсовToolStripMenuItem.Size = new Size(216, 22);
            this.посещаемостьКурсовToolStripMenuItem.Text = "&Посещаемость курсов";
            this.посещаемостьКурсовToolStripMenuItem.Click += new EventHandler(this.курсыToolStripMenuItem_Click);
            // 
            // cmbInfo
            // 
            this.cmbInfo.FormattingEnabled = true;
            this.cmbInfo.Items.AddRange(new object[] {
            "слушатели",
            "преподаватели",
            "экзамены",
            "группы",
            "курсы",
            "оплата",
            "дисциплины",
            "нагрузки"});
            this.cmbInfo.Location = new Point(454, 1);
            this.cmbInfo.Name = "cmbInfo";
            this.cmbInfo.Size = new Size(121, 21);
            this.cmbInfo.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new Point(581, 1);
            this.button1.Name = "button1";
            this.button1.Size = new Size(67, 20);
            this.button1.TabIndex = 3;
            this.button1.Text = "Просмотр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
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
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.coursesDataSet;
            this.bindingSource1.Position = 0;
            // 
            // coursesDataSet
            // 
            this.coursesDataSet.DataSetName = "CoursesDataSet";
            this.coursesDataSet.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
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
            // coursesDataSet1
            // 
            this.coursesDataSet1.DataSetName = "CoursesDataSet";
            this.coursesDataSet1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            //this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(731, 376);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbInfo);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new EventHandler(this.Main_Load);
            this.Resize += new EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((ISupportInitialize)(this.examBindingSource)).EndInit();
            ((ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((ISupportInitialize)(this.traineesBindingSource)).EndInit();
            ((ISupportInitialize)(this.timeSheetBindingSource)).EndInit();
            ((ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((ISupportInitialize)(this.bindingSource1)).EndInit();
            ((ISupportInitialize)(this.coursesDataSet)).EndInit();
            ((ISupportInitialize)(this.coursesDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem редактироватьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ComboBox cmbInfo;
        private Button button1;
        
        public MenuStrip menuStrip1;
        private ToolStripMenuItem запросToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
        private ToolStripMenuItem слушателиToolStripMenuItem;
        private ToolStripMenuItem преподавателиToolStripMenuItem;
        private BindingSource bindingSource1;
        private CoursesDataSet coursesDataSet;
        private BindingSource courseBindingSource;
        private CourseTableAdapter courseTableAdapter;
        private BindingSource disciplineBindingSource;
        private DisciplineTableAdapter disciplineTableAdapter;
        private BindingSource examBindingSource;
        private ExamTableAdapter examTableAdapter;
        private BindingSource groupBindingSource;
        private GroupTableAdapter groupTableAdapter;
        private BindingSource traineesBindingSource;
        private TraineesTableAdapter traineesTableAdapter;
        private BindingSource timeSheetBindingSource;
        private TimeSheetTableAdapter timeSheetTableAdapter;
        private BindingSource paymentBindingSource;
        private PaymentTableAdapter paymentTableAdapter;
        private BindingSource lecturerBindingSource;
        private LecturerTableAdapter lecturerTableAdapter;
        private CoursesDataSet coursesDataSet1;
        private ToolStripMenuItem расписаниеToolStripMenuItem;
        private ToolStripMenuItem статистикиToolStripMenuItem;
        private ToolStripMenuItem нагрузкаПреподавателейToolStripMenuItem;
        private ToolStripMenuItem посещаемостьКурсовToolStripMenuItem;
    }
}

