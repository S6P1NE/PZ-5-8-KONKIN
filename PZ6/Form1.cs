using Microsoft.EntityFrameworkCore;
using PZ6.Models;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace PZ6
{
    public partial class Form1 : Form
    {
        private Ispr2522KonkinMaLazarevPzContext context;

        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
      
            context = new Ispr2522KonkinMaLazarevPzContext();

         
            context.Products
                .Include(p => p.IdCategoryNavigation)
                .Include(p => p.IdProductNameNavigation)
                .Include(p => p.IdManufacturerNavigation)
                .Include(p => p.IdSupplierNavigation)
                .Load();

            context.Categories.Load();
            context.Manufacturers.Load();
            context.ProductNames.Load();
            context.Suppliers.Load();

           
            productBindingSource.DataSource = context.Products.Local.ToBindingList();
            categoryBindingSource.DataSource = context.Categories.Local.ToBindingList();

            
            PopulateCards();
        }

        private void PopulateCards()
        {
            flowLayoutPanelProducts.Controls.Clear();

            foreach (Product product in productBindingSource)
            {
                var card = new ProductCard();
                card.SetProduct(product, categoryBindingSource);
                card.EditClicked += Card_EditClicked;
                card.DeleteClicked += Card_DeleteClicked;
                flowLayoutPanelProducts.Controls.Add(card);
            }
        }

        private void Card_EditClicked(object sender, Product e)
        {
            if (e == null) return;

            var editForm = new ProductEditForm();

            var categories = new BindingSource
            {
                DataSource = context.Categories.Local.ToBindingList()
            };
            var manufacturers = new BindingSource
            {
                DataSource = context.Manufacturers.Local.ToBindingList()
            };
            var productNames = new BindingSource
            {
                DataSource = context.ProductNames.Local.ToBindingList()
            };
            var suppliers = new BindingSource
            {
                DataSource = context.Suppliers.Local.ToBindingList()
            };

            editForm.LoadProduct(e, categories, manufacturers, productNames, suppliers);

            var result = editForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    
                    ((IEditableObject)e).EndEdit();

                    context.SaveChanges();
                    productBindingSource.ResetBindings(false);
                    PopulateCards();

                    MessageBox.Show("Товар обновлён!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ValidationException)
                {
                    
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ((IEditableObject)e).CancelEdit();
                }
            }
            else
            {
             
                ((IEditableObject)e).CancelEdit();
            }
        }

        private void Card_DeleteClicked(object sender, Product e)
        {
            if (e == null) return;

            
            var hasOrders = context.OrdersProducts.Any(op => op.IdProduct == e.IdProduct);
            if (hasOrders)
            {
                MessageBox.Show("Нельзя удалить товар с активными заказами!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                $"Удалить товар \"{e.IdProductNameNavigation?.ProductName1 ?? e.Article}\"?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    context.Products.Remove(e);
                    context.SaveChanges();
                    productBindingSource.ResetBindings(false);
                    PopulateCards();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка удаления: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            var firstName = context.ProductNames.FirstOrDefault();
            var firstCategory = context.Categories.FirstOrDefault();
            var firstManufacturer = context.Manufacturers.FirstOrDefault();
            var firstSupplier = context.Suppliers.FirstOrDefault();

            var newProduct = new Product
            {
                Article = "NEW-" + Guid.NewGuid().ToString().Substring(0, 6),
                Price = 0,
                Unit = "₽",
                Count = 0,
                Discount = 0,
                Description = "",
                Photo = "",
                IdProductName = firstName?.IdProductName ?? 0,
                IdCategory = firstCategory?.IdCategory ?? 0,
                IdManufacturer = firstManufacturer?.IdManufacturer ?? 0,
                IdSupplier = firstSupplier?.IdSupplier ?? 0
            };

            var editForm = new ProductEditForm();

            var categories = new BindingSource
            {
                DataSource = context.Categories.Local.ToBindingList()
            };
            var manufacturers = new BindingSource
            {
                DataSource = context.Manufacturers.Local.ToBindingList()
            };
            var productNames = new BindingSource
            {
                DataSource = context.ProductNames.Local.ToBindingList()
            };
            var suppliers = new BindingSource
            {
                DataSource = context.Suppliers.Local.ToBindingList()
            };

            editForm.LoadProduct(newProduct, categories, manufacturers, productNames, suppliers);

            var result = editForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    
                    ((IEditableObject)newProduct).EndEdit();

                    context.Products.Add(newProduct);
                    context.SaveChanges();

                    productBindingSource.ResetBindings(false);
                    PopulateCards();

                    MessageBox.Show("Товар добавлен!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ValidationException)
                {
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка добавления: {ex.Message}", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ((IEditableObject)newProduct).CancelEdit();
                }
            }
            else
            {
                ((IEditableObject)newProduct).CancelEdit();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
                productBindingSource.ResetBindings(false);
                PopulateCards();
                MessageBox.Show("Изменения сохранены!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}