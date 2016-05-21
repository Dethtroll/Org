namespace Org.Views
{
    partial class ProductCategoriesForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lbItems = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.lName);
            this.groupBox1.Location = new System.Drawing.Point(403, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 83);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.bCancel);
            this.flowLayoutPanel1.Controls.Add(this.bAddSave);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(110, 47);
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
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(79, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(206, 20);
            this.tbName.TabIndex = 3;
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
            // lbItems
            // 
            this.lbItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbItems.FormattingEnabled = true;
            this.lbItems.Location = new System.Drawing.Point(12, 12);
            this.lbItems.Name = "lbItems";
            this.lbItems.Size = new System.Drawing.Size(385, 238);
            this.lbItems.TabIndex = 7;
            this.lbItems.SelectedIndexChanged += new System.EventHandler(this.lbItems_SelectedIndexChanged);
            this.lbItems.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lbItems_KeyUp);
            // 
            // ProductCategoriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 263);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbItems);
            this.Name = "ProductCategoriesForm";
            this.Text = "Категории техники";
            this.Load += new System.EventHandler(this.ManufactorsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAddSave;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.ListBox lbItems;
    }
}