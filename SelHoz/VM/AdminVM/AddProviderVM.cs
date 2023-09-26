using SelHoz.Pages.AdminPages;
using System.Windows;

namespace SelHoz.VM.AdminVM
{
    public class AddProviderVM : Helper
    {
        private RelayCommand _addprov;
        private string _nameprov;
        private string _addresprov;
        private string _phoneprov;
        public RelayCommand AddProv => _addprov ??
                                   (_addprov = new RelayCommand((x) =>
                                   {
                                       AddProviderWindow win10 = new();

                                       Provider culprov = new()
                                       {
                                           NameProvider = NameProv,
                                           AddressProvider = AddressProv,
                                           PhoneNumberProvider = PhoneProv
                                       };
                                       Service.Service.db.Providers.Add(culprov);
                                       Service.Service.db.SaveChanges();
                                       MessageBox.Show("Данные добавлены");
                                       OnPropertyChanged();
                                   }));
        public string NameProv
        {
            get => _nameprov;
            set
            {
                _nameprov = value;
                OnPropertyChanged();
            }
        }

        public string AddressProv
        {
            get => _addresprov;
            set
            {
                _addresprov = value;
                OnPropertyChanged();
            }
        }
        public string PhoneProv
        {
            get => _phoneprov;
            set
            {
                _phoneprov = value;
                OnPropertyChanged();
            }
        }
    }
}