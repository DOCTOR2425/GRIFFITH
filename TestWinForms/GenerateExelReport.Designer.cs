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
            this.LastYearRB = new System.Windows.Forms.RadioButton();
            this.CurrentMonthRB = new System.Windows.Forms.RadioButton();
            this.LastMonthRB = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GenerateReportB
            // 
            this.GenerateReportB.Location = new System.Drawing.Point(274, 315);
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
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата конца отчёта";
            // 
            // EndDateC
            // 
            this.EndDateC.Location = new System.Drawing.Point(274, 42);
            this.EndDateC.MaxSelectionCount = 1;
            this.EndDateC.Name = "EndDateC";
            this.EndDateC.TabIndex = 3;
            this.EndDateC.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.EndDateC_DateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LastYearRB);
            this.groupBox1.Controls.Add(this.CurrentMonthRB);
            this.groupBox1.Controls.Add(this.LastMonthRB);
            this.groupBox1.Location = new System.Drawing.Point(18, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор промежутка времени";
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
            // GenerateExelReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(520, 377);
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
    }
}