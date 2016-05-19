using Org.Common.Repositories;
using Org.Common.Services;
using Org.Common.Views;
using Org.Pes;
using Org.Presenters;
using Org.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Org.Views
{
    public partial class ProductCategoriesForm : Form, IDictionayView
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

        public Action AddItem { get; set; }
        public Action<DicEditPe> AddRequested { get; set; }
        public Action CancelRequested { get; set; }
        public Action<int> EditRequested { get; set; }
        public Action<int> DeleteRequested { get; set; }
        public Action Loaded { get; set; }
        public Action<DicEditPe> UpdateRequested { get; set; }

        public ProductCategoriesForm(OrgContext context, IUpdateService updateService)
        {
            InitializeComponent();

            new ProductCategoriesPresenter(this, new ProductCategoryRepository(context, updateService));
        }

        public void InitDic(IEnumerable<DicIndexPe> items)
        {
            lbItems.Items.Clear();
            foreach (var item in items)
            {
                AddDicItem(item);
            }
        }

        public void ShowItem(DicEditPe pe)
        {
            tbName.Text = pe.Name;
        }

        public void ShowEmptyItem()
        {
            tbName.Text = "";
        }

        private void AddDicItem(DicIndexPe pe)
        {
            lbItems.Items.Add(pe);
        }

        private void ManufactorsForm_Load(object sender, EventArgs e)
        {
            Loaded();
        }

        private void bAddSave_Click(object sender, EventArgs e)
        {
            var pe = new DicEditPe
            {
                Name = tbName.Text,
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

        private void bCancel_Click(object sender, EventArgs e)
        {
            EditMode = false;
            CancelRequested();
        }

        private void lbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbItems.SelectedIndex >= 0)
            {
                var row = ((DicIndexPe)lbItems.SelectedItem).Id;

                EditRequested(row);
                bAddSave.Tag = row;
                EditMode = true;
            }
        }

        private void lbItems_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var row = ((DicIndexPe)lbItems.SelectedItem).Id;
                DeleteRequested(row);
                if (bAddSave.Tag != null && row == (int)bAddSave.Tag)
                {
                    EditMode = false;
                }
            }
        }
    }
}
