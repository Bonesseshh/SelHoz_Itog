using SelHoz.Pages.AdminPages;
using System.Windows;

namespace SelHoz.VM.AdminVM
{
    public class AddFertVM : Helper
    {
        private RelayCommand _addFert;
        private string _namefert;
        private string _description;
        private string _datemanuf;
        private string _expirationdate;
        private decimal _pricefert;
        public RelayCommand AddFert => _addFert ??
                                   (_addFert = new RelayCommand((x) =>
                                   {
                                       AddFertWindow win10 = new();

                                       Fertilizer culfert = new()
                                       {
                                          NameFertilizer = NameFert,
                                          DescriptionFertilizer = Description,
                                          DateManufacture = ManufactureDate,
                                          ExpirationDate = ExpirationDate,
                                          PriceFert = PriceFert
                                       };
                                       Service.Service.db.Fertilizers.Add(culfert);
                                       Service.Service.db.SaveChanges();
                                       MessageBox.Show("Данные добавлены");
                                       OnPropertyChanged();
                                   }));
        public string NameFert
        {
            get => _namefert;
            set
            {
                _namefert = value;
                OnPropertyChanged();
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }
        public string ManufactureDate
        {
            get => _datemanuf;
            set
            {
                _datemanuf = value;
                OnPropertyChanged();
            }
        }
        public string ExpirationDate
        {
            get => _expirationdate;
            set
            {
                _expirationdate = value;
                OnPropertyChanged();
            }
        }
        public decimal PriceFert
        {
            get => _pricefert;
            set
            {
                _pricefert = value;
                OnPropertyChanged();
            }
        }
    }
}