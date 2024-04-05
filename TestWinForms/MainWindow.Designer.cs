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
            this.components = new System.ComponentModel.Container();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.GridContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.GenerateTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateReports = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateGraphs = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.скидкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работникиToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.заказыToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.услугиToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.скидкиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.работникиToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MoneyTextBox = new System.Windows.Forms.TextBox();
            this.SearchB = new System.Windows.Forms.Button();
            this.DropFiltresB = new System.Windows.Forms.Button();
            this.SearchFieldTB = new System.Windows.Forms.TextBox();
            this.TableSelectCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.GridContextMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowUserToAddRows = false;
            this.Grid.AllowUserToDeleteRows = false;
            this.Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.ContextMenuStrip = this.GridContextMenu;
            this.Grid.Location = new System.Drawing.Point(13, 34);
            this.Grid.MultiSelect = false;
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowTemplate.Height = 24;
            this.Grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid.Size = new System.Drawing.Size(1149, 505);
            this.Grid.TabIndex = 4;
            this.Grid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_RowHeaderMouseDoubleClick);
            // 
            // GridContextMenu
            // 
            this.GridContextMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.GridContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.GridContextMenu.Name = "contextMenuStrip1";
            this.GridContextMenu.Size = new System.Drawing.Size(148, 52);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.ChangeItemInLineTSMIClick);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.DeleteItemInLineTSMIClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateTSMI,
            this.ShowTSMI,
            this.AddTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GenerateTSMI
            // 
            this.GenerateTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateReports,
            this.GenerateGraphs});
            this.GenerateTSMI.Name = "GenerateTSMI";
            this.GenerateTSMI.Size = new System.Drawing.Size(65, 24);
            this.GenerateTSMI.Text = "Меню";
            // 
            // GenerateReports
            // 
            this.GenerateReports.Name = "GenerateReports";
            this.GenerateReports.Size = new System.Drawing.Size(440, 26);
            this.GenerateReports.Text = "Сгенерировать договор о предоставлении услуги";
            this.GenerateReports.Click += new System.EventHandler(this.GenerateContractClick);
            // 
            // GenerateGraphs
            // 
            this.GenerateGraphs.Name = "GenerateGraphs";
            this.GenerateGraphs.Size = new System.Drawing.Size(440, 26);
            this.GenerateGraphs.Text = "Сгененрировать отчёт о даходах и расходах";
            this.GenerateGraphs.Click += new System.EventHandler(this.GenerateReportClick);
            // 
            // ShowTSMI
            // 
            this.ShowTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem,
            this.заказыToolStripMenuItem1,
            this.услугиToolStripMenuItem2,
            this.скидкиToolStripMenuItem,
            this.работникиToolStripMenuItem2});
            this.ShowTSMI.Name = "ShowTSMI";
            this.ShowTSMI.Size = new System.Drawing.Size(105, 24);
            this.ShowTSMI.Text = "Отобразить";
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
            // AddTSMI
            // 
            this.AddTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказыToolStripMenuItem2,
            this.услугиToolStripMenuItem3,
            this.скидкиToolStripMenuItem1,
            this.работникиToolStripMenuItem3});
            this.AddTSMI.Name = "AddTSMI";
            this.AddTSMI.Size = new System.Drawing.Size(90, 24);
            this.AddTSMI.Text = "Добавить";
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
            // MoneyTextBox
            // 
            this.MoneyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoneyTextBox.Location = new System.Drawing.Point(1072, 6);
            this.MoneyTextBox.Name = "MoneyTextBox";
            this.MoneyTextBox.ReadOnly = true;
            this.MoneyTextBox.Size = new System.Drawing.Size(90, 22);
            this.MoneyTextBox.TabIndex = 6;
            // 
            // SearchB
            // 
            this.SearchB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchB.Location = new System.Drawing.Point(895, 4);
            this.SearchB.MaximumSize = new System.Drawing.Size(75, 24);
            this.SearchB.MinimumSize = new System.Drawing.Size(75, 24);
            this.SearchB.Name = "SearchB";
            this.SearchB.Size = new System.Drawing.Size(75, 24);
            this.SearchB.TabIndex = 9;
            this.SearchB.Text = "Поиск";
            this.SearchB.UseVisualStyleBackColor = true;
            this.SearchB.Click += new System.EventHandler(this.SearchB_Click);
            // 
            // DropFiltresB
            // 
            this.DropFiltresB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DropFiltresB.Location = new System.Drawing.Point(976, 4);
            this.DropFiltresB.MaximumSize = new System.Drawing.Size(75, 24);
            this.DropFiltresB.MinimumSize = new System.Drawing.Size(75, 24);
            this.DropFiltresB.Name = "DropFiltresB";
            this.DropFiltresB.Size = new System.Drawing.Size(75, 24);
            this.DropFiltresB.TabIndex = 10;
            this.DropFiltresB.Text = "Сброс";
            this.DropFiltresB.UseVisualStyleBackColor = true;
            this.DropFiltresB.Click += new System.EventHandler(this.DropFiltresB_Click);
            // 
            // SearchFieldTB
            // 
            this.SearchFieldTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchFieldTB.BackColor = System.Drawing.SystemColors.Window;
            this.SearchFieldTB.Location = new System.Drawing.Point(741, 6);
            this.SearchFieldTB.MaximumSize = new System.Drawing.Size(148, 22);
            this.SearchFieldTB.MinimumSize = new System.Drawing.Size(148, 22);
            this.SearchFieldTB.Name = "SearchFieldTB";
            this.SearchFieldTB.Size = new System.Drawing.Size(148, 22);
            this.SearchFieldTB.TabIndex = 11;
            // 
            // TableSelectCB
            // 
            this.TableSelectCB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableSelectCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.TableSelectCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TableSelectCB.FormattingEnabled = true;
            this.TableSelectCB.Location = new System.Drawing.Point(571, 4);
            this.TableSelectCB.MaximumSize = new System.Drawing.Size(148, 0);
            this.TableSelectCB.MinimumSize = new System.Drawing.Size(148, 0);
            this.TableSelectCB.Name = "TableSelectCB";
            this.TableSelectCB.Size = new System.Drawing.Size(148, 24);
            this.TableSelectCB.TabIndex = 12;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1174, 551);
            this.Controls.Add(this.TableSelectCB);
            this.Controls.Add(this.SearchFieldTB);
            this.Controls.Add(this.DropFiltresB);
            this.Controls.Add(this.SearchB);
            this.Controls.Add(this.MoneyTextBox);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1192, 300);
            this.Name = "MainWindow";
            this.Text = "GRIFFITH";
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.GridContextMenu.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ShowTSMI;
        private System.Windows.Forms.ToolStripMenuItem клиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem скидкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работникиToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem AddTSMI;
        private System.Windows.Forms.ToolStripMenuItem заказыToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem услугиToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem скидкиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem работникиToolStripMenuItem3;
        private System.Windows.Forms.TextBox MoneyTextBox;
        private System.Windows.Forms.ToolStripMenuItem GenerateTSMI;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.Button DropFiltresB;
        private System.Windows.Forms.TextBox SearchFieldTB;
        private System.Windows.Forms.ComboBox TableSelectCB;
        private System.Windows.Forms.ToolStripMenuItem GenerateGraphs;
        private System.Windows.Forms.ToolStripMenuItem GenerateReports;
        private System.Windows.Forms.ContextMenuStrip GridContextMenu;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}

