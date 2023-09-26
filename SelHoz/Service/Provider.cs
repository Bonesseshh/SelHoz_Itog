using System;
using System.Collections.Generic;

namespace SelHoz;

public partial class Provider
{
    public int IdProvider { get; set; }

    public string NameProvider { get; set; } = null!;

    public string AddressProvider { get; set; } = null!;

    public string PhoneNumberProvider { get; set; } = null!;

    public virtual ICollection<OrderingFertilizer> OrderingFertilizers { get; set; } = new List<OrderingFertilizer>();

    public virtual ICollection<OrderingTechnique> OrderingTechniques { get; set; } = new List<OrderingTechnique>();
}
