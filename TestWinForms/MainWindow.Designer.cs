﻿namespace TestWinForms
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
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.услугуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скидкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
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
            this.заказыToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.заказыToolStripMenuItem2.Text = "Заказы";
            this.заказыToolStripMenuItem2.Click += new System.EventHandler(this.AddOrderToolStripMenuItem_Click);
            // 
            // услугиToolStripMenuItem3
            // 
            this.услугиToolStripMenuItem3.Name = "услугиToolStripMenuItem3";
            this.услугиToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.услугиToolStripMenuItem3.Text = "Услуги";
            this.услугиToolStripMenuItem3.Click += new System.EventHandler(this.AddServiceToolStripMenuItem1_Click);
            // 
            // скидкиToolStripMenuItem1
            // 
            this.скидкиToolStripMenuItem1.Name = "скидкиToolStripMenuItem1";
            this.скидкиToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.скидкиToolStripMenuItem1.Text = "Скидки";
            this.скидкиToolStripMenuItem1.Click += new System.EventHandler(this.AddDiscountToolStripMenuItem1_Click);
            // 
            // работникиToolStripMenuItem3
            // 
            this.работникиToolStripMenuItem3.Name = "работникиToolStripMenuItem3";
            this.работникиToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.работникиToolStripMenuItem3.Text = "Работники";
            this.работникиToolStripMenuItem3.Click += new System.EventHandler(this.AddEmployeeToolStripMenuItem1_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
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
            this.услугуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.услугуToolStripMenuItem.Text = "Услуга";
            this.услугуToolStripMenuItem.Click += new System.EventHandler(this.DeleteServiceToolStripMenuItem_Click);
            // 
            // скидкаToolStripMenuItem
            // 
            this.скидкаToolStripMenuItem.Name = "скидкаToolStripMenuItem";
            this.скидкаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.скидкаToolStripMenuItem.Text = "Скидка";
            this.скидкаToolStripMenuItem.Click += new System.EventHandler(this.DeleteDiscountToolStripMenuItem_Click);
            // 
            // работникаToolStripMenuItem
            // 
            this.работникаToolStripMenuItem.Name = "работникаToolStripMenuItem";
            this.работникаToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.работникаToolStripMenuItem.Text = "Работника";
            this.работникаToolStripMenuItem.Click += new System.EventHandler(this.DeleteEmployeeToolStripMenuItem_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 551);
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
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
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
    }
}
