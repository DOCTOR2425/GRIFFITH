﻿namespace TestWinForms
{
    partial class GenerateCustomWordContract
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
            this.GenerateContract = new System.Windows.Forms.Button();
            this.ClientCB = new System.Windows.Forms.ComboBox();
            this.ServiceCB = new System.Windows.Forms.ComboBox();
            this.NotaryEmpCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DiscountCB = new System.Windows.Forms.ComboBox();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GenerateContract
            // 
            this.GenerateContract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateContract.Location = new System.Drawing.Point(418, 269);
            this.GenerateContract.MaximumSize = new System.Drawing.Size(192, 41);
            this.GenerateContract.MinimumSize = new System.Drawing.Size(192, 41);
            this.GenerateContract.Name = "GenerateContract";
            this.GenerateContract.Size = new System.Drawing.Size(192, 41);
            this.GenerateContract.TabIndex = 0;
            this.GenerateContract.Text = "Сгенерировать договор";
            this.GenerateContract.UseVisualStyleBackColor = true;
            this.GenerateContract.Click += new System.EventHandler(this.GenerateContract_Click);
            // 
            // ClientCB
            // 
            this.ClientCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ClientCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ClientCB.FormattingEnabled = true;
            this.ClientCB.Location = new System.Drawing.Point(12, 36);
            this.ClientCB.Name = "ClientCB";
            this.ClientCB.Size = new System.Drawing.Size(331, 24);
            this.ClientCB.TabIndex = 1;
            // 
            // ServiceCB
            // 
            this.ServiceCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ServiceCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ServiceCB.FormattingEnabled = true;
            this.ServiceCB.Location = new System.Drawing.Point(12, 93);
            this.ServiceCB.Name = "ServiceCB";
            this.ServiceCB.Size = new System.Drawing.Size(331, 24);
            this.ServiceCB.TabIndex = 2;
            // 
            // NotaryEmpCB
            // 
            this.NotaryEmpCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.NotaryEmpCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.NotaryEmpCB.FormattingEnabled = true;
            this.NotaryEmpCB.Location = new System.Drawing.Point(12, 155);
            this.NotaryEmpCB.Name = "NotaryEmpCB";
            this.NotaryEmpCB.Size = new System.Drawing.Size(331, 24);
            this.NotaryEmpCB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберите клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите услугу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Выберите нотариуса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Выберите скидку";
            // 
            // DiscountCB
            // 
            this.DiscountCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.DiscountCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DiscountCB.FormattingEnabled = true;
            this.DiscountCB.Location = new System.Drawing.Point(12, 219);
            this.DiscountCB.Name = "DiscountCB";
            this.DiscountCB.Size = new System.Drawing.Size(331, 24);
            this.DiscountCB.TabIndex = 7;
            // 
            // Calendar
            // 
            this.Calendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Calendar.Location = new System.Drawing.Point(389, 36);
            this.Calendar.MaxDate = new System.DateTime(2110, 12, 31, 0, 0, 0, 0);
            this.Calendar.MaxSelectionCount = 1;
            this.Calendar.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Выберите дату";
            // 
            // GenerateCustomWordContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(622, 322);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DiscountCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotaryEmpCB);
            this.Controls.Add(this.ServiceCB);
            this.Controls.Add(this.ClientCB);
            this.Controls.Add(this.GenerateContract);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GenerateCustomWordContract";
            this.Text = "Выбор данных для договора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GenerateContract;
        private System.Windows.Forms.ComboBox ClientCB;
        private System.Windows.Forms.ComboBox ServiceCB;
        private System.Windows.Forms.ComboBox NotaryEmpCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DiscountCB;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.Label label5;
    }
}