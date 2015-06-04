using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Course.CourseDataSetTableAdapters;

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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.запросToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.courseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.CourseDataSet = new Course.CourseDataSet();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.traineesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeSheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseTableAdapter = new Course.CourseDataSetTableAdapters.CourseTableAdapter();
            this.disciplineTableAdapter = new Course.CourseDataSetTableAdapters.DisciplineTableAdapter();
            this.examTableAdapter = new Course.CourseDataSetTableAdapters.ExamTableAdapter();
            this.groupTableAdapter = new Course.CourseDataSetTableAdapters.GroupTableAdapter();
            this.traineesTableAdapter = new Course.CourseDataSetTableAdapters.TraineesTableAdapter();
            this.timeSheetTableAdapter = new Course.CourseDataSetTableAdapters.TimeSheetTableAdapter();
            this.paymentTableAdapter = new Course.CourseDataSetTableAdapters.PaymentTableAdapter();
            this.lecturerTableAdapter = new Course.CourseDataSetTableAdapters.LecturerTableAdapter();
            this.CourseDataSet1 = new Course.CourseDataSet();
            this.grpBoxMain = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLectures = new System.Windows.Forms.Button();
            this.btnExam = new System.Windows.Forms.Button();
            this.btmPayment = new System.Windows.Forms.Button();
            this.btnCoursesStat = new System.Windows.Forms.Button();
            this.btnLcInfo = new System.Windows.Forms.Button();
            this.btnTimeSheetStat = new System.Windows.Forms.Button();
            this.btnTrInfo = new System.Windows.Forms.Button();
            this.btnTrainees = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiscipline = new System.Windows.Forms.Button();
            this.btnExams = new System.Windows.Forms.Button();
            this.btnTimeSheet = new System.Windows.Forms.Button();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnTimeTable = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnExamStat = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataSet1)).BeginInit();
            this.grpBoxMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запросToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(765, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // запросToolStripMenuItem
            // 
            this.запросToolStripMenuItem.Name = "запросToolStripMenuItem";
            this.запросToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.запросToolStripMenuItem.Text = "&SQL редактор";
            this.запросToolStripMenuItem.Click += new System.EventHandler(this.запросToolStripMenuItem_Click);
            // 
            // courseBindingSource
            // 
            this.courseBindingSource.DataMember = "Course";
            this.courseBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.CourseDataSet;
            this.bindingSource1.Position = 0;
            // 
            // CourseDataSet
            // 
            this.CourseDataSet.DataSetName = "CourseDataSet";
            this.CourseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // CourseDataSet1
            // 
            this.CourseDataSet1.DataSetName = "CourseDataSet";
            this.CourseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grpBoxMain
            // 
            this.grpBoxMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.grpBoxMain.Controls.Add(this.pictureBox1);
            this.grpBoxMain.Controls.Add(this.label5);
            this.grpBoxMain.Controls.Add(this.label4);
            this.grpBoxMain.Controls.Add(this.btnLectures);
            this.grpBoxMain.Controls.Add(this.btnExam);
            this.grpBoxMain.Controls.Add(this.btmPayment);
            this.grpBoxMain.Controls.Add(this.btnCoursesStat);
            this.grpBoxMain.Controls.Add(this.btnLcInfo);
            this.grpBoxMain.Controls.Add(this.btnTimeSheetStat);
            this.grpBoxMain.Controls.Add(this.btnTrInfo);
            this.grpBoxMain.Controls.Add(this.btnTrainees);
            this.grpBoxMain.Controls.Add(this.label1);
            this.grpBoxMain.Controls.Add(this.btnDiscipline);
            this.grpBoxMain.Controls.Add(this.btnExams);
            this.grpBoxMain.Controls.Add(this.btnTimeSheet);
            this.grpBoxMain.Controls.Add(this.btnGroup);
            this.grpBoxMain.Controls.Add(this.btnPayment);
            this.grpBoxMain.Controls.Add(this.btnCourses);
            this.grpBoxMain.Controls.Add(this.groupBox5);
            this.grpBoxMain.Controls.Add(this.groupBox4);
            this.grpBoxMain.Controls.Add(this.groupBox3);
            this.grpBoxMain.Controls.Add(this.groupBox2);
            this.grpBoxMain.Location = new System.Drawing.Point(0, 12);
            this.grpBoxMain.Name = "grpBoxMain";
            this.grpBoxMain.Size = new System.Drawing.Size(775, 454);
            this.grpBoxMain.TabIndex = 6;
            this.grpBoxMain.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Course.Properties.Resources._482;
            this.pictureBox1.Location = new System.Drawing.Point(454, 343);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 105);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(268, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Подождите";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.CadetBlue;
            this.label4.Location = new System.Drawing.Point(589, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отчеты";
            // 
            // btnLectures
            // 
            this.btnLectures.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLectures.FlatAppearance.BorderSize = 0;
            this.btnLectures.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.btnLectures.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnLectures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLectures.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLectures.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnLectures.Location = new System.Drawing.Point(14, 197);
            this.btnLectures.Name = "btnLectures";
            this.btnLectures.Size = new System.Drawing.Size(247, 40);
            this.btnLectures.TabIndex = 5;
            this.btnLectures.Text = "Информация о преподавателях";
            this.btnLectures.UseVisualStyleBackColor = false;
            this.btnLectures.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnExam
            // 
            this.btnExam.FlatAppearance.BorderSize = 0;
            this.btnExam.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.btnExam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExam.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExam.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnExam.Location = new System.Drawing.Point(293, 278);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(212, 40);
            this.btnExam.TabIndex = 6;
            this.btnExam.Text = "Сдача экзаменов";
            this.btnExam.UseVisualStyleBackColor = true;
            this.btnExam.Click += new System.EventHandler(this.btnExam_Click);
            // 
            // btmPayment
            // 
            this.btmPayment.FlatAppearance.BorderSize = 0;
            this.btmPayment.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btmPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.btmPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmPayment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btmPayment.ForeColor = System.Drawing.Color.CadetBlue;
            this.btmPayment.Location = new System.Drawing.Point(293, 239);
            this.btmPayment.Name = "btmPayment";
            this.btmPayment.Size = new System.Drawing.Size(212, 40);
            this.btmPayment.TabIndex = 6;
            this.btmPayment.Text = "Данные об оплате";
            this.btmPayment.UseVisualStyleBackColor = true;
            this.btmPayment.Click += new System.EventHandler(this.btmPayment_Click);
            // 
            // btnCoursesStat
            // 
            this.btnCoursesStat.FlatAppearance.BorderSize = 0;
            this.btnCoursesStat.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCoursesStat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.btnCoursesStat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnCoursesStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoursesStat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCoursesStat.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnCoursesStat.Location = new System.Drawing.Point(530, 199);
            this.btnCoursesStat.Name = "btnCoursesStat";
            this.btnCoursesStat.Size = new System.Drawing.Size(217, 40);
            this.btnCoursesStat.TabIndex = 6;
            this.btnCoursesStat.Text = "Посещаемость курсов";
            this.btnCoursesStat.UseVisualStyleBackColor = true;
            this.btnCoursesStat.Click += new System.EventHandler(this.btnCoursesStat_Click);
            // 
            // btnLcInfo
            // 
            this.btnLcInfo.FlatAppearance.BorderSize = 0;
            this.btnLcInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLcInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.btnLcInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnLcInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLcInfo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLcInfo.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnLcInfo.Location = new System.Drawing.Point(293, 200);
            this.btnLcInfo.Name = "btnLcInfo";
            this.btnLcInfo.Size = new System.Drawing.Size(212, 40);
            this.btnLcInfo.TabIndex = 6;
            this.btnLcInfo.Text = "Преподаватели";
            this.btnLcInfo.UseVisualStyleBackColor = true;
            this.btnLcInfo.Click += new System.EventHandler(this.btnLcInfo_Click);
            // 
            // btnTimeSheetStat
            // 
            this.btnTimeSheetStat.FlatAppearance.BorderSize = 0;
            this.btnTimeSheetStat.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTimeSheetStat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.btnTimeSheetStat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnTimeSheetStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeSheetStat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTimeSheetStat.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnTimeSheetStat.Location = new System.Drawing.Point(530, 161);
            this.btnTimeSheetStat.Name = "btnTimeSheetStat";
            this.btnTimeSheetStat.Size = new System.Drawing.Size(217, 40);
            this.btnTimeSheetStat.TabIndex = 6;
            this.btnTimeSheetStat.Text = "Нагрузка преподавателей";
            this.btnTimeSheetStat.UseVisualStyleBackColor = true;
            this.btnTimeSheetStat.Click += new System.EventHandler(this.btnTimeSheetStat_Click);
            // 
            // btnTrInfo
            // 
            this.btnTrInfo.FlatAppearance.BorderSize = 0;
            this.btnTrInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTrInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.btnTrInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnTrInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrInfo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrInfo.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnTrInfo.Location = new System.Drawing.Point(293, 161);
            this.btnTrInfo.Name = "btnTrInfo";
            this.btnTrInfo.Size = new System.Drawing.Size(212, 40);
            this.btnTrInfo.TabIndex = 6;
            this.btnTrInfo.Text = "Слушатели";
            this.btnTrInfo.UseVisualStyleBackColor = true;
            this.btnTrInfo.Click += new System.EventHandler(this.btnTrInfo_Click);
            // 
            // btnTrainees
            // 
            this.btnTrainees.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTrainees.FlatAppearance.BorderSize = 0;
            this.btnTrainees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.btnTrainees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnTrainees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrainees.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTrainees.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnTrainees.Location = new System.Drawing.Point(14, 158);
            this.btnTrainees.Name = "btnTrainees";
            this.btnTrainees.Size = new System.Drawing.Size(247, 40);
            this.btnTrainees.TabIndex = 6;
            this.btnTrainees.Text = "Информация о слушателях";
            this.btnTrainees.UseVisualStyleBackColor = false;
            this.btnTrainees.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 84);
            this.label1.TabIndex = 4;
            this.label1.Text = "Курсы\r\nповышения квалификации";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDiscipline
            // 
            this.btnDiscipline.BackColor = System.Drawing.SystemColors.Control;
            this.btnDiscipline.FlatAppearance.BorderSize = 0;
            this.btnDiscipline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDiscipline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDiscipline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscipline.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDiscipline.Location = new System.Drawing.Point(293, 387);
            this.btnDiscipline.Name = "btnDiscipline";
            this.btnDiscipline.Size = new System.Drawing.Size(214, 40);
            this.btnDiscipline.TabIndex = 1;
            this.btnDiscipline.Text = "Информация о дисциплинах";
            this.btnDiscipline.UseVisualStyleBackColor = false;
            this.btnDiscipline.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnExams
            // 
            this.btnExams.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExams.FlatAppearance.BorderSize = 0;
            this.btnExams.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.btnExams.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnExams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExams.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExams.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnExams.Location = new System.Drawing.Point(14, 392);
            this.btnExams.Name = "btnExams";
            this.btnExams.Size = new System.Drawing.Size(247, 40);
            this.btnExams.TabIndex = 2;
            this.btnExams.Text = "Информация об экзаменах";
            this.btnExams.UseVisualStyleBackColor = false;
            this.btnExams.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTimeSheet
            // 
            this.btnTimeSheet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTimeSheet.FlatAppearance.BorderSize = 0;
            this.btnTimeSheet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.btnTimeSheet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnTimeSheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeSheet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTimeSheet.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnTimeSheet.Location = new System.Drawing.Point(14, 353);
            this.btnTimeSheet.Name = "btnTimeSheet";
            this.btnTimeSheet.Size = new System.Drawing.Size(247, 40);
            this.btnTimeSheet.TabIndex = 3;
            this.btnTimeSheet.Text = "Информация о нагрузке преподавателей";
            this.btnTimeSheet.UseVisualStyleBackColor = false;
            this.btnTimeSheet.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGroup.FlatAppearance.BorderSize = 0;
            this.btnGroup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.btnGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGroup.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnGroup.Location = new System.Drawing.Point(14, 314);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(247, 40);
            this.btnGroup.TabIndex = 0;
            this.btnGroup.Text = "Список групп";
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.btnPayment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPayment.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnPayment.Location = new System.Drawing.Point(14, 275);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(247, 40);
            this.btnPayment.TabIndex = 0;
            this.btnPayment.Text = "Информация об оплате курсов";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCourses.FlatAppearance.BorderSize = 0;
            this.btnCourses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.btnCourses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCourses.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCourses.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnCourses.Location = new System.Drawing.Point(14, 236);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(247, 40);
            this.btnCourses.TabIndex = 0;
            this.btnCourses.Text = "Список доступных курсов";
            this.btnCourses.UseVisualStyleBackColor = false;
            this.btnCourses.Click += new System.EventHandler(this.btn_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnTimeTable);
            this.groupBox5.Location = new System.Drawing.Point(558, 356);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(201, 80);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            // 
            // btnTimeTable
            // 
            this.btnTimeTable.FlatAppearance.BorderSize = 0;
            this.btnTimeTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lavender;
            this.btnTimeTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lavender;
            this.btnTimeTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeTable.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTimeTable.ForeColor = System.Drawing.Color.SandyBrown;
            this.btnTimeTable.Location = new System.Drawing.Point(40, 25);
            this.btnTimeTable.Name = "btnTimeTable";
            this.btnTimeTable.Size = new System.Drawing.Size(129, 40);
            this.btnTimeTable.TabIndex = 6;
            this.btnTimeTable.Text = "Расписание";
            this.btnTimeTable.UseVisualStyleBackColor = true;
            this.btnTimeTable.Click += new System.EventHandler(this.btnTimeTable_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Controls.Add(this.btnExamStat);
            this.groupBox4.Location = new System.Drawing.Point(524, 101);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(229, 188);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // btnExamStat
            // 
            this.btnExamStat.FlatAppearance.BorderSize = 0;
            this.btnExamStat.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnExamStat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Wheat;
            this.btnExamStat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Wheat;
            this.btnExamStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamStat.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExamStat.ForeColor = System.Drawing.Color.CadetBlue;
            this.btnExamStat.Location = new System.Drawing.Point(6, 135);
            this.btnExamStat.Name = "btnExamStat";
            this.btnExamStat.Size = new System.Drawing.Size(217, 40);
            this.btnExamStat.TabIndex = 6;
            this.btnExamStat.Text = "Успеваемость";
            this.btnExamStat.UseVisualStyleBackColor = true;
            this.btnExamStat.Click += new System.EventHandler(this.btnExamStat_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(287, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 228);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.CadetBlue;
            this.label3.Location = new System.Drawing.Point(49, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ведомости";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 340);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.CadetBlue;
            this.label2.Location = new System.Drawing.Point(45, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "Доступ\r\nк информации";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(765, 467);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpBoxMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсы повышения квалификации";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traineesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataSet1)).EndInit();
            this.grpBoxMain.ResumeLayout(false);
            this.grpBoxMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        public MenuStrip menuStrip1;
        private ToolStripMenuItem запросToolStripMenuItem;
        private BindingSource bindingSource1;
        private CourseDataSet CourseDataSet;
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
        private CourseDataSet CourseDataSet1;
        private GroupBox grpBoxMain;
        private Button btnLectures;
        private Button btnTrainees;
        private Label label1;
        private Button btnDiscipline;
        private Button btnExams;
        private Button btnTimeSheet;
        private Button btnGroup;
        private Button btnPayment;
        private Button btnCourses;
        private Button btnExam;
        private Button btmPayment;
        private Button btnLcInfo;
        private Button btnTrInfo;
        private Button btnCoursesStat;
        private Button btnTimeSheetStat;
        private Button btnTimeTable;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private Button btnExamStat;
    }
}

