using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Org.Common.Repositories;
using Org.Common.Services;
using Org.Common.Views;
using Org.Pes;
using Org.Presenters;
using Org.Repositories;
using Org.Services;

namespace Org.Views
{
    public partial class EmployeeReport : Form, IEmployeeReportView
    {
        public Action Loaded { get; set; }
        public Action<int> LoadProducts { get; set; }
        public Action<int, IEnumerable<int>, string> ExportRequested { get; set; }

        public EmployeeReport(OrgContext context, IUpdateService updateService)
        {
            InitializeComponent();

            new EmployeeReportPresenter(this, new EmployeeRepository(context, updateService), new EmployeeProductsReportGenerator());
        }

        public void InitEmployees(IEnumerable<DicIndexPe> employees)
        {
            cbEmployee.Items.Clear();
            foreach (var employee in employees)
            {
                cbEmployee.Items.Add(employee);
            }
        }

        public void InitProducts(IEnumerable<ProductIntexPe> products)
        {
            dgvProducts.Rows.Clear();
            foreach (var product in products)
            {
                AddProductRow(product);
            }
        }

        protected void AddProductRow(ProductIntexPe product)
        {
            var row = new DataGridViewRow { Tag = product.Id };
            row.Cells.Add(new DataGridViewCheckBoxCell { Value = true });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = product.Category });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = product.Number });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = "1" });

            dgvProducts.Rows.Add(row);
        }

        private void EmployeeReport_Load(object sender, EventArgs e)
        {
            Loaded();
        }

        private void cbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            var employeeId = ((DicIndexPe)cbEmployee.SelectedItem).Id;
            LoadProducts(employeeId);
        }

        private void bExport_Click(object sender, EventArgs e)
        {
            var employeeId = ((DicIndexPe) cbEmployee.SelectedItem)?.Id;
            if (!employeeId.HasValue) return;

            var productIds = new List<int>();
            foreach (DataGridViewRow row in dgvProducts.Rows)
            {
                var isChecked = (bool)row.Cells[0].Value;
                if (isChecked)
                {
                    productIds.Add((int)row.Tag);
                }
            }

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = "Word.docx";
            savefile.Filter = "Text files (*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                ExportRequested(employeeId.Value, productIds, savefile.FileName);
            }

            MessageBox.Show(this, "Готово", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
