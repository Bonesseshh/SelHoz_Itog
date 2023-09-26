using SelHoz.Pages.AdminPages;
using System.Windows;

namespace SelHoz.VM.AdminVM
{
    public class AddAreaVM : Helper
    {
        private RelayCommand _addArea;
        private string _area;
        private string _sowingdate;
        private string _harvestdate;
        public RelayCommand AddArea => _addArea ??
                                   (_addArea = new RelayCommand((x) =>
                                   {
                                       AddAreaWindow win10 = new(); 
                                       
                                       CultivatedArea cularea = new()
                                       {
                                             Area = Area,
                                             SowingDate = SowingDate,
                                             HarvestDate = HarvestDate

                                       };
                                        Service.Service.db.CultivatedAreas.Add(cularea);
                                        Service.Service.db.SaveChanges();
                                        MessageBox.Show("Данные добавлены");
                                        OnPropertyChanged();                                                                             
                                   }));
        public string Area
        {
            get => _area;
            set
            {
                _area = value;
                OnPropertyChanged();
            }
        }

        public string SowingDate
        {
            get => _sowingdate;
            set
            {
                _sowingdate = value;
                OnPropertyChanged();
            }
        }
        public string HarvestDate
        {
            get => _harvestdate;
            set
            {
                _harvestdate = value;
                OnPropertyChanged();
            }
        }        
    }
}