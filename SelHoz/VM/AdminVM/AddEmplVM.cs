using SelHoz.Pages.AdminPages;
using System.Windows;

namespace SelHoz.VM.AdminVM
{
    public class AddEmplVM : Helper
    {
        private RelayCommand _addEmpl;
        private string _surname;
        private string _name;
        private string _patronymic;
        private string _sex;
        private string _birthday;
        private string _address;
        private string _email;
        private string _phone;
        private string _post;

        public RelayCommand AddEmpl => _addEmpl ??
                                   (_addEmpl = new RelayCommand((x) =>
                                   {
                                       AddSotrudnikWindow win10 = new();

                                       Employee employee = new()
                                       {
                                           SurnameEmployee = Surname,
                                           NameEmployee = Name,
                                           PatronymicEmployee = Patronymic,
                                           Sex = Sex,
                                           BirthdayDate = Birthday,
                                           AddressEmployee = Address,
                                           Email = Email,
                                           PhoneNumberEmployee = Phone,
                                           Post = Post
                                       };
                                       Service.Service.db.Employees.Add(employee);
                                       Service.Service.db.SaveChanges();
                                       MessageBox.Show("Данные добавлены");
                                       OnPropertyChanged();
                                   }));
        public string Surname
        {
            get => _surname;
            set
            {
                _surname = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }
        public string Patronymic
        {
            get => _patronymic;
            set
            {
                _patronymic = value;
                OnPropertyChanged();
            }
        }
        public string Sex
        {
            get => _sex;
            set
            {
                _sex = value;
                OnPropertyChanged();
            }
        }
        public string Birthday
        {
            get => _birthday;
            set
            {
                _birthday = value;
                OnPropertyChanged();
            }
        }
        public string Address
        {
            get => _address;
            set
            {
                _address = value;
                OnPropertyChanged();
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }
        public string Phone
        {
            get => _phone;
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }
        public string Post
        {
            get => _post;
            set
            {
                _post = value;
                OnPropertyChanged();
            }
        }
    }
}