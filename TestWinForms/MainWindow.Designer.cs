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
            this.GenerateTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.GenerateReportTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.сгенерироватьДоговорОПредоставленииУслугиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ChangeTSMI = new System.Windows.Forms.ToolStripMenuItem();
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
            this.DeleteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.услугуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скидкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoneyTextBox = new System.Windows.Forms.TextBox();
            this.SearchB = new System.Windows.Forms.Button();
            this.DropFiltresB = new System.Windows.Forms.Button();
            this.SearchFieldTB = new System.Windows.Forms.TextBox();
            this.TableSelectCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
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
            this.Grid.Location = new System.Drawing.Point(13, 34);
            this.Grid.Name = "Grid";
            this.Grid.ReadOnly = true;
            this.Grid.RowHeadersWidth = 51;
            this.Grid.RowTemplate.Height = 24;
            this.Grid.Size = new System.Drawing.Size(1149, 505);
            this.Grid.TabIndex = 4;
            this.Grid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Grid_RowHeaderMouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateTSMI,
            this.ShowTSMI,
            this.AddTSMI,
            this.ChangeTSMI,
            this.DeleteTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // GenerateTSMI
            // 
            this.GenerateTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GenerateReportTSMI,
            this.сгенерироватьДоговорОПредоставленииУслугиToolStripMenuItem});
            this.GenerateTSMI.Name = "GenerateTSMI";
            this.GenerateTSMI.Size = new System.Drawing.Size(128, 24);
            this.GenerateTSMI.Text = "Сформировать";
            // 
            // GenerateReportTSMI
            // 
            this.GenerateReportTSMI.Name = "GenerateReportTSMI";
            this.GenerateReportTSMI.Size = new System.Drawing.Size(440, 26);
            this.GenerateReportTSMI.Text = "Сгененрировать отчёт о даходах и расходах";
            this.GenerateReportTSMI.Click += new System.EventHandler(this.GenerateReportClick);
            // 
            // сгенерироватьДоговорОПредоставленииУслугиToolStripMenuItem
            // 
            this.сгенерироватьДоговорОПредоставленииУслугиToolStripMenuItem.Name = "сгенерироватьДоговорОПредоставленииУслугиToolStripMenuItem";
            this.сгенерироватьДоговорОПредоставленииУслугиToolStripMenuItem.Size = new System.Drawing.Size(440, 26);
            this.сгенерироватьДоговорОПредоставленииУслугиToolStripMenuItem.Text = "Сгенерировать договор о предоставлении услуги";
            this.сгенерироватьДоговорОПредоставленииУслугиToolStripMenuItem.Click += new System.EventHandler(this.GenerateContractClick);
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
            // ChangeTSMI
            // 
            this.ChangeTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыToolStripMenuItem1,
            this.услугиToolStripMenuItem,
            this.скидкиToolStripMenuItem2,
            this.работникиToolStripMenuItem});
            this.ChangeTSMI.Name = "ChangeTSMI";
            this.ChangeTSMI.Size = new System.Drawing.Size(92, 24);
            this.ChangeTSMI.Text = "Изменить";
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
            this.фИОToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // телефонToolStripMenuItem
            // 
            this.телефонToolStripMenuItem.Name = "телефонToolStripMenuItem";
            this.телефонToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.телефонToolStripMenuItem.Text = "Телефон";
            this.телефонToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // родДеятельностиToolStripMenuItem
            // 
            this.родДеятельностиToolStripMenuItem.Name = "родДеятельностиToolStripMenuItem";
            this.родДеятельностиToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.родДеятельностиToolStripMenuItem.Text = "Род деятельности";
            this.родДеятельностиToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
            // 
            // датаРожденияToolStripMenuItem
            // 
            this.датаРожденияToolStripMenuItem.Name = "датаРожденияToolStripMenuItem";
            this.датаРожденияToolStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.датаРожденияToolStripMenuItem.Text = "Дата рождения";
            this.датаРожденияToolStripMenuItem.Click += new System.EventHandler(this.ClientToolStripMenuItem_Click);
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
            this.названиеToolStripMenuItem.Click += new System.EventHandler(this.ServiceToolStripMenuItem_Click);
            // 
            // ценаToolStripMenuItem
            // 
            this.ценаToolStripMenuItem.Name = "ценаToolStripMenuItem";
            this.ценаToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.ценаToolStripMenuItem.Text = "Цена";
            this.ценаToolStripMenuItem.Click += new System.EventHandler(this.ServiceToolStripMenuItem_Click);
            // 
            // описаниеToolStripMenuItem
            // 
            this.описаниеToolStripMenuItem.Name = "описаниеToolStripMenuItem";
            this.описаниеToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.описаниеToolStripMenuItem.Text = "Описание";
            this.описаниеToolStripMenuItem.Click += new System.EventHandler(this.ServiceToolStripMenuItem_Click);
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
            this.названиеToolStripMenuItem1.Click += new System.EventHandler(this.DiscountToolStripMenuItem_Click);
            // 
            // процентToolStripMenuItem
            // 
            this.процентToolStripMenuItem.Name = "процентToolStripMenuItem";
            this.процентToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.процентToolStripMenuItem.Text = "Процент";
            this.процентToolStripMenuItem.Click += new System.EventHandler(this.DiscountToolStripMenuItem_Click);
            // 
            // описаниеToolStripMenuItem1
            // 
            this.описаниеToolStripMenuItem1.Name = "описаниеToolStripMenuItem1";
            this.описаниеToolStripMenuItem1.Size = new System.Drawing.Size(162, 26);
            this.описаниеToolStripMenuItem1.Text = "Описание";
            this.описаниеToolStripMenuItem1.Click += new System.EventHandler(this.DiscountToolStripMenuItem_Click);
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
            this.фИОToolStripMenuItem1.Click += new System.EventHandler(this.EmployeeToolStripMenuItem_Click);
            // 
            // зарплатаToolStripMenuItem
            // 
            this.зарплатаToolStripMenuItem.Name = "зарплатаToolStripMenuItem";
            this.зарплатаToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.зарплатаToolStripMenuItem.Text = "Зарплата";
            this.зарплатаToolStripMenuItem.Click += new System.EventHandler(this.EmployeeToolStripMenuItem_Click);
            // 
            // должностьToolStripMenuItem
            // 
            this.должностьToolStripMenuItem.Name = "должностьToolStripMenuItem";
            this.должностьToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.должностьToolStripMenuItem.Text = "Должность";
            this.должностьToolStripMenuItem.Click += new System.EventHandler(this.EmployeeToolStripMenuItem_Click);
            // 
            // DeleteTSMI
            // 
            this.DeleteTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.услугуToolStripMenuItem,
            this.скидкаToolStripMenuItem,
            this.работникаToolStripMenuItem});
            this.DeleteTSMI.Name = "DeleteTSMI";
            this.DeleteTSMI.Size = new System.Drawing.Size(79, 24);
            this.DeleteTSMI.Text = "Удалить";
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
        private System.Windows.Forms.ToolStripMenuItem ChangeTSMI;
        private System.Windows.Forms.ToolStripMenuItem DeleteTSMI;
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
        private System.Windows.Forms.ToolStripMenuItem GenerateTSMI;
        private System.Windows.Forms.Button SearchB;
        private System.Windows.Forms.Button DropFiltresB;
        private System.Windows.Forms.TextBox SearchFieldTB;
        private System.Windows.Forms.ComboBox TableSelectCB;
        private System.Windows.Forms.ToolStripMenuItem GenerateReportTSMI;
        private System.Windows.Forms.ToolStripMenuItem сгенерироватьДоговорОПредоставленииУслугиToolStripMenuItem;
    }
}

