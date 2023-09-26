using System.Collections.ObjectModel;

namespace SelHoz.VM.SotrudnikVM
{
    public class CultureVM : Helper
    {
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
    }
}
