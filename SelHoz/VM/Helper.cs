using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SelHoz.VM
{
    public  class Helper
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
