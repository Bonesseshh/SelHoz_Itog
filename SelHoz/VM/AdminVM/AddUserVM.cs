using SelHoz.Pages.AdminPages;
using System.Windows;

namespace SelHoz.VM.AdminVM
{
    public class AddUserVM : Helper
    {
        private RelayCommand _adduser;
        private string _nameuser;
        private string _login;
        private string _password;
        public RelayCommand AddTech => _adduser ??
                                   (_adduser = new RelayCommand((x) =>
                                   {
                                       AddUserWindow win10 = new();

                                       User culuser = new()
                                       {                                        
                                           NameUser = NameUser,
                                           LoginUser = Login,
                                           PasswordUser = Password
                                       };
                                       Service.Service.db.User.Add(culuser);
                                       Service.Service.db.SaveChanges();
                                       MessageBox.Show("Данные добавлены");
                                       OnPropertyChanged();
                                   }));
        public string NameUser
        {
            get => _nameuser;
            set
            {
                _nameuser = value;
                OnPropertyChanged();
            }
        }

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
    }
}