using SelHoz.Pages.AdminPages;
using System.Windows;

namespace SelHoz.VM.AdminVM
{
    public class AddTechVM : Helper
    {
        private RelayCommand _addtech;
        private string _nametech;
        private string _decription;
        private string _model;
        private decimal _pricetech;
        public RelayCommand AddTech => _addtech ??
                                   (_addtech = new RelayCommand((x) =>
                                   {
                                       AddTechWindow win10 = new();

                                       Technique cultech = new()
                                       {
                                           NameTechnique = NameTech,
                                           DescriptionTechnique = Decriptione,
                                           Model = Model,
                                           PriceTech = PriceTech
                                       };
                                       Service.Service.db.Techniques.Add(cultech);
                                       Service.Service.db.SaveChanges();
                                       MessageBox.Show("Данные добавлены");
                                       OnPropertyChanged();
                                   }));
        public string NameTech
        {
            get => _nametech;
            set
            {
                _nametech = value;
                OnPropertyChanged();
            }
        }

        public string Decriptione
        {
            get => _decription;
            set
            {
                _decription = value;
                OnPropertyChanged();
            }
        }
        public string Model
        {
            get => _model;
            set
            {
                _model = value;
                OnPropertyChanged();
            }
        }
        public decimal PriceTech
        {
            get => _pricetech;
            set
            {
                _pricetech = value;
                OnPropertyChanged();
            }
        }
    }
}