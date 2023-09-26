using System.Collections.ObjectModel;

namespace SelHoz.VM.SotrudnikVM
{
    public class AreaPosevaVM : Helper
    {
        private ObservableCollection<CultivatedArea> area_list = new(Service.Service.db.CultivatedAreas);
        public ObservableCollection<CultivatedArea> Area_List
        {
            get => area_list;
            set
            {
                area_list = value;
                OnPropertyChanged();
            }
        }       
    }
}
