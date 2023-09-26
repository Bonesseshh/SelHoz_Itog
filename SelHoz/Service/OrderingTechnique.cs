using System;
using System.Collections.Generic;

namespace SelHoz;

public partial class OrderingTechnique
{
    public int IdOrderTechnique { get; set; }
   
    public int? IdProvider { get; set; }

    public int? IdTechnique { get; set; }
    public string Status_Tech { get; set; }

    public virtual Provider? IdProviderNavigation { get; set; }

    public virtual Technique? IdTechniqueNavigation { get; set; }
}
