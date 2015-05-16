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
            this.txtDo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDo
            // 
            this.txtDo.Location = new System.Drawing.Point(258, 135);
            this.txtDo.Name = "txtDo";
            this.txtDo.Size = new System.Drawing.Size(75, 23);
            this.txtDo.TabIndex = 1;
            this.txtDo.Text = "Выполнить";
            this.txtDo.UseVisualStyleBackColor = true;
            this.txtDo.Click += new System.EventHandler(this.txtDo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(339, 135);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(662, 141);
            this.dataGridView1.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(35, 326);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // txtInput
            // 
            this.txtInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtInput.Location = new System.Drawing.Point(58, 12);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(662, 59);
            this.txtInput.TabIndex = 4;
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 95);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(557, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // Querry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 326);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Querry";
            this.Text = "Querry";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button txtDo;
        private Button btnClear;
        private DataGridView dataGridView1;
        private Splitter splitter1;
        private TextBox txtInput;
        private ComboBox comboBox1;
    }
}