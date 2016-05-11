namespace Org.Views
{
    partial class EmployeesForm
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
            this.dgEmployees = new System.Windows.Forms.DataGridView();
            this.Fio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstWorkDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAddSave = new System.Windows.Forms.Button();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.dtpFirstWorkDay = new System.Windows.Forms.DateTimePicker();
            this.dtpBirthDay = new System.Windows.Forms.DateTimePicker();
            this.cbDegree = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lPhone = new System.Windows.Forms.Label();
            this.lAddress = new System.Windows.Forms.Label();
            this.lMiddleName = new System.Windows.Forms.Label();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lFirstWorkDay = new System.Windows.Forms.Label();
            this.lBirthDay = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgEmployees
            // 
            this.dgEmployees.AllowUserToAddRows = false;
            this.dgEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fio,
            this.Address,
            this.Phone,
            this.Birthday,
            this.FirstWorkDay,
            this.Position,
            this.Degree});
            this.dgEmployees.Location = new System.Drawing.Point(13, 13);
            this.dgEmployees.Name = "dgEmployees";
            this.dgEmployees.ReadOnly = true;
            this.dgEmployees.Size = new System.Drawing.Size(292, 237);
            this.dgEmployees.TabIndex = 0;
            this.dgEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmployees_CellClick);
            // 
            // Fio
            // 
            this.Fio.HeaderText = "Ф. И. О.";
            this.Fio.Name = "Fio";
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            // 
            // Birthday
            // 
            this.Birthday.HeaderText = "Дата рождения";
            this.Birthday.Name = "Birthday";
            // 
            // FirstWorkDay
            // 
            this.FirstWorkDay.HeaderText = "Дата найма";
            this.FirstWorkDay.Name = "FirstWorkDay";
            // 
            // Position
            // 
            this.Position.HeaderText = "Должность";
            this.Position.Name = "Position";
            // 
            // Degree
            // 
            this.Degree.HeaderText = "Образование";
            this.Degree.Name = "Degree";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbPosition);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.tbMiddleName);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.dtpFirstWorkDay);
            this.groupBox1.Controls.Add(this.dtpBirthDay);
            this.groupBox1.Controls.Add(this.cbDegree);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lPhone);
            this.groupBox1.Controls.Add(this.lAddress);
            this.groupBox1.Controls.Add(this.lMiddleName);
            this.groupBox1.Controls.Add(this.lFirstName);
            this.groupBox1.Controls.Add(this.lFirstWorkDay);
            this.groupBox1.Controls.Add(this.lBirthDay);
            this.groupBox1.Controls.Add(this.lLastName);
            this.groupBox1.Location = new System.Drawing.Point(311, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 247);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bCancel);
            this.flowLayoutPanel1.Controls.Add(this.bAddSave);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(200, 212);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 29);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(122, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAddSave
            // 
            this.bAddSave.Location = new System.Drawing.Point(41, 3);
            this.bAddSave.Name = "bAddSave";
            this.bAddSave.Size = new System.Drawing.Size(75, 23);
            this.bAddSave.TabIndex = 4;
            this.bAddSave.Text = "Добавить";
            this.bAddSave.UseVisualStyleBackColor = true;
            this.bAddSave.Click += new System.EventHandler(this.bAddSave_Click);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(84, 97);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(317, 20);
            this.tbAddress.TabIndex = 3;
            // 
            // tbPosition
            // 
            this.tbPosition.Location = new System.Drawing.Point(84, 149);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(167, 20);
            this.tbPosition.TabIndex = 3;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(84, 123);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(167, 20);
            this.tbPhone.TabIndex = 3;
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Location = new System.Drawing.Point(84, 71);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(107, 20);
            this.tbMiddleName.TabIndex = 3;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(84, 45);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(107, 20);
            this.tbFirstName.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(84, 19);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(107, 20);
            this.tbLastName.TabIndex = 3;
            // 
            // dtpFirstWorkDay
            // 
            this.dtpFirstWorkDay.Location = new System.Drawing.Point(291, 45);
            this.dtpFirstWorkDay.Name = "dtpFirstWorkDay";
            this.dtpFirstWorkDay.Size = new System.Drawing.Size(110, 20);
            this.dtpFirstWorkDay.TabIndex = 2;
            // 
            // dtpBirthDay
            // 
            this.dtpBirthDay.Location = new System.Drawing.Point(291, 19);
            this.dtpBirthDay.Name = "dtpBirthDay";
            this.dtpBirthDay.Size = new System.Drawing.Size(110, 20);
            this.dtpBirthDay.TabIndex = 2;
            // 
            // cbDegree
            // 
            this.cbDegree.FormattingEnabled = true;
            this.cbDegree.Items.AddRange(new object[] {
            "Нет",
            "Среднее",
            "Высшее"});
            this.cbDegree.Location = new System.Drawing.Point(84, 175);
            this.cbDegree.Name = "cbDegree";
            this.cbDegree.Size = new System.Drawing.Size(121, 21);
            this.cbDegree.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Образование";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Должность";
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(6, 126);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(52, 13);
            this.lPhone.TabIndex = 0;
            this.lPhone.Text = "Телефон";
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(6, 100);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(38, 13);
            this.lAddress.TabIndex = 0;
            this.lAddress.Text = "Адрес";
            // 
            // lMiddleName
            // 
            this.lMiddleName.AutoSize = true;
            this.lMiddleName.Location = new System.Drawing.Point(6, 74);
            this.lMiddleName.Name = "lMiddleName";
            this.lMiddleName.Size = new System.Drawing.Size(54, 13);
            this.lMiddleName.TabIndex = 0;
            this.lMiddleName.Text = "Отчество";
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(6, 48);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(29, 13);
            this.lFirstName.TabIndex = 0;
            this.lFirstName.Text = "Имя";
            // 
            // lFirstWorkDay
            // 
            this.lFirstWorkDay.AutoSize = true;
            this.lFirstWorkDay.Location = new System.Drawing.Point(197, 48);
            this.lFirstWorkDay.Name = "lFirstWorkDay";
            this.lFirstWorkDay.Size = new System.Drawing.Size(68, 13);
            this.lFirstWorkDay.TabIndex = 0;
            this.lFirstWorkDay.Text = "Дата найма";
            // 
            // lBirthDay
            // 
            this.lBirthDay.AutoSize = true;
            this.lBirthDay.Location = new System.Drawing.Point(197, 22);
            this.lBirthDay.Name = "lBirthDay";
            this.lBirthDay.Size = new System.Drawing.Size(86, 13);
            this.lBirthDay.TabIndex = 0;
            this.lBirthDay.Text = "Дата рождения";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(6, 22);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(56, 13);
            this.lLastName.TabIndex = 0;
            this.lLastName.Text = "Фамилия";
            // 
            // EmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgEmployees);
            this.Name = "EmployeesForm";
            this.Text = "EmployeesForm";
            this.Load += new System.EventHandler(this.EmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmployees)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEmployees;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstWorkDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Degree;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.DateTimePicker dtpBirthDay;
        private System.Windows.Forms.ComboBox cbDegree;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lMiddleName;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.DateTimePicker dtpFirstWorkDay;
        private System.Windows.Forms.Label lFirstWorkDay;
        private System.Windows.Forms.Label lBirthDay;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bAddSave;
    }
}