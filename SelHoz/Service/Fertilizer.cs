using System;
using System.Collections.Generic;

namespace SelHoz;

public partial class Fertilizer
{
    public int IdFertilizer { get; set; }

    public string NameFertilizer { get; set; } = null!;

    public string? DescriptionFertilizer { get; set; }

    public string DateManufacture { get; set; } = null!;

    public string ExpirationDate { get; set; } = null!;

    public decimal PriceFert { get; set; }

    public virtual ICollection<Farming> Farmings { get; set; } = new List<Farming>();

    public virtual ICollection<OrderingFertilizer> OrderingFertilizers { get; set; } = new List<OrderingFertilizer>();
}
