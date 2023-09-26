using System;
using System.Collections.Generic;

namespace SelHoz;

public partial class Culture
{
    public int IdCulture { get; set; }

    public string NameCulture { get; set; } = null!;

    public string RipeningPeriod { get; set; } = null!;

    public string DescriptionCulture { get; set; } = null!;

    public string Seasonality { get; set; } = null!;

    public int? IdArea { get; set; }

    public virtual ICollection<Farming> Farmings { get; set; } = new List<Farming>();

    public virtual CultivatedArea? IdAreaNavigation { get; set; }
}
