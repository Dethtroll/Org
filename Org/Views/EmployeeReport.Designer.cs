namespace Org.Views
{
    partial class EmployeeReport
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
            this.bExport = new System.Windows.Forms.Button();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.lEmployee = new System.Windows.Forms.Label();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.cIsExport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cName = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(575, 277);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(75, 23);
            this.bExport.TabIndex = 0;
            this.bExport.Text = "Построить";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(95, 12);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(175, 21);
            this.cbEmployee.TabIndex = 1;
            this.cbEmployee.SelectedIndexChanged += new System.EventHandler(this.cbEmployee_SelectedIndexChanged);
            // 
            // lEmployee
            // 
            this.lEmployee.AutoSize = true;
            this.lEmployee.Location = new System.Drawing.Point(12, 15);
            this.lEmployee.Name = "lEmployee";
            this.lEmployee.Size = new System.Drawing.Size(60, 13);
            this.lEmployee.TabIndex = 3;
            this.lEmployee.Text = "Сотрудник";
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIsExport,
            this.cName,
            this.cNumber,
            this.cCount});
            this.dgvProducts.Location = new System.Drawing.Point(12, 39);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(638, 232);
            this.dgvProducts.TabIndex = 4;
            // 
            // cIsExport
            // 
            this.cIsExport.HeaderText = "";
            this.cIsExport.Name = "cIsExport";
            // 
            // cName
            // 
            this.cName.HeaderText = "Название";
            this.cName.Name = "cName";
            // 
            // cNumber
            // 
            this.cNumber.HeaderText = "Номер";
            this.cNumber.Name = "cNumber";
            // 
            // cCount
            // 
            this.cCount.HeaderText = "Количество";
            this.cCount.Name = "cCount";
            // 
            // EmployeeReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 312);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.lEmployee);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.bExport);
            this.Name = "EmployeeReport";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.EmployeeReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bExport;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.Label lEmployee;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cIsExport;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCount;
    }
}