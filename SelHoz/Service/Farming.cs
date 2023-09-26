using System;
using System.Collections.Generic;

namespace SelHoz;

public partial class Farming
{
    public int IdFarming { get; set; }

    public string NameFarming { get; set; } = null!;

    public string AddressFarming { get; set; } = null!;

    public int? IdEmployee { get; set; }

    public int? IdCulture { get; set; }

    public int? IdFertilizer { get; set; }

    public int? IdTechnique { get; set; }

    public int? IdHarvest { get; set; }

    public virtual Culture? IdCultureNavigation { get; set; }

    public virtual Employee? IdEmployeeNavigation { get; set; }

    public virtual Fertilizer? IdFertilizerNavigation { get; set; }

    public virtual Harvesting? IdHarvestNavigation { get; set; }

    public virtual Technique? IdTechniqueNavigation { get; set; }
}
