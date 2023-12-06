namespace TestWinForms
{
    partial class AddOrder
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TelephoneTextBox = new System.Windows.Forms.TextBox();
            this.ActivityTextBox = new System.Windows.Forms.TextBox();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.ServiceGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClientCheckBox = new System.Windows.Forms.CheckBox();
            this.ClientTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ClientGroupBox = new System.Windows.Forms.GroupBox();
            this.ServiceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DiscountGroupBox = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BirthDateTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(12, 38);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(305, 22);
            this.NameTextBox.TabIndex = 0;
            // 
            // TelephoneTextBox
            // 
            this.TelephoneTextBox.Location = new System.Drawing.Point(12, 89);
            this.TelephoneTextBox.Name = "TelephoneTextBox";
            this.TelephoneTextBox.Size = new System.Drawing.Size(305, 22);
            this.TelephoneTextBox.TabIndex = 1;
            // 
            // ActivityTextBox
            // 
            this.ActivityTextBox.Location = new System.Drawing.Point(12, 150);
            this.ActivityTextBox.Name = "ActivityTextBox";
            this.ActivityTextBox.Size = new System.Drawing.Size(305, 22);
            this.ActivityTextBox.TabIndex = 2;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrderButton.Location = new System.Drawing.Point(665, 639);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(277, 57);
            this.AddOrderButton.TabIndex = 9;
            this.AddOrderButton.Text = "Добавить клиента";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // ServiceGroupBox
            // 
            this.ServiceGroupBox.AutoSize = true;
            this.ServiceGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ServiceGroupBox.Name = "ServiceGroupBox";
            this.ServiceGroupBox.Size = new System.Drawing.Size(246, 270);
            this.ServiceGroupBox.TabIndex = 4;
            this.ServiceGroupBox.TabStop = false;
            this.ServiceGroupBox.Text = "Услуги";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ServiceGroupBox);
            this.panel1.Location = new System.Drawing.Point(662, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 289);
            this.panel1.TabIndex = 5;
            // 
            // ClientCheckBox
            // 
            this.ClientCheckBox.AutoSize = true;
            this.ClientCheckBox.Location = new System.Drawing.Point(15, 250);
            this.ClientCheckBox.Name = "ClientCheckBox";
            this.ClientCheckBox.Size = new System.Drawing.Size(225, 20);
            this.ClientCheckBox.TabIndex = 4;
            this.ClientCheckBox.Text = "Выбор добавленного клиента";
            this.ClientCheckBox.UseVisualStyleBackColor = true;
            this.ClientCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // ClientTextBox
            // 
            this.ClientTextBox.Enabled = false;
            this.ClientTextBox.Location = new System.Drawing.Point(12, 285);
            this.ClientTextBox.Name = "ClientTextBox";
            this.ClientTextBox.Size = new System.Drawing.Size(251, 22);
            this.ClientTextBox.TabIndex = 5;
            this.ClientTextBox.TextChanged += new System.EventHandler(this.ClientTextBox_TextChanged);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.ClientGroupBox);
            this.panel2.Location = new System.Drawing.Point(12, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 377);
            this.panel2.TabIndex = 9;
            // 
            // ClientGroupBox
            // 
            this.ClientGroupBox.AutoSize = true;
            this.ClientGroupBox.Enabled = false;
            this.ClientGroupBox.Location = new System.Drawing.Point(3, 3);
            this.ClientGroupBox.Name = "ClientGroupBox";
            this.ClientGroupBox.Size = new System.Drawing.Size(248, 364);
            this.ClientGroupBox.TabIndex = 4;
            this.ClientGroupBox.TabStop = false;
            this.ClientGroupBox.Text = "Клиенты";
            // 
            // ServiceTextBox
            // 
            this.ServiceTextBox.Location = new System.Drawing.Point(662, 38);
            this.ServiceTextBox.Name = "ServiceTextBox";
            this.ServiceTextBox.Size = new System.Drawing.Size(249, 22);
            this.ServiceTextBox.TabIndex = 7;
            this.ServiceTextBox.TextChanged += new System.EventHandler(this.ServiceTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Имя клиента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Активность";
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Location = new System.Drawing.Point(323, 38);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Size = new System.Drawing.Size(287, 22);
            this.DiscountTextBox.TabIndex = 6;
            this.DiscountTextBox.TextChanged += new System.EventHandler(this.DiscountTextBox_TextChanged);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.DiscountGroupBox);
            this.panel3.Location = new System.Drawing.Point(323, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 289);
            this.panel3.TabIndex = 15;
            // 
            // DiscountGroupBox
            // 
            this.DiscountGroupBox.AutoSize = true;
            this.DiscountGroupBox.Location = new System.Drawing.Point(3, 3);
            this.DiscountGroupBox.Name = "DiscountGroupBox";
            this.DiscountGroupBox.Size = new System.Drawing.Size(284, 270);
            this.DiscountGroupBox.TabIndex = 4;
            this.DiscountGroupBox.TabStop = false;
            this.DiscountGroupBox.Text = "Скидки";
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.EmployeeGroupBox);
            this.panel4.Location = new System.Drawing.Point(323, 417);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 289);
            this.panel4.TabIndex = 6;
            // 
            // EmployeeGroupBox
            // 
            this.EmployeeGroupBox.AutoSize = true;
            this.EmployeeGroupBox.Location = new System.Drawing.Point(3, 3);
            this.EmployeeGroupBox.Name = "EmployeeGroupBox";
            this.EmployeeGroupBox.Size = new System.Drawing.Size(284, 270);
            this.EmployeeGroupBox.TabIndex = 4;
            this.EmployeeGroupBox.TabStop = false;
            this.EmployeeGroupBox.Text = "Работники";
            // 
            // EmployeeTextBox
            // 
            this.EmployeeTextBox.Location = new System.Drawing.Point(326, 375);
            this.EmployeeTextBox.Name = "EmployeeTextBox";
            this.EmployeeTextBox.Size = new System.Drawing.Size(284, 22);
            this.EmployeeTextBox.TabIndex = 8;
            this.EmployeeTextBox.TextChanged += new System.EventHandler(this.EmployeeTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Дата рождения";
            // 
            // BirthDateTextBox
            // 
            this.BirthDateTextBox.Location = new System.Drawing.Point(12, 209);
            this.BirthDateTextBox.Name = "BirthDateTextBox";
            this.BirthDateTextBox.Size = new System.Drawing.Size(305, 22);
            this.BirthDateTextBox.TabIndex = 3;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 718);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BirthDateTextBox);
            this.Controls.Add(this.EmployeeTextBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.DiscountTextBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServiceTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ClientTextBox);
            this.Controls.Add(this.ClientCheckBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.ActivityTextBox);
            this.Controls.Add(this.TelephoneTextBox);
            this.Controls.Add(this.NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddOrder";
            this.Text = "Добавление заказа";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox TelephoneTextBox;
        private System.Windows.Forms.TextBox ActivityTextBox;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.GroupBox ServiceGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ClientCheckBox;
        private System.Windows.Forms.TextBox ClientTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox ClientGroupBox;
        private System.Windows.Forms.TextBox ServiceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DiscountTextBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox DiscountGroupBox;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox EmployeeGroupBox;
        private System.Windows.Forms.TextBox EmployeeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BirthDateTextBox;
    }
}