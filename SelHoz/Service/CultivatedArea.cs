using System;
using System.Collections.Generic;

namespace SelHoz;

public partial class CultivatedArea
{
    public int IdArea { get; set; }

    public string Area { get; set; } = null!;

    public string SowingDate { get; set; } = null!;

    public string HarvestDate { get; set; } = null!;

    public virtual ICollection<Culture> Cultures { get; set; } = new List<Culture>();
}
