using System;
using System.Collections.Generic;

namespace SelHoz;

public partial class Employee
{
    public int IdEmployee { get; set; }

    public string SurnameEmployee { get; set; } = null!;

    public string NameEmployee { get; set; } = null!;

    public string PatronymicEmployee { get; set; } = null!;

    public string Sex { get; set; } = null!;

    public string BirthdayDate { get; set; } = null!;

    public string AddressEmployee { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNumberEmployee { get; set; } = null!;

    public string Post { get; set; } = null!;

    public virtual ICollection<Farming> Farmings { get; set; } = new List<Farming>();
}
