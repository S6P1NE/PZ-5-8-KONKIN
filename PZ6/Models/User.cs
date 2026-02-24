using System;
using System.Collections.Generic;

namespace PZ6.Models;

public partial class User
{
    public int IdUser { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int IdRole { get; set; }

    public virtual ICollection<Delivery> Deliveries { get; set; } = new List<Delivery>();

    public virtual Role IdRoleNavigation { get; set; } = null!;

    public virtual ICollection<Name> Names { get; set; } = new List<Name>();
}
