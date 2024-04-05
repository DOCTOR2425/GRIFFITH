namespace TestWinForms
{
    partial class GenerateExelReport
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
            this.GenerateReportB = new System.Windows.Forms.Button();
            this.StartDateC = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EndDateC = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllTimeRB = new System.Windows.Forms.RadioButton();
            this.LastYearRB = new System.Windows.Forms.RadioButton();
            this.CurrentMonthRB = new System.Windows.Forms.RadioButton();
            this.LastMonthRB = new System.Windows.Forms.RadioButton();
            this.EmployeeSelectCB = new System.Windows.Forms.ComboBox();
            this.EmployeeInfoL = new System.Windows.Forms.Label();
            this.EmployeeSelectChB = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateReportB
            // 
            this.GenerateReportB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateReportB.Location = new System.Drawing.Point(277, 499);
            this.GenerateReportB.Name = "GenerateReportB";
            this.GenerateReportB.Size = new System.Drawing.Size(220, 40);
            this.GenerateReportB.TabIndex = 0;
            this.GenerateReportB.Text = "Сгененрировать отчёт";
            this.GenerateReportB.UseVisualStyleBackColor = true;
            this.GenerateReportB.Click += new System.EventHandler(this.GenerateReportB_Click);
            // 
            // StartDateC
            // 
            this.StartDateC.Location = new System.Drawing.Point(18, 42);
            this.StartDateC.MaxSelectionCount = 1;
            this.StartDateC.Name = "StartDateC";
            this.StartDateC.TabIndex = 1;
            this.StartDateC.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.StartDateC_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата начала отчёта";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата конца отчёта";
            // 
            // EndDateC
            // 
            this.EndDateC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndDateC.Location = new System.Drawing.Point(280, 42);
            this.EndDateC.MaxSelectionCount = 1;
            this.EndDateC.Name = "EndDateC";
            this.EndDateC.TabIndex = 3;
            this.EndDateC.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.EndDateC_DateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AllTimeRB);
            this.groupBox1.Controls.Add(this.LastYearRB);
            this.groupBox1.Controls.Add(this.CurrentMonthRB);
            this.groupBox1.Controls.Add(this.LastMonthRB);
            this.groupBox1.Location = new System.Drawing.Point(18, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 128);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор промежутка времени";
            // 
            // AllTimeRB
            // 
            this.AllTimeRB.AutoSize = true;
            this.AllTimeRB.Location = new System.Drawing.Point(7, 100);
            this.AllTimeRB.Name = "AllTimeRB";
            this.AllTimeRB.Size = new System.Drawing.Size(114, 20);
            this.AllTimeRB.TabIndex = 3;
            this.AllTimeRB.TabStop = true;
            this.AllTimeRB.Text = "За всё время";
            this.AllTimeRB.UseVisualStyleBackColor = true;
            // 
            // LastYearRB
            // 
            this.LastYearRB.AutoSize = true;
            this.LastYearRB.Location = new System.Drawing.Point(7, 74);
            this.LastYearRB.Name = "LastYearRB";
            this.LastYearRB.Size = new System.Drawing.Size(131, 20);
            this.LastYearRB.TabIndex = 2;
            this.LastYearRB.TabStop = true;
            this.LastYearRB.Text = "За прошлый год";
            this.LastYearRB.UseVisualStyleBackColor = true;
            // 
            // CurrentMonthRB
            // 
            this.CurrentMonthRB.AutoSize = true;
            this.CurrentMonthRB.Location = new System.Drawing.Point(7, 48);
            this.CurrentMonthRB.Name = "CurrentMonthRB";
            this.CurrentMonthRB.Size = new System.Drawing.Size(120, 20);
            this.CurrentMonthRB.TabIndex = 1;
            this.CurrentMonthRB.TabStop = true;
            this.CurrentMonthRB.Text = "За этот месяц";
            this.CurrentMonthRB.UseVisualStyleBackColor = true;
            // 
            // LastMonthRB
            // 
            this.LastMonthRB.AutoSize = true;
            this.LastMonthRB.Location = new System.Drawing.Point(7, 21);
            this.LastMonthRB.Name = "LastMonthRB";
            this.LastMonthRB.Size = new System.Drawing.Size(148, 20);
            this.LastMonthRB.TabIndex = 0;
            this.LastMonthRB.TabStop = true;
            this.LastMonthRB.Text = "За прошлый месяц";
            this.LastMonthRB.UseVisualStyleBackColor = true;
            // 
            // EmployeeSelectCB
            // 
            this.EmployeeSelectCB.Enabled = false;
            this.EmployeeSelectCB.FormattingEnabled = true;
            this.EmployeeSelectCB.Location = new System.Drawing.Point(18, 434);
            this.EmployeeSelectCB.Name = "EmployeeSelectCB";
            this.EmployeeSelectCB.Size = new System.Drawing.Size(479, 24);
            this.EmployeeSelectCB.TabIndex = 6;
            this.EmployeeSelectCB.SelectedValueChanged += new System.EventHandler(this.EmployeeSelectCB_SelectedValueChanged);
            // 
            // EmployeeInfoL
            // 
            this.EmployeeInfoL.AutoSize = true;
            this.EmployeeInfoL.Enabled = false;
            this.EmployeeInfoL.Location = new System.Drawing.Point(15, 465);
            this.EmployeeInfoL.Name = "EmployeeInfoL";
            this.EmployeeInfoL.Size = new System.Drawing.Size(44, 16);
            this.EmployeeInfoL.TabIndex = 7;
            this.EmployeeInfoL.Text = "label3";
            // 
            // EmployeeSelectChB
            // 
            this.EmployeeSelectChB.AutoSize = true;
            this.EmployeeSelectChB.Location = new System.Drawing.Point(18, 408);
            this.EmployeeSelectChB.Name = "EmployeeSelectChB";
            this.EmployeeSelectChB.Size = new System.Drawing.Size(254, 20);
            this.EmployeeSelectChB.TabIndex = 8;
            this.EmployeeSelectChB.Text = "Сделать отчёт об одном рабонике";
            this.EmployeeSelectChB.UseVisualStyleBackColor = true;
            this.EmployeeSelectChB.CheckedChanged += new System.EventHandler(this.EmployeeSelectChB_CheckedChanged);
            // 
            // GenerateExelReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(520, 558);
            this.Controls.Add(this.EmployeeSelectChB);
            this.Controls.Add(this.EmployeeInfoL);
            this.Controls.Add(this.EmployeeSelectCB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EndDateC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartDateC);
            this.Controls.Add(this.GenerateReportB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateExelReport";
            this.ShowInTaskbar = false;
            this.Text = "Выбор время для отчёта";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateReportB;
        private System.Windows.Forms.MonthCalendar StartDateC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar EndDateC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton LastYearRB;
        private System.Windows.Forms.RadioButton CurrentMonthRB;
        private System.Windows.Forms.RadioButton LastMonthRB;
        private System.Windows.Forms.ComboBox EmployeeSelectCB;
        private System.Windows.Forms.Label EmployeeInfoL;
        private System.Windows.Forms.CheckBox EmployeeSelectChB;
        private System.Windows.Forms.RadioButton AllTimeRB;
    }
}