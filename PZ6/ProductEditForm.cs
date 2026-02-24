using PZ6.Models;
using System.Windows.Forms;

namespace PZ6
{
    public partial class ProductEditForm : Form
    {
        public ProductEditForm()
        {
            InitializeComponent();
        }

        public void LoadProduct(Product product,
                              BindingSource categories,
                              BindingSource manufacturers,
                              BindingSource productNames,
                              BindingSource suppliers)
        {
            
            editCategoryBindingSource.DataSource = categories;
            editManufacturerBindingSource.DataSource = manufacturers;
            editProductNameBindingSource.DataSource = productNames;
            editSupplierBindingSource.DataSource = suppliers;

            
            editProductBindingSource.DataSource = product;

            
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "IdCategory";

            
            cmbManufacturer.DataSource = manufacturers;
            cmbManufacturer.DisplayMember = "ManufacturerName";
            cmbManufacturer.ValueMember = "IdManufacturer";

            
            cmbProductName.DataSource = productNames;
            cmbProductName.DisplayMember = "ProductName1";
            cmbProductName.ValueMember = "IdProductName";

            
            cmbSupplier.DataSource = suppliers;
            cmbSupplier.DisplayMember = "SupplierName";
            cmbSupplier.ValueMember = "IdSupplier";

            this.Text = "Редактирование товара";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtArticle.Text))
            {
                MessageBox.Show("Артикул обязателен!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtArticle.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Цена должна быть числом!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            if (price < 0)
            {
                MessageBox.Show("Цена не может быть отрицательной!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}