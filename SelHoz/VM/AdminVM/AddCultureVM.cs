using SelHoz.Pages.AdminPages;
using System.Windows;

namespace SelHoz.VM.AdminVM
{
    public class AddCultureVM : Helper
    {
        private RelayCommand _addCulture;
        private string _nameculture;
        private string _descriptioncul;
        private string _season;
        private int _areaid;
        private string _period;      
                     
        public RelayCommand AddCulture => _addCulture ??
                                   (_addCulture = new RelayCommand((x) =>
                                   {
                                       AddCultureWindow win10 = new();

                                       Culture culturee = new()
                                       {
                                           NameCulture = NameCulture,
                                           DescriptionCulture = DescriptionCul,
                                           RipeningPeriod = Period,
                                           Seasonality = Seasonality,
                                           IdArea = IDarea

                                       };
                                       Service.Service.db.Cultures.Add(culturee);
                                       Service.Service.db.SaveChanges();
                                       MessageBox.Show("Данные добавлены");
                                       OnPropertyChanged();
                                   }));
        public string NameCulture
        {
            get => _nameculture;
            set
            {
                _nameculture = value;
                OnPropertyChanged();
            }
        }

        public string DescriptionCul
        {
            get => _descriptioncul;
            set
            {
                _descriptioncul = value;
                OnPropertyChanged();
            }
        }
        public string Period
        {
            get => _period;
            set
            {
                _period = value;
                OnPropertyChanged();
            }
        }
        public string Seasonality
        {
            get => _season;
            set
            {
                _season = value;
                OnPropertyChanged();
            }
        }
        public int IDarea
        {
            get => _areaid;
            set
            {
                _areaid = value;
                OnPropertyChanged();
            }
        }
    }
}