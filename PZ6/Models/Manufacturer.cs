using System;
using System.Collections.Generic;

namespace PZ6.Models;

public partial class Manufacturer
{
    public int IdManufacturer { get; set; }

    public string ManufacturerName { get; set; } = null!;

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
