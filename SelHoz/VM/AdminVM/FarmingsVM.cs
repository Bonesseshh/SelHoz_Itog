using Microsoft.EntityFrameworkCore;
using SelHoz.Pages.AdminPages;
using System.Collections.ObjectModel;

namespace SelHoz.VM.AdminVM
{
    public class FarmingsVM : Helper
    {
        private RelayCommand _addfarm;
        
        private ObservableCollection<Farming> farm_list = new(Service.Service.db.Farmings.Include(x => x.IdCultureNavigation));
        private ObservableCollection<Farming> fert_list = new(Service.Service.db.Farmings.Include(x => x.IdFertilizerNavigation));
        private ObservableCollection<Farming> tech_list = new(Service.Service.db.Farmings.Include(x => x.IdTechniqueNavigation));
        private ObservableCollection<Farming> harv_list = new(Service.Service.db.Farmings.Include(x => x.IdEmployeeNavigation));
        private ObservableCollection<Farming> empl_list = new(Service.Service.db.Farmings.Include(x => x.IdHarvestNavigation));
        public ObservableCollection<Farming> Farm_List
        {
            get => farm_list;
            set
            {
                farm_list = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand AddFarm => _addfarm ??
                                           (_addfarm = new RelayCommand((x) =>
                                           {
                                               new AddFarmWindow().Show();
                                           }));
    }
}
