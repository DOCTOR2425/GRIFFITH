namespace TestWinForms
{
    partial class AddClientToOrder
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ActivityTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.AddClientB = new System.Windows.Forms.Button();
            this.TelephoneTB = new System.Windows.Forms.MaskedTextBox();
            this.BirthDateTB = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Профессия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Телефон";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Имя клиента";
            // 
            // ActivityTB
            // 
            this.ActivityTB.Location = new System.Drawing.Point(12, 148);
            this.ActivityTB.Name = "ActivityTB";
            this.ActivityTB.Size = new System.Drawing.Size(305, 22);
            this.ActivityTB.TabIndex = 2;
            this.ActivityTB.Leave += new System.EventHandler(this.ActivityTB_Leave);
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(12, 36);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(305, 22);
            this.NameTB.TabIndex = 0;
            // 
            // AddClientB
            // 
            this.AddClientB.Location = new System.Drawing.Point(79, 263);
            this.AddClientB.Name = "AddClientB";
            this.AddClientB.Size = new System.Drawing.Size(167, 35);
            this.AddClientB.TabIndex = 4;
            this.AddClientB.Text = "Добавить клиента";
            this.AddClientB.UseVisualStyleBackColor = true;
            this.AddClientB.Click += new System.EventHandler(this.AddClientB_Click);
            // 
            // TelephoneTB
            // 
            this.TelephoneTB.Location = new System.Drawing.Point(12, 87);
            this.TelephoneTB.Mask = "+375 (00) 000-00-00";
            this.TelephoneTB.Name = "TelephoneTB";
            this.TelephoneTB.ResetOnPrompt = false;
            this.TelephoneTB.ResetOnSpace = false;
            this.TelephoneTB.Size = new System.Drawing.Size(305, 22);
            this.TelephoneTB.TabIndex = 1;
            this.TelephoneTB.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // BirthDateTB
            // 
            this.BirthDateTB.Location = new System.Drawing.Point(12, 207);
            this.BirthDateTB.Mask = "00.00.0000";
            this.BirthDateTB.Name = "BirthDateTB";
            this.BirthDateTB.Size = new System.Drawing.Size(305, 22);
            this.BirthDateTB.TabIndex = 28;
            this.BirthDateTB.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            // 
            // AddClientToOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(333, 315);
            this.Controls.Add(this.BirthDateTB);
            this.Controls.Add(this.TelephoneTB);
            this.Controls.Add(this.AddClientB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ActivityTB);
            this.Controls.Add(this.NameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddClientToOrder";
            this.ShowInTaskbar = false;
            this.Text = "Добавление нового клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ActivityTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button AddClientB;
        private System.Windows.Forms.MaskedTextBox TelephoneTB;
        private System.Windows.Forms.MaskedTextBox BirthDateTB;
    }
}