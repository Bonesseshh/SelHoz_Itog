using System;
using System.Collections.Generic;

namespace SelHoz;

public partial class Technique
{
    public int IdTechnique { get; set; }

    public string NameTechnique { get; set; } = null!;

    public string? DescriptionTechnique { get; set; }

    public string Model { get; set; } = null!;

    public decimal? PriceTech { get; set; }

    public virtual ICollection<Farming> Farmings { get; set; } = new List<Farming>();

    public virtual ICollection<OrderingTechnique> OrderingTechniques { get; set; } = new List<OrderingTechnique>();
}
