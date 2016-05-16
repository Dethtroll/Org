using Org.Common.Repositories;
using Org.Common.Services;
using Org.Common.Views;
using Org.Pes;
using Org.Presenters;
using Org.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Org.Views
{
    public partial class VendorsForm : Form, ICompaniesView
    {
        protected bool _editMode = false;
        public bool EditMode
        {
            get { return _editMode; }
            set
            {
                bAddSave.Text = value ? "Сохранить" : "Добавить";
                bCancel.Visible = value;
                _editMode = value;
            }
        }

        public Action AddCompany { get; set; }
        public Action<CompanyEditPe> AddRequested { get; set; }
        public Action CancelRequested { get; set; }
        public Action<int> EditRequested { get; set; }
        public Action<int> DeleteRequested { get; set; }
        public Action Loaded { get; set; }
        public Action<CompanyEditPe> UpdateRequested { get; set; }

        public VendorsForm(OrgContext context, IUpdateService updateService)
        {
            InitializeComponent();

            new VendorFormPresenter(this, new VendorRepository(context, updateService));
        }

        public void InitCompanies(IEnumerable<CompanyIndexPe> employees)
        {
            dgvCompanies.Rows.Clear();
            foreach (var employee in employees)
            {
                AddCompanyRow(employee);
            }
        }

        public void ShowCompany(CompanyEditPe pe)
        {
            tbName.Text = pe.Name;
            tbAddress.Text = pe.Address;
            tbPhone.Text = pe.Phone;
        }

        public void ShowEmptyCompany()
        {
            tbName.Text = "";
            tbAddress.Text = "";
            tbPhone.Text = "";
        }

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            Loaded();
        }

        protected void AddCompanyRow(CompanyIndexPe employee)
        {
            var row = new DataGridViewRow { Tag = employee.Id };
            row.Cells.Add(new DataGridViewTextBoxCell { Value = employee.Name });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = employee.Address });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = employee.Phone });

            dgvCompanies.Rows.Add(row);
        }

        private void bAddSave_Click(object sender, EventArgs e)
        {
            var pe = new CompanyEditPe
            {
                Name = tbName.Text,
                Address = tbAddress.Text,
                Phone = tbPhone.Text,
            };

            if (EditMode)
            {
                pe.Id = (int)bAddSave.Tag;
                UpdateRequested(pe);

                EditMode = false;
            }
            else
            {
                AddRequested(pe);
            }
        }

        private void dgCompanies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = (int)dgvCompanies.Rows[e.RowIndex].Tag;

                EditRequested(row);
                bAddSave.Tag = row;
                EditMode = true;
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            EditMode = false;
            CancelRequested();
        }

        private void dgvCompanies_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            var row = (int)e.Row.Tag;
            DeleteRequested(row);
            if (bAddSave.Tag != null && row == (int)bAddSave.Tag)
            {
                EditMode = false;
            }
        }
    }
}
