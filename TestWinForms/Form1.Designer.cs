namespace TestWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ShowClientsButton = new System.Windows.Forms.Button();
            this.ShowServicesButton = new System.Windows.Forms.Button();
            this.ShowOrdersButton = new System.Windows.Forms.Button();
            this.ShowDiscountsButton = new System.Windows.Forms.Button();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.AddDiscountButton = new System.Windows.Forms.Button();
            this.AddServiceButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.ShowEmployeesButton = new System.Windows.Forms.Button();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowClientsButton
            // 
            this.ShowClientsButton.Location = new System.Drawing.Point(13, 13);
            this.ShowClientsButton.Name = "ShowClientsButton";
            this.ShowClientsButton.Size = new System.Drawing.Size(75, 32);
            this.ShowClientsButton.TabIndex = 0;
            this.ShowClientsButton.Text = "Клиенты";
            this.ShowClientsButton.UseVisualStyleBackColor = true;
            this.ShowClientsButton.Click += new System.EventHandler(this.ShowClientsButton_Click);
            // 
            // ShowServicesButton
            // 
            this.ShowServicesButton.Location = new System.Drawing.Point(94, 12);
            this.ShowServicesButton.Name = "ShowServicesButton";
            this.ShowServicesButton.Size = new System.Drawing.Size(75, 32);
            this.ShowServicesButton.TabIndex = 1;
            this.ShowServicesButton.Text = "Услуги";
            this.ShowServicesButton.UseVisualStyleBackColor = true;
            this.ShowServicesButton.Click += new System.EventHandler(this.ShowServiceButton_Click);
            // 
            // ShowOrdersButton
            // 
            this.ShowOrdersButton.Location = new System.Drawing.Point(175, 12);
            this.ShowOrdersButton.Name = "ShowOrdersButton";
            this.ShowOrdersButton.Size = new System.Drawing.Size(75, 32);
            this.ShowOrdersButton.TabIndex = 2;
            this.ShowOrdersButton.Text = "Заказы";
            this.ShowOrdersButton.UseVisualStyleBackColor = true;
            this.ShowOrdersButton.Click += new System.EventHandler(this.ShowOrdersButton_Click);
            // 
            // ShowDiscountsButton
            // 
            this.ShowDiscountsButton.Location = new System.Drawing.Point(256, 12);
            this.ShowDiscountsButton.Name = "ShowDiscountsButton";
            this.ShowDiscountsButton.Size = new System.Drawing.Size(75, 32);
            this.ShowDiscountsButton.TabIndex = 3;
            this.ShowDiscountsButton.Text = "Скидки";
            this.ShowDiscountsButton.UseVisualStyleBackColor = true;
            this.ShowDiscountsButton.Click += new System.EventHandler(this.ShowDiscountButton_Click);
            // 
            // Grid
            // 
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(13, 51);
            this.Grid.Name = "Grid";
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowTemplate.Height = 24;
            this.Grid.Size = new System.Drawing.Size(1087, 488);
            this.Grid.TabIndex = 4;
            this.Grid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_RowHeaderMouseDoubleClick);
            // 
            // AddDiscountButton
            // 
            this.AddDiscountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDiscountButton.Location = new System.Drawing.Point(786, 10);
            this.AddDiscountButton.Name = "AddDiscountButton";
            this.AddDiscountButton.Size = new System.Drawing.Size(144, 31);
            this.AddDiscountButton.TabIndex = 8;
            this.AddDiscountButton.Text = "Добавить скидки";
            this.AddDiscountButton.UseVisualStyleBackColor = true;
            this.AddDiscountButton.Click += new System.EventHandler(this.AddDiscountButton_Click);
            // 
            // AddServiceButton
            // 
            this.AddServiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddServiceButton.Location = new System.Drawing.Point(644, 10);
            this.AddServiceButton.Name = "AddServiceButton";
            this.AddServiceButton.Size = new System.Drawing.Size(136, 32);
            this.AddServiceButton.TabIndex = 6;
            this.AddServiceButton.Text = "Добавить услуги";
            this.AddServiceButton.UseVisualStyleBackColor = true;
            this.AddServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddOrderButton.Location = new System.Drawing.Point(504, 9);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(134, 32);
            this.AddOrderButton.TabIndex = 5;
            this.AddOrderButton.Text = "Добавить заказ";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // ShowEmployeesButton
            // 
            this.ShowEmployeesButton.Location = new System.Drawing.Point(337, 12);
            this.ShowEmployeesButton.Name = "ShowEmployeesButton";
            this.ShowEmployeesButton.Size = new System.Drawing.Size(89, 31);
            this.ShowEmployeesButton.TabIndex = 9;
            this.ShowEmployeesButton.Text = "Работники";
            this.ShowEmployeesButton.UseVisualStyleBackColor = true;
            this.ShowEmployeesButton.Click += new System.EventHandler(this.ShowEmployeesButton_Click);
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEmployeeButton.Location = new System.Drawing.Point(936, 9);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(164, 32);
            this.AddEmployeeButton.TabIndex = 10;
            this.AddEmployeeButton.Text = "Добавить работника";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 551);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.ShowEmployeesButton);
            this.Controls.Add(this.AddDiscountButton);
            this.Controls.Add(this.AddServiceButton);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.ShowDiscountsButton);
            this.Controls.Add(this.ShowOrdersButton);
            this.Controls.Add(this.ShowServicesButton);
            this.Controls.Add(this.ShowClientsButton);
            this.MinimumSize = new System.Drawing.Size(1100, 200);
            this.Name = "Form1";
            this.Text = "GRIFFITH";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShowClientsButton;
        private System.Windows.Forms.Button ShowServicesButton;
        private System.Windows.Forms.Button ShowOrdersButton;
        private System.Windows.Forms.Button ShowDiscountsButton;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Button AddDiscountButton;
        private System.Windows.Forms.Button AddServiceButton;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button ShowEmployeesButton;
        private System.Windows.Forms.Button AddEmployeeButton;
    }
}

