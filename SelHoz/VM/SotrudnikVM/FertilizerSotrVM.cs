using System.Collections.ObjectModel;

namespace SelHoz.VM.SotrudnikVM
{
    public class FertilizerSotrVM : Helper
    {
        private ObservableCollection<Fertilizer> fert_list = new(Service.Service.db.Fertilizers);
        public ObservableCollection<Fertilizer> Fertilizer_List
        {
            get => fert_list;
            set
            {
                fert_list = value;
                OnPropertyChanged();
            }
        }
    }
}
