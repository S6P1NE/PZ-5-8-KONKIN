using System;
using System.Collections.Generic;

namespace PZ6.Models;

public partial class Status
{
    public int IdStatus { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();
}
