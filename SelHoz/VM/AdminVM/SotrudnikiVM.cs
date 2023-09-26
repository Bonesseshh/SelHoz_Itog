using SelHoz.Pages.AdminPages;
using System.Collections.ObjectModel;

namespace SelHoz.VM.AdminVM
{
    public class SotrudnikiVM : Helper
    {
        private RelayCommand _addEmployee;
        private RelayCommand _addUser;
        private ObservableCollection<Employee> empl_list = new(Service.Service.db.Employees);
        public ObservableCollection<Employee> Employee_List
        {
            get => empl_list;
            set
            {
                empl_list = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand AddEmployee => _addEmployee ??
                                           (_addEmployee = new RelayCommand((x) =>
                                           {
                                               new AddSotrudnikWindow().Show();
                                           }));
        public RelayCommand AddUser => _addUser ??
                                          (_addUser = new RelayCommand((x) =>
                                          {
                                              new AddUserWindow().Show();
                                          }));
    }
}
