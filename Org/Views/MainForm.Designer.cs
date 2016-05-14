namespace Org
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbEmployees = new System.Windows.Forms.ToolStripButton();
            this.tsbVendors = new System.Windows.Forms.ToolStripButton();
            this.tsbClients = new System.Windows.Forms.ToolStripButton();
            this.tssbReports = new System.Windows.Forms.ToolStripSplitButton();
            this.gvCatalog = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufactor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiveCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReserveCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalReceivePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSendPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAddEdit = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAddEdit = new System.Windows.Forms.Button();
            this.lDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lTotalSendPrice = new System.Windows.Forms.Label();
            this.lSendDate = new System.Windows.Forms.Label();
            this.lReceiveCount = new System.Windows.Forms.Label();
            this.lSendCount = new System.Windows.Forms.Label();
            this.lTotalReceivePrice = new System.Windows.Forms.Label();
            this.lReserveCount = new System.Windows.Forms.Label();
            this.dtpSendDate = new System.Windows.Forms.DateTimePicker();
            this.lPrice = new System.Windows.Forms.Label();
            this.lReceiveDate = new System.Windows.Forms.Label();
            this.lVendor = new System.Windows.Forms.Label();
            this.lEmployee = new System.Windows.Forms.Label();
            this.lNumber = new System.Windows.Forms.Label();
            this.lClient = new System.Windows.Forms.Label();
            this.cbManufactor = new System.Windows.Forms.ComboBox();
            this.cbVendor = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbClient = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.nTotalSendPrice = new System.Windows.Forms.NumericUpDown();
            this.nTotalReceivePrice = new System.Windows.Forms.NumericUpDown();
            this.nReserveCount = new System.Windows.Forms.NumericUpDown();
            this.nSendCount = new System.Windows.Forms.NumericUpDown();
            this.nReceiveCount = new System.Windows.Forms.NumericUpDown();
            this.nPrice = new System.Windows.Forms.NumericUpDown();
            this.dtpReceiveDate = new System.Windows.Forms.DateTimePicker();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.lManufactor = new System.Windows.Forms.Label();
            this.lCategory = new System.Windows.Forms.Label();
            this.mainToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatalog)).BeginInit();
            this.gbAddEdit.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTotalSendPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTotalReceivePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nReserveCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSendCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nReceiveCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.AutoSize = false;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbEmployees,
            this.tsbVendors,
            this.tsbClients,
            this.tssbReports});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.mainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mainToolStrip.Size = new System.Drawing.Size(908, 64);
            this.mainToolStrip.TabIndex = 1;
            // 
            // tsbEmployees
            // 
            this.tsbEmployees.AutoSize = false;
            this.tsbEmployees.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEmployees.Image = global::Org.Properties.Resources.Employees;
            this.tsbEmployees.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEmployees.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEmployees.Name = "tsbEmployees";
            this.tsbEmployees.Size = new System.Drawing.Size(64, 64);
            this.tsbEmployees.Text = "Сотрудники";
            this.tsbEmployees.Click += new System.EventHandler(this.tsbEmployees_Click);
            // 
            // tsbVendors
            // 
            this.tsbVendors.AutoSize = false;
            this.tsbVendors.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbVendors.Image = global::Org.Properties.Resources.Vendors;
            this.tsbVendors.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbVendors.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbVendors.Name = "tsbVendors";
            this.tsbVendors.Size = new System.Drawing.Size(64, 64);
            this.tsbVendors.Text = "Поставщики";
            this.tsbVendors.Click += new System.EventHandler(this.tsbVendors_Click);
            // 
            // tsbClients
            // 
            this.tsbClients.AutoSize = false;
            this.tsbClients.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClients.Image = global::Org.Properties.Resources.Clients;
            this.tsbClients.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbClients.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClients.Name = "tsbClients";
            this.tsbClients.Size = new System.Drawing.Size(64, 64);
            this.tsbClients.Text = "Клиенты";
            // 
            // tssbReports
            // 
            this.tssbReports.AutoSize = false;
            this.tssbReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tssbReports.Image = global::Org.Properties.Resources.Reports;
            this.tssbReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssbReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssbReports.Name = "tssbReports";
            this.tssbReports.Size = new System.Drawing.Size(78, 64);
            this.tssbReports.Text = "Отчеты";
            // 
            // gvCatalog
            // 
            this.gvCatalog.AllowUserToAddRows = false;
            this.gvCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.Manufactor,
            this.Price,
            this.Number,
            this.Vendor,
            this.Client,
            this.Employee,
            this.ReceiveDate,
            this.SendDate,
            this.ReceiveCount,
            this.SendCount,
            this.ReserveCount,
            this.TotalReceivePrice,
            this.TotalSendPrice});
            this.gvCatalog.Location = new System.Drawing.Point(0, 91);
            this.gvCatalog.Name = "gvCatalog";
            this.gvCatalog.Size = new System.Drawing.Size(324, 362);
            this.gvCatalog.TabIndex = 2;
            this.gvCatalog.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvCatalog_CellClick);
            // 
            // Category
            // 
            this.Category.HeaderText = "Категория";
            this.Category.Name = "Category";
            // 
            // Manufactor
            // 
            this.Manufactor.HeaderText = "Производитель";
            this.Manufactor.Name = "Manufactor";
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            // 
            // Number
            // 
            this.Number.HeaderText = "Серийный нормер";
            this.Number.Name = "Number";
            // 
            // Vendor
            // 
            this.Vendor.HeaderText = "Поставщик";
            this.Vendor.Name = "Vendor";
            // 
            // Client
            // 
            this.Client.HeaderText = "Клиент";
            this.Client.Name = "Client";
            // 
            // Employee
            // 
            this.Employee.HeaderText = "Сотрудник";
            this.Employee.Name = "Employee";
            // 
            // ReceiveDate
            // 
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.ReceiveDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.ReceiveDate.HeaderText = "Дата поставки";
            this.ReceiveDate.Name = "ReceiveDate";
            // 
            // SendDate
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.SendDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.SendDate.HeaderText = "Дата отпуска";
            this.SendDate.Name = "SendDate";
            // 
            // ReceiveCount
            // 
            this.ReceiveCount.HeaderText = "Поставлено товара";
            this.ReceiveCount.Name = "ReceiveCount";
            // 
            // SendCount
            // 
            this.SendCount.HeaderText = "Отдано товара";
            this.SendCount.Name = "SendCount";
            // 
            // ReserveCount
            // 
            this.ReserveCount.HeaderText = "Осталось на складе";
            this.ReserveCount.Name = "ReserveCount";
            // 
            // TotalReceivePrice
            // 
            this.TotalReceivePrice.HeaderText = "Сумма полученого товара";
            this.TotalReceivePrice.Name = "TotalReceivePrice";
            // 
            // TotalSendPrice
            // 
            this.TotalSendPrice.HeaderText = "Сумма проданного товара";
            this.TotalSendPrice.Name = "TotalSendPrice";
            // 
            // gbAddEdit
            // 
            this.gbAddEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbAddEdit.Controls.Add(this.flowLayoutPanel1);
            this.gbAddEdit.Controls.Add(this.lDescription);
            this.gbAddEdit.Controls.Add(this.rtbDescription);
            this.gbAddEdit.Controls.Add(this.lTotalSendPrice);
            this.gbAddEdit.Controls.Add(this.lSendDate);
            this.gbAddEdit.Controls.Add(this.lReceiveCount);
            this.gbAddEdit.Controls.Add(this.lSendCount);
            this.gbAddEdit.Controls.Add(this.lTotalReceivePrice);
            this.gbAddEdit.Controls.Add(this.lReserveCount);
            this.gbAddEdit.Controls.Add(this.dtpSendDate);
            this.gbAddEdit.Controls.Add(this.lPrice);
            this.gbAddEdit.Controls.Add(this.lReceiveDate);
            this.gbAddEdit.Controls.Add(this.lVendor);
            this.gbAddEdit.Controls.Add(this.lEmployee);
            this.gbAddEdit.Controls.Add(this.lNumber);
            this.gbAddEdit.Controls.Add(this.lClient);
            this.gbAddEdit.Controls.Add(this.cbManufactor);
            this.gbAddEdit.Controls.Add(this.cbVendor);
            this.gbAddEdit.Controls.Add(this.cbEmployee);
            this.gbAddEdit.Controls.Add(this.cbClient);
            this.gbAddEdit.Controls.Add(this.cbCategory);
            this.gbAddEdit.Controls.Add(this.nTotalSendPrice);
            this.gbAddEdit.Controls.Add(this.nTotalReceivePrice);
            this.gbAddEdit.Controls.Add(this.nReserveCount);
            this.gbAddEdit.Controls.Add(this.nSendCount);
            this.gbAddEdit.Controls.Add(this.nReceiveCount);
            this.gbAddEdit.Controls.Add(this.nPrice);
            this.gbAddEdit.Controls.Add(this.dtpReceiveDate);
            this.gbAddEdit.Controls.Add(this.tbNumber);
            this.gbAddEdit.Controls.Add(this.lManufactor);
            this.gbAddEdit.Controls.Add(this.lCategory);
            this.gbAddEdit.Location = new System.Drawing.Point(336, 86);
            this.gbAddEdit.Name = "gbAddEdit";
            this.gbAddEdit.Size = new System.Drawing.Size(560, 370);
            this.gbAddEdit.TabIndex = 3;
            this.gbAddEdit.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bCancel);
            this.flowLayoutPanel1.Controls.Add(this.bAddEdit);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(230, 335);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(324, 29);
            this.flowLayoutPanel1.TabIndex = 22;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(246, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 21;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Visible = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAddEdit
            // 
            this.bAddEdit.Location = new System.Drawing.Point(165, 3);
            this.bAddEdit.Name = "bAddEdit";
            this.bAddEdit.Size = new System.Drawing.Size(75, 23);
            this.bAddEdit.TabIndex = 0;
            this.bAddEdit.Text = "Добавить";
            this.bAddEdit.UseVisualStyleBackColor = true;
            this.bAddEdit.Click += new System.EventHandler(this.bAddEdit_Click);
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Location = new System.Drawing.Point(6, 212);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(57, 13);
            this.lDescription.TabIndex = 20;
            this.lDescription.Text = "Описание";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(9, 228);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(545, 107);
            this.rtbDescription.TabIndex = 19;
            this.rtbDescription.Text = "";
            // 
            // lTotalSendPrice
            // 
            this.lTotalSendPrice.AutoSize = true;
            this.lTotalSendPrice.Location = new System.Drawing.Point(277, 176);
            this.lTotalSendPrice.Name = "lTotalSendPrice";
            this.lTotalSendPrice.Size = new System.Drawing.Size(165, 13);
            this.lTotalSendPrice.TabIndex = 18;
            this.lTotalSendPrice.Text = "Сумма реализованного товара";
            // 
            // lSendDate
            // 
            this.lSendDate.AutoSize = true;
            this.lSendDate.Location = new System.Drawing.Point(279, 43);
            this.lSendDate.Name = "lSendDate";
            this.lSendDate.Size = new System.Drawing.Size(114, 13);
            this.lSendDate.TabIndex = 17;
            this.lSendDate.Text = "Дата отпуска товара";
            // 
            // lReceiveCount
            // 
            this.lReceiveCount.AutoSize = true;
            this.lReceiveCount.Location = new System.Drawing.Point(279, 69);
            this.lReceiveCount.Name = "lReceiveCount";
            this.lReceiveCount.Size = new System.Drawing.Size(93, 13);
            this.lReceiveCount.TabIndex = 16;
            this.lReceiveCount.Text = "Получено товара";
            // 
            // lSendCount
            // 
            this.lSendCount.AutoSize = true;
            this.lSendCount.Location = new System.Drawing.Point(277, 96);
            this.lSendCount.Name = "lSendCount";
            this.lSendCount.Size = new System.Drawing.Size(96, 13);
            this.lSendCount.TabIndex = 15;
            this.lSendCount.Text = "Отпущено товара";
            // 
            // lTotalReceivePrice
            // 
            this.lTotalReceivePrice.AutoSize = true;
            this.lTotalReceivePrice.Location = new System.Drawing.Point(279, 149);
            this.lTotalReceivePrice.Name = "lTotalReceivePrice";
            this.lTotalReceivePrice.Size = new System.Drawing.Size(145, 13);
            this.lTotalReceivePrice.TabIndex = 14;
            this.lTotalReceivePrice.Text = "Сумма полученного товара";
            // 
            // lReserveCount
            // 
            this.lReserveCount.AutoSize = true;
            this.lReserveCount.Location = new System.Drawing.Point(279, 122);
            this.lReserveCount.Name = "lReserveCount";
            this.lReserveCount.Size = new System.Drawing.Size(129, 13);
            this.lReserveCount.TabIndex = 13;
            this.lReserveCount.Text = "Итого товара на складе";
            // 
            // dtpSendDate
            // 
            this.dtpSendDate.Location = new System.Drawing.Point(415, 43);
            this.dtpSendDate.Name = "dtpSendDate";
            this.dtpSendDate.Size = new System.Drawing.Size(139, 20);
            this.dtpSendDate.TabIndex = 12;
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(6, 69);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(33, 13);
            this.lPrice.TabIndex = 11;
            this.lPrice.Text = "Цена";
            // 
            // lReceiveDate
            // 
            this.lReceiveDate.AutoSize = true;
            this.lReceiveDate.Location = new System.Drawing.Point(279, 19);
            this.lReceiveDate.Name = "lReceiveDate";
            this.lReceiveDate.Size = new System.Drawing.Size(121, 13);
            this.lReceiveDate.TabIndex = 10;
            this.lReceiveDate.Text = "Дата поставки товара";
            // 
            // lVendor
            // 
            this.lVendor.AutoSize = true;
            this.lVendor.Location = new System.Drawing.Point(6, 176);
            this.lVendor.Name = "lVendor";
            this.lVendor.Size = new System.Drawing.Size(65, 13);
            this.lVendor.TabIndex = 9;
            this.lVendor.Text = "Поставщик";
            // 
            // lEmployee
            // 
            this.lEmployee.AutoSize = true;
            this.lEmployee.Location = new System.Drawing.Point(6, 151);
            this.lEmployee.Name = "lEmployee";
            this.lEmployee.Size = new System.Drawing.Size(60, 13);
            this.lEmployee.TabIndex = 8;
            this.lEmployee.Text = "Сотрудник";
            // 
            // lNumber
            // 
            this.lNumber.AutoSize = true;
            this.lNumber.Location = new System.Drawing.Point(6, 96);
            this.lNumber.Name = "lNumber";
            this.lNumber.Size = new System.Drawing.Size(93, 13);
            this.lNumber.TabIndex = 7;
            this.lNumber.Text = "Серийный номер";
            // 
            // lClient
            // 
            this.lClient.AutoSize = true;
            this.lClient.Location = new System.Drawing.Point(6, 125);
            this.lClient.Name = "lClient";
            this.lClient.Size = new System.Drawing.Size(43, 13);
            this.lClient.TabIndex = 6;
            this.lClient.Text = "Клиент";
            // 
            // cbManufactor
            // 
            this.cbManufactor.FormattingEnabled = true;
            this.cbManufactor.Location = new System.Drawing.Point(132, 40);
            this.cbManufactor.Name = "cbManufactor";
            this.cbManufactor.Size = new System.Drawing.Size(139, 21);
            this.cbManufactor.TabIndex = 5;
            // 
            // cbVendor
            // 
            this.cbVendor.FormattingEnabled = true;
            this.cbVendor.Location = new System.Drawing.Point(132, 173);
            this.cbVendor.Name = "cbVendor";
            this.cbVendor.Size = new System.Drawing.Size(139, 21);
            this.cbVendor.TabIndex = 5;
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(132, 146);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(139, 21);
            this.cbEmployee.TabIndex = 5;
            // 
            // cbClient
            // 
            this.cbClient.FormattingEnabled = true;
            this.cbClient.Location = new System.Drawing.Point(132, 119);
            this.cbClient.Name = "cbClient";
            this.cbClient.Size = new System.Drawing.Size(139, 21);
            this.cbClient.TabIndex = 5;
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(132, 13);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(139, 21);
            this.cbCategory.TabIndex = 5;
            // 
            // nTotalSendPrice
            // 
            this.nTotalSendPrice.DecimalPlaces = 2;
            this.nTotalSendPrice.Location = new System.Drawing.Point(447, 174);
            this.nTotalSendPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nTotalSendPrice.Name = "nTotalSendPrice";
            this.nTotalSendPrice.Size = new System.Drawing.Size(107, 20);
            this.nTotalSendPrice.TabIndex = 4;
            // 
            // nTotalReceivePrice
            // 
            this.nTotalReceivePrice.DecimalPlaces = 2;
            this.nTotalReceivePrice.Location = new System.Drawing.Point(447, 147);
            this.nTotalReceivePrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nTotalReceivePrice.Name = "nTotalReceivePrice";
            this.nTotalReceivePrice.Size = new System.Drawing.Size(107, 20);
            this.nTotalReceivePrice.TabIndex = 4;
            // 
            // nReserveCount
            // 
            this.nReserveCount.Location = new System.Drawing.Point(453, 123);
            this.nReserveCount.Name = "nReserveCount";
            this.nReserveCount.Size = new System.Drawing.Size(101, 20);
            this.nReserveCount.TabIndex = 4;
            // 
            // nSendCount
            // 
            this.nSendCount.Location = new System.Drawing.Point(453, 94);
            this.nSendCount.Name = "nSendCount";
            this.nSendCount.Size = new System.Drawing.Size(101, 20);
            this.nSendCount.TabIndex = 4;
            // 
            // nReceiveCount
            // 
            this.nReceiveCount.Location = new System.Drawing.Point(453, 68);
            this.nReceiveCount.Name = "nReceiveCount";
            this.nReceiveCount.Size = new System.Drawing.Size(101, 20);
            this.nReceiveCount.TabIndex = 4;
            // 
            // nPrice
            // 
            this.nPrice.DecimalPlaces = 2;
            this.nPrice.Location = new System.Drawing.Point(178, 67);
            this.nPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nPrice.Name = "nPrice";
            this.nPrice.Size = new System.Drawing.Size(93, 20);
            this.nPrice.TabIndex = 4;
            // 
            // dtpReceiveDate
            // 
            this.dtpReceiveDate.Location = new System.Drawing.Point(415, 19);
            this.dtpReceiveDate.Name = "dtpReceiveDate";
            this.dtpReceiveDate.Size = new System.Drawing.Size(139, 20);
            this.dtpReceiveDate.TabIndex = 3;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(132, 93);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(139, 20);
            this.tbNumber.TabIndex = 2;
            // 
            // lManufactor
            // 
            this.lManufactor.AutoSize = true;
            this.lManufactor.Location = new System.Drawing.Point(6, 43);
            this.lManufactor.Name = "lManufactor";
            this.lManufactor.Size = new System.Drawing.Size(124, 13);
            this.lManufactor.TabIndex = 1;
            this.lManufactor.Text = "Фирма производитель";
            // 
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.Location = new System.Drawing.Point(6, 16);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(98, 13);
            this.lCategory.TabIndex = 1;
            this.lCategory.Text = "Категория товара";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 465);
            this.Controls.Add(this.gbAddEdit);
            this.Controls.Add(this.gvCatalog);
            this.Controls.Add(this.mainToolStrip);
            this.Name = "MainForm";
            this.Text = "Каталог";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvCatalog)).EndInit();
            this.gbAddEdit.ResumeLayout(false);
            this.gbAddEdit.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nTotalSendPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nTotalReceivePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nReserveCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSendCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nReceiveCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.DataGridView gvCatalog;
        private System.Windows.Forms.ToolStripButton tsbEmployees;
        private System.Windows.Forms.ToolStripButton tsbVendors;
        private System.Windows.Forms.ToolStripButton tsbClients;
        private System.Windows.Forms.ToolStripSplitButton tssbReports;
        private System.Windows.Forms.GroupBox gbAddEdit;
        private System.Windows.Forms.ComboBox cbManufactor;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.NumericUpDown nPrice;
        private System.Windows.Forms.DateTimePicker dtpReceiveDate;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label lManufactor;
        private System.Windows.Forms.Label lCategory;
        private System.Windows.Forms.Button bAddEdit;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.Label lReceiveDate;
        private System.Windows.Forms.Label lVendor;
        private System.Windows.Forms.Label lEmployee;
        private System.Windows.Forms.Label lNumber;
        private System.Windows.Forms.Label lClient;
        private System.Windows.Forms.ComboBox cbVendor;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.ComboBox cbClient;
        private System.Windows.Forms.Label lTotalSendPrice;
        private System.Windows.Forms.Label lSendDate;
        private System.Windows.Forms.Label lReceiveCount;
        private System.Windows.Forms.Label lSendCount;
        private System.Windows.Forms.Label lTotalReceivePrice;
        private System.Windows.Forms.Label lReserveCount;
        private System.Windows.Forms.DateTimePicker dtpSendDate;
        private System.Windows.Forms.NumericUpDown nTotalSendPrice;
        private System.Windows.Forms.NumericUpDown nTotalReceivePrice;
        private System.Windows.Forms.NumericUpDown nReserveCount;
        private System.Windows.Forms.NumericUpDown nSendCount;
        private System.Windows.Forms.NumericUpDown nReceiveCount;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufactor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiveCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReserveCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalReceivePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSendPrice;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

