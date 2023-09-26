using System;
using System.Collections.Generic;

namespace SelHoz;

public partial class User
{
    public int IdUser { get; set; }

    public string NameUser { get; set; } = null!;

    public string LoginUser { get; set; } = null!;

    public string PasswordUser { get; set; } = null!;
}
