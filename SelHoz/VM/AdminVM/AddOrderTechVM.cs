using SelHoz.Pages.AdminPages;
using System.Windows;

namespace SelHoz.VM.AdminVM
{
    public class AddOrderTechVM : Helper
    {
        private RelayCommand _addTech;
        private int _nametech;
        private int _nameprov;
        public RelayCommand OrderTech => _addTech ??
                                   (_addTech = new RelayCommand((x) =>
                                   {
                                       OrderingTechnique orderfe = new()
                                       {
                                           IdTechnique = NameTech,
                                           IdProvider = NameProv,
                                           Status_Tech = "В пути"
                                       };
                                       Service.Service.db.OrderingTechniques.Add(orderfe);
                                       Service.Service.db.SaveChanges();
                                       MessageBox.Show("Данные добавлены");
                                       OnPropertyChanged();
                                   }));
        public int NameTech
        {
            get => _nametech;
            set
            {
                _nametech = value;
                OnPropertyChanged();
            }
        }

        public int NameProv
        {
            get => _nameprov;
            set
            {
                _nameprov = value;
                OnPropertyChanged();
            }
        }
    }
}