using SelHoz.Pages.AdminPages;
using System.Windows;

namespace SelHoz.VM.AdminVM
{
    public class AddOrderFertVM : Helper
    {
        private RelayCommand _addFertilizer;
        private int _namefert;
        private int _nameprov;


        public RelayCommand OrderFert => _addFertilizer ??
                                   (_addFertilizer = new RelayCommand((x) =>
                                   {                                       
                                       OrderingFertilizer orderfe = new()
                                       {                                           
                                           IdFertilizer = NameFert,
                                           IdProvider = NameProv,
                                           Status_Fert = "В пути"
                                       };
                                       Service.Service.db.OrderingFertilizers.Add(orderfe);
                                       Service.Service.db.SaveChanges();
                                       MessageBox.Show("Данные добавлены");
                                       OnPropertyChanged();
                                   }));
        public int NameFert
        {
            get => _namefert;
            set
            {
                _namefert = value;
                OnPropertyChanged();
            }
        }

        public int NameProv
        {
            get => _nameprov;
            set
            {
                _nameprov = value;
                OnPropertyChanged();
            }
        }       
    }
}