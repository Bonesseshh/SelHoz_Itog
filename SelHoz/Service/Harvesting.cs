using System;
using System.Collections.Generic;

namespace SelHoz;

public partial class Harvesting
{
    public int IdHarvest { get; set; }

    public DateOnly CollectionDate { get; set; }

    public double HarvestedAmount { get; set; }

    public virtual ICollection<Farming> Farmings { get; set; } = new List<Farming>();
}
