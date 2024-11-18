using System;
using System.Collections.Generic;

namespace Entities.Concrete.Northwind;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
