using System;
using System.Collections.Generic;

namespace PZ6.Models;

public partial class ProductName
{
    public int IdProductName { get; set; }

    public string ProductName1 { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
