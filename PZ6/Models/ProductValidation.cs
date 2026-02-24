using Microsoft.EntityFrameworkCore;
using PZ6.Models;
using System.ComponentModel;
using System.Windows.Forms;

namespace PZ6.Models
{
    public partial class Product : IEditableObject
    {
        private Ispr2522KonkinMaLazarevPzContext _context;
        private Product _backup;
        private bool _inEdit = false;

        void IEditableObject.BeginEdit()
        {
            if (_inEdit) return;

         
            _backup = new Product
            {
                IdProduct = this.IdProduct,
                Article = this.Article,
                Price = this.Price,
                Count = this.Count,
                Discount = this.Discount,
                Description = this.Description,
                Photo = this.Photo,
                Unit = this.Unit,
                IdCategory = this.IdCategory,
                IdManufacturer = this.IdManufacturer,
                IdProductName = this.IdProductName,
                IdSupplier = this.IdSupplier
            };

           
            _context = new Ispr2522KonkinMaLazarevPzContext();
            _context.Update(this);

            _inEdit = true;
        }

        void IEditableObject.CancelEdit()
        {
            if (!_inEdit) return;

            
            if (_backup != null)
            {
                this.IdProduct = _backup.IdProduct;
                this.Article = _backup.Article;
                this.Price = _backup.Price;
                this.Count = _backup.Count;
                this.Discount = _backup.Discount;
                this.Description = _backup.Description;
                this.Photo = _backup.Photo;
                this.Unit = _backup.Unit;
                this.IdCategory = _backup.IdCategory;
                this.IdManufacturer = _backup.IdManufacturer;
                this.IdProductName = _backup.IdProductName;
                this.IdSupplier = _backup.IdSupplier;
            }

           
            if (_context != null && this.IdProduct != 0)
            {
                _context.Entry(this).Reload();
            }

            _inEdit = false;
            _backup = null;
            _context = null;
        }

        void IEditableObject.EndEdit()
        {
            if (!_inEdit) return;

         
            if (string.IsNullOrWhiteSpace(this.Article))
            {
                MessageBox.Show("Артикул не может быть пустым!", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ((IEditableObject)this).CancelEdit();
                throw new ValidationException("Артикул не может быть пустым");
            }

            if (this.Price < 0)
            {
                MessageBox.Show("Цена не может быть отрицательной!", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ((IEditableObject)this).CancelEdit();
                throw new ValidationException("Цена не может быть отрицательной");
            }

            if (this.Count < 0)
            {
                MessageBox.Show("Количество не может быть отрицательным!", "Ошибка валидации",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                ((IEditableObject)this).CancelEdit();
                throw new ValidationException("Количество не может быть отрицательным");
            }

            
            if (_context != null && this.IdProduct != 0)
            {
                var exists = _context.Products
                    .Any(p => p.Article == this.Article && p.IdProduct != this.IdProduct);

                if (exists)
                {
                    MessageBox.Show($"Товар с артикулом '{this.Article}' уже существует!",
                        "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ((IEditableObject)this).CancelEdit();
                    throw new ValidationException("Артикул должен быть уникальным");
                }
            }

            _inEdit = false;
            _backup = null;
            _context = null;
        }
    }

    
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) { }
    }
}