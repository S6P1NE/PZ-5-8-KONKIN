using System;
using System.Collections.Generic;

namespace PZ6.Models;

public partial class Delivery
{
    public int IdDelivery { get; set; }

    public DateTime DateOrder { get; set; }

    public DateTime DateDelivery { get; set; }

    public int IdPickUpPoint { get; set; }

    public int IdUser { get; set; }

    public int Code { get; set; }

    public int IdStatus { get; set; }

    public virtual PickUpPoint IdPickUpPointNavigation { get; set; } = null!;

    public virtual Status IdStatusNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;

    public virtual ICollection<OrdersProduct> OrdersProducts { get; set; } = new List<OrdersProduct>();
}
