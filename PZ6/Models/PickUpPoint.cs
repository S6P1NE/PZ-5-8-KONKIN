using System;
using System.Collections.Generic;

namespace PZ6.Models;

public partial class PickUpPoint
{
    public int IdPickUpPoint { get; set; }

    public string? Adress { get; set; }

    public string Index { get; set; } = null!;

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();
}
