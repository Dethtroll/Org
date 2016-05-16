namespace Org.Views
{
    partial class ClinetsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAddSave = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lPhone = new System.Windows.Forms.Label();
            this.lAddress = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.dgvCompanies = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lPhone);
            this.groupBox1.Controls.Add(this.lAddress);
            this.groupBox1.Controls.Add(this.lName);
            this.groupBox1.Location = new System.Drawing.Point(427, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 157);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.bCancel);
            this.flowLayoutPanel1.Controls.Add(this.bAddSave);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(110, 121);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(178, 30);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(100, 3);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 0;
            this.bCancel.Text = "Отмена";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Visible = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAddSave
            // 
            this.bAddSave.Location = new System.Drawing.Point(19, 3);
            this.bAddSave.Name = "bAddSave";
            this.bAddSave.Size = new System.Drawing.Size(75, 23);
            this.bAddSave.TabIndex = 1;
            this.bAddSave.Text = "Добавить";
            this.bAddSave.UseVisualStyleBackColor = true;
            this.bAddSave.Click += new System.EventHandler(this.bAddSave_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(79, 68);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(206, 20);
            this.tbPhone.TabIndex = 5;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(79, 42);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(206, 20);
            this.tbAddress.TabIndex = 4;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(79, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(206, 20);
            this.tbName.TabIndex = 3;
            // 
            // lPhone
            // 
            this.lPhone.AutoSize = true;
            this.lPhone.Location = new System.Drawing.Point(13, 71);
            this.lPhone.Name = "lPhone";
            this.lPhone.Size = new System.Drawing.Size(52, 13);
            this.lPhone.TabIndex = 2;
            this.lPhone.Text = "Телефон";
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(13, 45);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(38, 13);
            this.lAddress.TabIndex = 1;
            this.lAddress.Text = "Адрес";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(13, 19);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(57, 13);
            this.lName.TabIndex = 0;
            this.lName.Text = "Название";
            // 
            // dgvCompanies
            // 
            this.dgvCompanies.AllowUserToAddRows = false;
            this.dgvCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompanies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Address,
            this.Phone});
            this.dgvCompanies.Location = new System.Drawing.Point(12, 12);
            this.dgvCompanies.Name = "dgvCompanies";
            this.dgvCompanies.ReadOnly = true;
            this.dgvCompanies.Size = new System.Drawing.Size(409, 320);
            this.dgvCompanies.TabIndex = 3;
            this.dgvCompanies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCompanies_CellClick);
            this.dgvCompanies.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvCompanies_UserDeletedRow);
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Название";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Телефон";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // ClinetsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 344);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvCompanies);
            this.Name = "ClinetsForm";
            this.Text = "ClinetsForm";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompanies)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAddSave;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lPhone;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.DataGridView dgvCompanies;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
    }
}