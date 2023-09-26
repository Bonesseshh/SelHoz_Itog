using SelHoz.Pages.AdminPages;
using System.Collections.ObjectModel;

namespace SelHoz.VM.AdminVM
{
    public class TechnikaAdmVM : Helper
    {
        private RelayCommand _addtech;
        private ObservableCollection<Technique> tech_list = new(Service.Service.db.Techniques);
        public ObservableCollection<Technique> Tech_List
        {
            get => tech_list;
            set
            {
                tech_list = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand AddTech => _addtech ??
                                           (_addtech = new RelayCommand((x) =>
                                           {
                                               new AddTechWindow().Show();
                                           }));
    }
}
