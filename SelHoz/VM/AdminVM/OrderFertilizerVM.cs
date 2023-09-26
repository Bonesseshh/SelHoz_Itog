using Microsoft.EntityFrameworkCore;
using SelHoz.Pages.AdminPages;
using System.Collections.ObjectModel;

namespace SelHoz.VM.AdminVM
{
    public class OrderFertilizerVM : Helper
    {       
        private ObservableCollection<OrderingFertilizer> order_list = new(Service.Service.db.OrderingFertilizers);
        private ObservableCollection<OrderingFertilizer> farm_list = new(Service.Service.db.OrderingFertilizers.Include(x => x.IdFertilizerNavigation));
        private ObservableCollection<OrderingFertilizer> arm_list = new(Service.Service.db.OrderingFertilizers.Include(x => x.IdProviderNavigation));
        private RelayCommand _orderfert;
        public ObservableCollection<OrderingFertilizer> OrderFert_List
        {
            get => order_list;
            set
            {
                order_list = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand OrderFert => _orderfert ??
                                           (_orderfert = new RelayCommand((x) =>
                                           {
                                               new OrderFertWindow().Show();
                                           }));
    }
}
