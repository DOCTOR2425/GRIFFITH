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
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.AddNewClientChB = new System.Windows.Forms.CheckBox();
            this.DiscountL = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ClientL = new System.Windows.Forms.Label();
            this.AddNewClientB = new System.Windows.Forms.Button();
            this.ClientCB = new System.Windows.Forms.ComboBox();
            this.ServiceCB = new System.Windows.Forms.ComboBox();
            this.EmployeeCB = new System.Windows.Forms.ComboBox();
            this.DiscountCB = new System.Windows.Forms.ComboBox();
            this.AddDiscountChB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrderButton.Location = new System.Drawing.Point(336, 225);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(250, 57);
            this.AddOrderButton.TabIndex = 9;
            this.AddOrderButton.Text = "Добавить клиента";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // AddNewClientChB
            // 
            this.AddNewClientChB.AutoSize = true;
            this.AddNewClientChB.Location = new System.Drawing.Point(9, 78);
            this.AddNewClientChB.Name = "AddNewClientChB";
            this.AddNewClientChB.Size = new System.Drawing.Size(225, 20);
            this.AddNewClientChB.TabIndex = 4;
            this.AddNewClientChB.Text = "Выбор добавленного клиента";
            this.AddNewClientChB.UseVisualStyleBackColor = true;
            this.AddNewClientChB.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // DiscountL
            // 
            this.DiscountL.AutoSize = true;
            this.DiscountL.Enabled = false;
            this.DiscountL.Location = new System.Drawing.Point(9, 224);
            this.DiscountL.Name = "DiscountL";
            this.DiscountL.Size = new System.Drawing.Size(253, 16);
            this.DiscountL.TabIndex = 20;
            this.DiscountL.Text = "Введите название скидки для поиска";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(253, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Введите название услуги для поиска";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(238, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Введите имя работника для поиска";
            // 
            // ClientL
            // 
            this.ClientL.AutoSize = true;
            this.ClientL.Location = new System.Drawing.Point(6, 19);
            this.ClientL.Name = "ClientL";
            this.ClientL.Size = new System.Drawing.Size(222, 16);
            this.ClientL.TabIndex = 27;
            this.ClientL.Text = "Введите имя клиента для поиска";
            // 
            // AddNewClientB
            // 
            this.AddNewClientB.Enabled = false;
            this.AddNewClientB.Location = new System.Drawing.Point(9, 104);
            this.AddNewClientB.Name = "AddNewClientB";
            this.AddNewClientB.Size = new System.Drawing.Size(107, 51);
            this.AddNewClientB.TabIndex = 28;
            this.AddNewClientB.Text = "Добавить клиента";
            this.AddNewClientB.UseVisualStyleBackColor = true;
            this.AddNewClientB.Click += new System.EventHandler(this.AddNewClientB_Click);
            // 
            // ClientCB
            // 
            this.ClientCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ClientCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ClientCB.Location = new System.Drawing.Point(9, 38);
            this.ClientCB.Name = "ClientCB";
            this.ClientCB.Size = new System.Drawing.Size(253, 24);
            this.ClientCB.TabIndex = 29;
            // 
            // ServiceCB
            // 
            this.ServiceCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.ServiceCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ServiceCB.FormattingEnabled = true;
            this.ServiceCB.Location = new System.Drawing.Point(336, 38);
            this.ServiceCB.Name = "ServiceCB";
            this.ServiceCB.Size = new System.Drawing.Size(250, 24);
            this.ServiceCB.TabIndex = 30;
            // 
            // EmployeeCB
            // 
            this.EmployeeCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.EmployeeCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.EmployeeCB.FormattingEnabled = true;
            this.EmployeeCB.Location = new System.Drawing.Point(336, 104);
            this.EmployeeCB.Name = "EmployeeCB";
            this.EmployeeCB.Size = new System.Drawing.Size(250, 24);
            this.EmployeeCB.TabIndex = 31;
            // 
            // DiscountCB
            // 
            this.DiscountCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.DiscountCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DiscountCB.Enabled = false;
            this.DiscountCB.FormattingEnabled = true;
            this.DiscountCB.Location = new System.Drawing.Point(12, 258);
            this.DiscountCB.Name = "DiscountCB";
            this.DiscountCB.Size = new System.Drawing.Size(250, 24);
            this.DiscountCB.TabIndex = 32;
            // 
            // AddDiscountChB
            // 
            this.AddDiscountChB.AutoSize = true;
            this.AddDiscountChB.Location = new System.Drawing.Point(12, 187);
            this.AddDiscountChB.Name = "AddDiscountChB";
            this.AddDiscountChB.Size = new System.Drawing.Size(171, 20);
            this.AddDiscountChB.TabIndex = 33;
            this.AddDiscountChB.Text = "Предоставить скидку";
            this.AddDiscountChB.UseVisualStyleBackColor = true;
            this.AddDiscountChB.CheckedChanged += new System.EventHandler(this.AddDiscountChB_CheckedChanged);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(605, 301);
            this.Controls.Add(this.AddDiscountChB);
            this.Controls.Add(this.DiscountCB);
            this.Controls.Add(this.EmployeeCB);
            this.Controls.Add(this.ServiceCB);
            this.Controls.Add(this.ClientCB);
            this.Controls.Add(this.AddNewClientB);
            this.Controls.Add(this.ClientL);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DiscountL);
            this.Controls.Add(this.AddNewClientChB);
            this.Controls.Add(this.AddOrderButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrder";
            this.Text = "Добавление заказа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.CheckBox AddNewClientChB;
        private System.Windows.Forms.Label DiscountL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ClientL;
        private System.Windows.Forms.Button AddNewClientB;
        private System.Windows.Forms.ComboBox ClientCB;
        private System.Windows.Forms.ComboBox ServiceCB;
        private System.Windows.Forms.ComboBox EmployeeCB;
        private System.Windows.Forms.ComboBox DiscountCB;
        private System.Windows.Forms.CheckBox AddDiscountChB;
    }
}