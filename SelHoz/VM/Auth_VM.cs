using SelHoz.Page;
using System.Linq;
using System.Windows;

namespace SelHoz.VM
{
    public class Auth_VM : Helper
    {
        private string _login;
        private string _password;
        private RelayCommand _authorization;

        public RelayCommand Auth => _authorization ??
                                    (_authorization = new RelayCommand((x) =>
                                    {
                                        User? selUser = Service.Service.db.User.FirstOrDefault(x =>
                                            x.LoginUser == Login && x.PasswordUser == Password);
                                        if (selUser == null)
                                        {
                                            MessageBox.Show("Вы ввели неверный логин или пароль!");
                                            return;
                                        }

                                        if (selUser.IdUser == 1)
                                        {
                                            new AdminMainWindow().Show();
                                        }                              
                                        if (selUser.IdUser >= 2)
                                        {
                                            new SotrudnikMainWindow().Show();                         
                                        }                                                                           
                                    }));
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
