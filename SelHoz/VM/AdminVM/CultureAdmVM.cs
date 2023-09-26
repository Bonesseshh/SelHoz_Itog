using Microsoft.EntityFrameworkCore;
using SelHoz.Pages.AdminPages;
using System.Collections.ObjectModel;

namespace SelHoz.VM.AdminVM
{
    public class CultureAdmVM : Helper
    {
        private RelayCommand _addCulture;
        private ObservableCollection<Culture> cul_list = new(Service.Service.db.Cultures.Include(x => x.IdAreaNavigation));
        private ObservableCollection<Culture> culture_list = new(Service.Service.db.Cultures);
        public ObservableCollection<Culture> Culture_List
        {
            get => culture_list;
            set
            {
                culture_list = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand AddCulture => _addCulture ??
                                           (_addCulture = new RelayCommand((x) =>
                                           {
                                               new AddCultureWindow().Show();
                                           }));
    }
}