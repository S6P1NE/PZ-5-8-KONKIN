using PZ6.Models;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace PZ6
{
    public partial class ProductCard : UserControl
    {
        private Product currentProduct;

        public event EventHandler<Product> EditClicked;
        public event EventHandler<Product> DeleteClicked;

        public ProductCard()
        {
            InitializeComponent();
            this.BorderStyle = BorderStyle.FixedSingle;
           
        }

        public void SetProduct(Product product, BindingSource categorySource)
        {
            currentProduct = product;

           
            lblName.Text = product.IdProductNameNavigation?.ProductName1 ?? "Без названия";
            lblPrice.Text = $"{product.Price} ";
            lblArt.Text = $"Арт: {product.Article}";
            lblCategory.Text = product.IdCategoryNavigation?.CategoryName ?? "Без категории";

          
            if (!string.IsNullOrEmpty(product.Photo) && System.IO.File.Exists(product.Photo))
            {
                pbPhoto.ImageLocation = product.Photo;
            }

          
            btnEdit.Tag = product;
            btnDelete.Tag = product;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke(this, currentProduct);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke(this, currentProduct);
        }
    }
}