using System.Collections.ObjectModel;

namespace SelHoz.VM.SotrudnikVM
{
    public class TechnikaVM : Helper
    {
        private ObservableCollection<Technique> technika_list = new(Service.Service.db.Techniques);
        public ObservableCollection<Technique> Technika_List
        {
            get => technika_list;
            set
            {
                technika_list = value;
                OnPropertyChanged();
            }
        }
    }
}
