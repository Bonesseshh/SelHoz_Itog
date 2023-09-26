using SelHoz.Pages.AdminPages;
using System.Windows;

namespace SelHoz.VM.AdminVM
{
    public class AddFarmVM : Helper
    {
        private RelayCommand _addFarm;
        private string _namefarm;
        private string _address;
        private int _employeeid;
        private int _cultureid;
        private int _fertid;
        private int _techid;
        private int _harvid;

        public RelayCommand AddFarm => _addFarm ??
                                   (_addFarm = new RelayCommand((x) =>
                                   {
                                       AddFarmWindow win10 = new();

                                       Farming farmings = new()
                                       {
                                           NameFarming = NameFarm,
                                           AddressFarming = AddressFarm,
                                           IdEmployee = IDEmployee,
                                           IdCulture = IDCulture,
                                           IdFertilizer = IDFert,
                                           IdTechnique = IDTech,
                                           IdHarvest = IDHarv
                                       };
                                       Service.Service.db.Farmings.Add(farmings);
                                       Service.Service.db.SaveChanges();
                                       MessageBox.Show("Данные добавлены");
                                       OnPropertyChanged();
                                   }));
        public string NameFarm
        {
            get => _namefarm;
            set
            {
                _namefarm = value;
                OnPropertyChanged();
            }
        }

        public string AddressFarm
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged();
            }
        }
        public int IDEmployee
        {
            get => _employeeid;
            set
            {
                _employeeid = value;
                OnPropertyChanged();
            }
        }
        public int IDCulture
        {
            get => _cultureid;
            set
            {
                _cultureid = value;
                OnPropertyChanged();
            }
        }
        public int IDFert
        {
            get => _fertid;
            set
            {
                _fertid = value;
                OnPropertyChanged();
            }
        }
        public int IDTech
        {
            get => _techid;
            set
            {
                _techid = value;
                OnPropertyChanged();
            }
        }
        public int IDHarv
        {
            get => _harvid;
            set
            {
                _harvid = value;
                OnPropertyChanged();
            }
        }
    }
}