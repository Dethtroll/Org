using Org.Common.Views;
using Org.Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Org.Pes;
using Org.Common.Repositories;
using Org.Repositories;

namespace Org.Views
{
    public partial class EmployeesForm : Form, IEmployeesView
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

        public Action AddProduct { get; set; }
        public Action<EmployeeEditPe> AddRequested { get; set; }
        public Action CancelRequested { get; set; }
        public Action<int> EditRequested { get; set; }
        public Action Loaded { get; set; }
        public Action<EmployeeEditPe> UpdateRequested { get; set; }

        public EmployeesForm(OrgContext context)
        {
            InitializeComponent();

            new EmployeesFormPresenter(this, new EmployeeRepository(context));
        }
        
        public void InitEmployees(IEnumerable<EmployeeIndexPe> employees)
        {
            dgEmployees.Rows.Clear();
            foreach (var employee in employees)
            {
                AddEmployeeRow(employee);
            }
        }

        public void ShowEmployee(EmployeeEditPe pe)
        {
            tbLastName.Text = pe.LastName;
            tbFirstName.Text = pe.FirstName;
            tbMiddleName.Text = pe.MiddleName;
            dtpBirthDay.Value = pe.BirthDay;
            dtpFirstWorkDay.Value = pe.FirstWorkDay;
            tbAddress.Text = pe.Address;
            tbPhone.Text = pe.Phone;
            cbDegree.Text = pe.Degree;
            tbPosition.Text = pe.Position;
        }

        public void ShowEmptyEmployee()
        {
            tbLastName.Text = "";
            tbFirstName.Text = "";
            tbMiddleName.Text = "";
            dtpBirthDay.Value = DateTime.Now.AddYears(-20);
            dtpFirstWorkDay.Value = DateTime.Now;
            tbAddress.Text = "";
            tbPhone.Text = "";
            cbDegree.SelectedIndex = 0;
            tbPosition.Text = "";
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            Loaded();
        }

        protected void AddEmployeeRow(EmployeeIndexPe employee)
        {
            var row = new DataGridViewRow { Tag = employee.Id };
            row.Cells.Add(new DataGridViewTextBoxCell { Value = employee.Name });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = employee.Address });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = employee.Phone });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = employee.BirthDay });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = employee.FirstWorkDay });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = employee.Position });
            row.Cells.Add(new DataGridViewTextBoxCell { Value = employee.Degree });

            dgEmployees.Rows.Add(row);
        }

        private void bAddSave_Click(object sender, EventArgs e)
        {
            var pe = new EmployeeEditPe
            {
                LastName = tbLastName.Text,
                FirstName = tbFirstName.Text,
                MiddleName = tbMiddleName.Text,
                Address = tbAddress.Text,
                Phone = tbPhone.Text,
                BirthDay = dtpBirthDay.Value,
                FirstWorkDay = dtpFirstWorkDay.Value,
                Position = tbPosition.Text,
                Degree = cbDegree.SelectedItem.ToString(),
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

        private void dgEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = (int)dgEmployees.Rows[e.RowIndex].Tag;

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
    }
}
