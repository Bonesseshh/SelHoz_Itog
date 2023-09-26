using SelHoz.Pages.AdminPages;
using System.Collections.ObjectModel;
using System.Linq;

namespace SelHoz.VM.AdminVM
{
    public class AreaAdmVM : Helper
    {
        private RelayCommand _find;
        private string _name;
        private RelayCommand _addArea;
        private ObservableCollection<CultivatedArea> area_list = new(Service.Service.db.CultivatedAreas);
        public ObservableCollection<CultivatedArea> Area_List
        {
            get => area_list;
            set
            {
                area_list = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand AddArea => _addArea ??
                                           (_addArea = new RelayCommand((x) =>
                                           {
                                               new AddAreaWindow().Show();
                                           }));       
    }
}
