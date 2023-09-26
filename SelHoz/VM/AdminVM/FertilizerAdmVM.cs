using SelHoz.Pages.AdminPages;
using System.Collections.ObjectModel;

namespace SelHoz.VM.AdminVM
{
    public class FertilizerAdmVM : Helper
    {
        private RelayCommand _addFert;       
        private ObservableCollection<Fertilizer> fert_list = new(Service.Service.db.Fertilizers);
        public ObservableCollection<Fertilizer> Fert_List
        {
            get => fert_list;
            set
            {
                fert_list = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand AddFert => _addFert ??
                                           (_addFert = new RelayCommand((x) =>
                                           {
                                               new AddFertWindow().Show();
                                           }));     
    }
}
