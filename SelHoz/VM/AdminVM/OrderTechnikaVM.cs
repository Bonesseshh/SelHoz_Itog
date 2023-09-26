using Microsoft.EntityFrameworkCore;
using SelHoz.Pages.AdminPages;
using System.Collections.ObjectModel;

namespace SelHoz.VM.AdminVM
{
    public class OrderTechnikaVM : Helper
    {
        private RelayCommand _ordertech;
        private ObservableCollection<OrderingTechnique> tech_list = new(Service.Service.db.OrderingTechniques.Include(x => x.IdTechniqueNavigation));
        private ObservableCollection<OrderingTechnique> ech_list = new(Service.Service.db.OrderingTechniques.Include(x => x.IdProviderNavigation));
        private ObservableCollection<OrderingTechnique> order_list = new(Service.Service.db.OrderingTechniques);
        
        public ObservableCollection<OrderingTechnique> OrderTech_List
        {
            get => order_list;
            set
            {
                order_list = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand OrderTech => _ordertech ??
                                           (_ordertech = new RelayCommand((x) =>
                                           {
                                               new AddOrderTechWindow().Show();
                                           }));       
    }
}
