using System;
using System.Collections.Generic;

namespace PZ6.Models;

public partial class Product
{
    public int IdProduct { get; set; }

   
    public string? Article { get; set; }

    public int IdProductName { get; set; }

    
    public string? Unit { get; set; }

    public decimal Price { get; set; }

    public int IdSupplier { get; set; }

    public int IdManufacturer { get; set; }

    public int IdCategory { get; set; }

    public int Discount { get; set; }

    public int Count { get; set; }

    public string? Description { get; set; }

   
    public string? Photo { get; set; }

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual Manufacturer IdManufacturerNavigation { get; set; } = null!;

    public virtual ProductName IdProductNameNavigation { get; set; } = null!;

    public virtual Supplier IdSupplierNavigation { get; set; } = null!;

    public virtual ICollection<OrdersProduct> OrdersProducts { get; set; } = new List<OrdersProduct>();
}