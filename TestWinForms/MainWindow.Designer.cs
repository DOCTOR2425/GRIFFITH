namespace TestWinForms
{
    partial class MainWindow
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
            this.Grid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.отобразитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.скидкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работникиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.скидкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.работникиToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.фИОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.телефонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.родДеятельностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.датаРожденияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.названиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ценаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.описаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скидкиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.названиеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.процентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.описаниеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.работникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фИОToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.зарплатаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скидкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoneyTextBox = new System.Windows.Forms.TextBox();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem,
            this.отобразитьToolStripMenuItem1,
            this.добавитьToolStripMenuItem1,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // отобразитьToolStripMenuItem1
            // 
            this.отобразитьToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.заказыToolStripMenuItem1,
            this.услугиToolStripMenuItem2,
            this.скидкиToolStripMenuItem,
            this.работникиToolStripMenuItem2});
            this.отобразитьToolStripMenuItem1.Name = "отобразитьToolStripMenuItem1";
            this.отобразитьToolStripMenuItem1.Size = new System.Drawing.Size(105, 24);
            this.отобразитьToolStripMenuItem1.Text = "Отобразить";
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.ShowClientToolStripMenuItem_Click);
            // 
            // заказыToolStripMenuItem1
            // 
            this.заказыToolStripMenuItem1.Name = "заказыToolStripMenuItem1";
            this.заказыToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.заказыToolStripMenuItem1.Text = "Заказы";
            this.заказыToolStripMenuItem1.Click += new System.EventHandler(this.ShowOrdersToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem2
            // 
            this.услугиToolStripMenuItem2.Name = "услугиToolStripMenuItem2";
            this.услугиToolStripMenuItem2.Size = new System.Drawing.Size(166, 26);
            this.услугиToolStripMenuItem2.Text = "Услуги";
            this.услугиToolStripMenuItem2.Click += new System.EventHandler(this.ShowServiceToolStripMenuItem_Click);
            // 
            // скидкиToolStripMenuItem
            // 
            this.скидкиToolStripMenuItem.Name = "скидкиToolStripMenuItem";
            this.скидкиToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.скидкиToolStripMenuItem.Text = "Скидки";
            this.скидкиToolStripMenuItem.Click += new System.EventHandler(this.ShowDiscountToolStripMenuItem_Click);
            // 
            // работникиToolStripMenuItem2
            // 
            this.работникиToolStripMenuItem2.Name = "работникиToolStripMenuItem2";
            this.работникиToolStripMenuItem2.Size = new System.Drawing.Size(166, 26);
            this.работникиToolStripMenuItem2.Text = "Работники";
            this.работникиToolStripMenuItem2.Click += new System.EventHandler(this.ShowEmployeeToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыToolStripMenuItem2,
            this.услугиToolStripMenuItem3,
            this.скидкиToolStripMenuItem1,
            this.работникиToolStripMenuItem3});
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(90, 24);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            // 
            // заказыToolStripMenuItem2
            // 
            this.заказыToolStripMenuItem2.Name = "заказыToolStripMenuItem2";
            this.заказыToolStripMenuItem2.Size = new System.Drawing.Size(166, 26);
            this.заказыToolStripMenuItem2.Text = "Заказы";
            this.заказыToolStripMenuItem2.Click += new System.EventHandler(this.AddOrderToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem3
            // 
            this.услугиToolStripMenuItem3.Name = "услугиToolStripMenuItem3";
            this.услугиToolStripMenuItem3.Size = new System.Drawing.Size(166, 26);
            this.услугиToolStripMenuItem3.Text = "Услуги";
            this.услугиToolStripMenuItem3.Click += new System.EventHandler(this.AddServiceToolStripMenuItem1_Click);
            // 
            // скидкиToolStripMenuItem1
            // 
            this.скидкиToolStripMenuItem1.Name = "скидкиToolStripMenuItem1";
            this.скидкиToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.скидкиToolStripMenuItem1.Text = "Скидки";
            this.скидкиToolStripMenuItem1.Click += new System.EventHandler(this.AddDiscountToolStripMenuItem1_Click);
            // 
            // работникиToolStripMenuItem3
            // 
            this.работникиToolStripMenuItem3.Name = "работникиToolStripMenuItem3";
            this.работникиToolStripMenuItem3.Size = new System.Drawing.Size(166, 26);
            this.работникиToolStripMenuItem3.Text = "Работники";
            this.работникиToolStripMenuItem3.Click += new System.EventHandler(this.AddEmployeeToolStripMenuItem1_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem1,
            this.услугиToolStripMenuItem,
            this.скидкиToolStripMenuItem2,
            this.работникиToolStripMenuItem});
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            // 
            // клиентыToolStripMenuItem1
            // 
            this.клиентыToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фИОToolStripMenuItem,
            this.телефонToolStripMenuItem,
            this.родДеятельностиToolStripMenuItem,
            this.датаРожденияToolStripMenuItem});
            this.клиентыToolStripMenuItem1.Name = "клиентыToolStripMenuItem1";
            this.клиентыToolStripMenuItem1.Size = new System.Drawing.Size(166, 26);
            this.клиентыToolStripMenuItem1.Text = "Клиенты";
            // 
            // фИОToolStripMenuItem
            // 
            this.фИОToolStripMenuItem.Name = "фИОToolStripMenuItem";
            this.фИОToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.фИОToolStripMenuItem.Text = "ФИО";
            this.фИОToolStripMenuItem.Click += new System.EventHandler(this.ФИОToolStripMenuItem_Click);
            // 
            // телефонToolStripMenuItem
            // 
            this.телефонToolStripMenuItem.Name = "телефонToolStripMenuItem";
            this.телефонToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.телефонToolStripMenuItem.Text = "Телефон";
            this.телефонToolStripMenuItem.Click += new System.EventHandler(this.ТелефонToolStripMenuItem_Click);
            // 
            // родДеятельностиToolStripMenuItem
            // 
            this.родДеятельностиToolStripMenuItem.Name = "родДеятельностиToolStripMenuItem";
            this.родДеятельностиToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.родДеятельностиToolStripMenuItem.Text = "Род деятельности";
            this.родДеятельностиToolStripMenuItem.Click += new System.EventHandler(this.РодДеятельностиToolStripMenuItem_Click);
            // 
            // датаРожденияToolStripMenuItem
            // 
            this.датаРожденияToolStripMenuItem.Name = "датаРожденияToolStripMenuItem";
            this.датаРожденияToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.датаРожденияToolStripMenuItem.Text = "Дата рождения";
            this.датаРожденияToolStripMenuItem.Click += new System.EventHandler(this.ДатаРожденияToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem
            // 
            this.услугиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.названиеToolStripMenuItem,
            this.ценаToolStripMenuItem,
            this.описаниеToolStripMenuItem});
            this.услугиToolStripMenuItem.Name = "услугиToolStripMenuItem";
            this.услугиToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.услугиToolStripMenuItem.Text = "Услуги";
            // 
            // названиеToolStripMenuItem
            // 
            this.названиеToolStripMenuItem.Name = "названиеToolStripMenuItem";
            this.названиеToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.названиеToolStripMenuItem.Text = "Название";
            this.названиеToolStripMenuItem.Click += new System.EventHandler(this.НазваниеToolStripMenuItem_Click);
            // 
            // ценаToolStripMenuItem
            // 
            this.ценаToolStripMenuItem.Name = "ценаToolStripMenuItem";
            this.ценаToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.ценаToolStripMenuItem.Text = "Цена";
            this.ценаToolStripMenuItem.Click += new System.EventHandler(this.ЦенаToolStripMenuItem_Click);
            // 
            // описаниеToolStripMenuItem
            // 
            this.описаниеToolStripMenuItem.Name = "описаниеToolStripMenuItem";
            this.описаниеToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.описаниеToolStripMenuItem.Text = "Описание";
            this.описаниеToolStripMenuItem.Click += new System.EventHandler(this.ОписаниеToolStripMenuItem_Click);
            // 
            // скидкиToolStripMenuItem2
            // 
            this.скидкиToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.названиеToolStripMenuItem1,
            this.процентToolStripMenuItem,
            this.описаниеToolStripMenuItem1});
            this.скидкиToolStripMenuItem2.Name = "скидкиToolStripMenuItem2";
            this.скидкиToolStripMenuItem2.Size = new System.Drawing.Size(166, 26);
            this.скидкиToolStripMenuItem2.Text = "Скидки";
            // 
            // названиеToolStripMenuItem1
            // 
            this.названиеToolStripMenuItem1.Name = "названиеToolStripMenuItem1";
            this.названиеToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.названиеToolStripMenuItem1.Text = "Название";
            this.названиеToolStripMenuItem1.Click += new System.EventHandler(this.НазваниеToolStripMenuItem1_Click);
            // 
            // процентToolStripMenuItem
            // 
            this.процентToolStripMenuItem.Name = "процентToolStripMenuItem";
            this.процентToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.процентToolStripMenuItem.Text = "Процент";
            this.процентToolStripMenuItem.Click += new System.EventHandler(this.ПроцентToolStripMenuItem_Click);
            // 
            // описаниеToolStripMenuItem1
            // 
            this.описаниеToolStripMenuItem1.Name = "описаниеToolStripMenuItem1";
            this.описаниеToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.описаниеToolStripMenuItem1.Text = "Описание";
            this.описаниеToolStripMenuItem1.Click += new System.EventHandler(this.ОписаниеToolStripMenuItem1_Click);
            // 
            // работникиToolStripMenuItem
            // 
            this.работникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фИОToolStripMenuItem1,
            this.зарплатаToolStripMenuItem,
            this.должностьToolStripMenuItem});
            this.работникиToolStripMenuItem.Name = "работникиToolStripMenuItem";
            this.работникиToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.работникиToolStripMenuItem.Text = "Работники";
            // 
            // фИОToolStripMenuItem1
            // 
            this.фИОToolStripMenuItem1.Name = "фИОToolStripMenuItem1";
            this.фИОToolStripMenuItem1.Size = new System.Drawing.Size(169, 26);
            this.фИОToolStripMenuItem1.Text = "ФИО";
            this.фИОToolStripMenuItem1.Click += new System.EventHandler(this.ФИОToolStripMenuItem1_Click);
            // 
            // зарплатаToolStripMenuItem
            // 
            this.зарплатаToolStripMenuItem.Name = "зарплатаToolStripMenuItem";
            this.зарплатаToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.зарплатаToolStripMenuItem.Text = "Зарплата";
            this.зарплатаToolStripMenuItem.Click += new System.EventHandler(this.ЗарплатаToolStripMenuItem_Click);
            // 
            // должностьToolStripMenuItem
            // 
            this.должностьToolStripMenuItem.Name = "должностьToolStripMenuItem";
            this.должностьToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.должностьToolStripMenuItem.Text = "Должность";
            this.должностьToolStripMenuItem.Click += new System.EventHandler(this.ДолжностьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.услугуToolStripMenuItem,
            this.скидкаToolStripMenuItem,
            this.работникаToolStripMenuItem});
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // услугуToolStripMenuItem
            // 
            this.услугуToolStripMenuItem.Name = "услугуToolStripMenuItem";
            this.услугуToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.услугуToolStripMenuItem.Text = "Услуга";
            this.услугуToolStripMenuItem.Click += new System.EventHandler(this.DeleteServiceToolStripMenuItem_Click);
            // 
            // скидкаToolStripMenuItem
            // 
            this.скидкаToolStripMenuItem.Name = "скидкаToolStripMenuItem";
            this.скидкаToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.скидкаToolStripMenuItem.Text = "Скидка";
            this.скидкаToolStripMenuItem.Click += new System.EventHandler(this.DeleteDiscountToolStripMenuItem_Click);
            // 
            // работникаToolStripMenuItem
            // 
            this.работникаToolStripMenuItem.Name = "работникаToolStripMenuItem";
            this.работникаToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.работникаToolStripMenuItem.Text = "Работника";
            this.работникаToolStripMenuItem.Click += new System.EventHandler(this.DeleteEmployeeToolStripMenuItem_Click);
            // 
            // MoneyTextBox
            // 
            this.MoneyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoneyTextBox.Location = new System.Drawing.Point(1010, 6);
            this.MoneyTextBox.Name = "MoneyTextBox";
            this.MoneyTextBox.ReadOnly = true;
            this.MoneyTextBox.Size = new System.Drawing.Size(90, 22);
            this.MoneyTextBox.TabIndex = 6;
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 551);
            this.Controls.Add(this.MoneyTextBox);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1100, 200);
            this.Name = "MainWindow";
            this.Text = "GRIFFITH";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem отобразитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem скидкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работникиToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem скидкиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem работникиToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem услугуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скидкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работникаToolStripMenuItem;
        private System.Windows.Forms.TextBox MoneyTextBox;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скидкиToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem работникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фИОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem телефонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem родДеятельностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem датаРожденияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem названиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ценаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem описаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem названиеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem процентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem описаниеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem фИОToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem зарплатаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
    }
}

