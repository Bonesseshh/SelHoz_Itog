using SelHoz.Pages.AdminPages;
using System.Collections.ObjectModel;

namespace SelHoz.VM.AdminVM
{
    public class Provider_VM : Helper
    {
        private RelayCommand _addProvider;
        private ObservableCollection<Provider> prov_list = new(Service.Service.db.Providers);
        public ObservableCollection<Provider> Prov_List
        {
            get => prov_list;
            set
            {
                prov_list = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand AddProv => _addProvider ??
                                           (_addProvider = new RelayCommand((x) =>
                                           {
                                               new AddProviderWindow().Show();
                                           }));
    }
}
