using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SelHoz.Service
{
    public class Service
    {
        public static Frame frame;
        public static FarmingContext db = new();
        public static User users = new();
    }
}
