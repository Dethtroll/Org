using Org.Common.Views;
using Org.Presenters;
using System.Windows.Forms;
using System;
using Org.Repositories;
using System.Collections.Generic;
using Org.Pes;
using Org.Common.Repositories;
using Org.Domain;
using Org.Views;
using Org.Common.Services;

namespace Org
{
    public partial class MainForm : Form, IMainView
    {
        protected readonly OrgContext _context;
        protected readonly IUpdateService _updateService;

        protected bool _editMode = false;

        public bool EditMode
        {
            get { return _editMode; }
            set
            {
                bAddEdit.Text = value ? "Сохранить" : "Добавить";
                bCancel.Visible = value;
                _editMode = value;
            }
        }

        public Action AddProduct { get; set; }
        public Action Loaded { get; set; }
        public Action<ProductEditPe> AddRequested { get; set; }
        public Action<ProductEditPe> UpdateRequested { get; set; }
        public Action<int> EditRequested { get; set; }
        public Action CancelRequested { get; set; }
                

        public MainForm(OrgContext context, IUpdateService updateService)
        {
            InitializeComponent();

            _context = context;
            _updateService = updateService;
            new MainFormPresenter(
                this, 

                _updateService,

                new ProductRepository(context, updateService),
                new ProductCategoryRepository(context, updateService),
                new ManufactorRepository(context, updateService),
                new VendorRepository(context, updateService),
                new ClientRepository(context, updateService),
                new EmployeeRepository(context, updateService)
            );
        }

        public void InitProducts(
            IEnumerable<ProductIntexPe> products,
            IEnumerable<DicIndexPe> categories,
            IEnumerable<DicIndexPe> manufactors, 
            IEnumerable<VendorIndexPe> vendors, 
            IEnumerable<ClientIndexPe> clients, 
            IEnumerable<EmployeeIndexPe> employess
            )
        {
            gvCatalog.Rows.Clear();
            foreach (var product in products)
            {
                AddProductRow(product);
            }

            InitCategories(categories);
            InitManufactors(manufactors);
            InitVendors(vendors);
            InitClients(clients);
            InitEmployees(employess);

            if (EditMode && bAddEdit.Tag != null)
            {
                EditRequested((int)bAddEdit.Tag);
            }
        }

        public void InitCategories(IEnumerable<DicIndexPe> categories)
        {
            cbCategory.Items.Clear();
            foreach (var category in categories)
            {
                cbCategory.Items.Add(category);
            }
        }

        public void InitManufactors(IEnumerable<DicIndexPe> manufactors)
        {
            cbManufactor.Items.Clear();
            foreach (var manufactor in manufactors)
            {
                cbManufactor.Items.Add(manufactor);
            }
        }

        public void InitVendors(IEnumerable<VendorIndexPe> vendors)
        {
            cbVendor.Items.Clear();
            foreach (var vendor in vendors)
            {
                cbVendor.Items.Add(vendor);
            }
        }

        public void InitClients(IEnumerable<ClientIndexPe> clients)
        {
            cbClient.Items.Clear();
            foreach (var client in clients)
            {
                cbClient.Items.Add(client);
            }
        }

        public void InitEmployees(IEnumerable<EmployeeIndexPe> employess)
        {
            cbEmployee.Items.Clear();
            foreach (var employee in employess)
            {
                cbEmployee.Items.Add(employee);
            }
        }


