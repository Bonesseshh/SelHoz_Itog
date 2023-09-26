using System.Collections.ObjectModel;
using Microsoft.EntityFrameworkCore;

namespace SelHoz.VM.SotrudnikVM
{
    public class FarmVM : Helper
    {
        private ObservableCollection<Farming> farm_list = new(Service.Service.db.Farmings.Include(x => x.IdCultureNavigation));
        private ObservableCollection<Farming> arm_list = new(Service.Service.db.Farmings.Include(x => x.IdFertilizerNavigation));
        private ObservableCollection<Farming> carm_list = new(Service.Service.db.Farmings.Include(x => x.IdTechniqueNavigation));
        public ObservableCollection<Farming> Farm_List
        {
            get => farm_list;
            set
            {
                farm_list = value;
                OnPropertyChanged();
            }          
        }
        
    }
}