        protected void AddProductRow(ProductIntexPe product)
        {
            var row = new DataGridViewRow { Tag = product.Id };
            row.Cells.Add(new DataGridViewTextBoxCell { Value = product.Category });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = product.Manufactor });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = product.Price });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = product.Number });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = product.Vendor });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = product.Client });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = product.Employee });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = product.ReceiveDate });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = product.SendDate });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = product.ReceiveCount });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = product.SendCount });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = product.ReserveCount });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = product.TotalReceivePrice });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = product.TotalSendPrice });

            gvCatalog.Rows.Add(row);
        }

        public void ShowProduct(ProductEditPe pe)
        {
            cbCategory.SelectedIndex = cbCategory.Items.IndexOf(new DicIndexPe { Id = pe.Category });
            cbManufactor.SelectedIndex = cbManufactor.Items.IndexOf(new DicIndexPe { Id = pe.Manufactor });
            nPrice.Value = pe.Price;
            tbNumber.Text = pe.Number;
            cbVendor.SelectedIndex = cbVendor.Items.IndexOf(new VendorIndexPe { Id = pe.Vendor });
            cbClient.SelectedIndex = cbClient.Items.IndexOf(new ClientIndexPe { Id = pe.Client });
            cbEmployee.SelectedIndex = cbEmployee.Items.IndexOf(new EmployeeIndexPe { Id = pe.Employee });
            dtpReceiveDate.Value = pe.ReceiveDate;
            dtpSendDate.Value = pe.SendDate;
            nReceiveCount.Value = pe.ReceiveCount;
            nSendCount.Value = pe.SendCount;
            nReserveCount.Value = pe.ReserveCount;
            nTotalReceivePrice.Value = pe.TotalReceivePrice;
            nTotalSendPrice.Value = pe.TotalSendPrice;
            rtbDescription.Text = pe.Description;
        }

        public void ShowEmptyProduct()
        {
            cbCategory.SelectedIndex = 0;
            cbManufactor.SelectedIndex = 0;
            nPrice.Value = 0;
            tbNumber.Text = "0000";
            cbVendor.SelectedIndex = 0;
            cbClient.SelectedIndex = 0;
            cbEmployee.SelectedIndex = 0;
            dtpReceiveDate.Value = DateTime.Now;
            dtpSendDate.Value = DateTime.Now;
            nReceiveCount.Value = 0;
            nSendCount.Value = 0;
            nReserveCount.Value = 0;
            nTotalReceivePrice.Value = 0;
            nTotalSendPrice.Value = 0;
            rtbDescription.Text = string.Empty;
        }

        public void ShowEmployeesWindow()
        {
            var employeesForm = new EmployeesForm(_context, _updateService);

            employeesForm.ShowDialog(this);
        }

        public void ShowVendorsWindow()
        {
            var vendorsForm = new VendorsForm(_context, _updateService);

            vendorsForm.ShowDialog(this);
        }

        public void ShowClientsWindow()
        {
            var clientsForm = new ClinetsForm(_context, _updateService);

            clientsForm.ShowDialog(this);
        }

        public void ShowManufactorsWindows()
        {
            var manufactorsForm = new ManufactorsForm(_context, _updateService);

            manufactorsForm.ShowDialog(this);
        }

        public void ShowProductCategoriesWindows()
        {
            var form = new ProductCategoriesForm(_context, _updateService);

            form.ShowDialog(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Loaded();
        }

        private void bAddEdit_Click(object sender, EventArgs e)
        {

            if (cbCategory.SelectedItem == null ||
                cbManufactor.SelectedItem == null ||
                cbVendor.SelectedItem == null ||
                cbClient.SelectedItem == null ||
                cbEmployee.SelectedItem == null)
            {
                return;
            }

            var pe = new ProductEditPe
            {
                Category = ((DicIndexPe)cbCategory.SelectedItem).Id,
                Manufactor = ((DicIndexPe)cbManufactor.SelectedItem).Id,
                Price = nPrice.Value,
                Number = tbNumber.Text,
                Vendor = ((VendorIndexPe)cbVendor.SelectedItem).Id,
                Client = ((ClientIndexPe)cbClient.SelectedItem).Id,
                Employee = ((EmployeeIndexPe)cbEmployee.SelectedItem).Id,
                ReceiveDate = dtpReceiveDate.Value,
                SendDate = dtpSendDate.Value,
                ReceiveCount = (int)nReceiveCount.Value,
                SendCount = (int)nSendCount.Value,
                ReserveCount = (int)nReserveCount.Value,
                TotalReceivePrice = nTotalReceivePrice.Value,
                TotalSendPrice = nTotalSendPrice.Value,
                Description = rtbDescription.Text
            };

            if (EditMode)
            {
                pe.Id = (int)bAddEdit.Tag;
                UpdateRequested(pe);
                
                EditMode = false;
            }
            else
            {
                AddRequested(pe);
            }
        }

        private void gvCatalog_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = (int)gvCatalog.Rows[e.RowIndex].Tag;

                EditRequested(row);
                bAddEdit.Tag = row;
                EditMode = true;
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            EditMode = false;
            CancelRequested();
        }

        private void tsbEmployees_Click(object sender, EventArgs e)
        {
            ShowEmployeesWindow();
        }

        private void tsbVendors_Click(object sender, EventArgs e)
        {
            ShowVendorsWindow();
        }

        private void tsbClients_Click(object sender, EventArgs e)
        {
            ShowClientsWindow();
        }

        private void tsManufactors_Click(object sender, EventArgs e)
        {
            ShowManufactorsWindows();
        }

        private void tsProductCategories_Click(object sender, EventArgs e)
        {
            ShowProductCategoriesWindows();
        }
    }
}
