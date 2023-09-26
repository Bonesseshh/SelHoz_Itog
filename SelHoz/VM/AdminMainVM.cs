
namespace SelHoz.VM
{
    public class AdminMainVM
    {
        private RelayCommand _ordertech;
        private RelayCommand _orderfert;
        private RelayCommand _sotrudniki;
        private RelayCommand _culture;
        private RelayCommand _technika;
        private RelayCommand _farmings;
        private RelayCommand _area;
        private RelayCommand _fertil;
        private RelayCommand _provider;
        private RelayCommand _otchet;

        public RelayCommand OrderTech => _ordertech ??
                                           (_ordertech = new RelayCommand((x) =>
                                           {
                                               Service.Service.frame.Navigate(new Pages.AdminPages.OrderTechnikaPage());
                                           }));
        public RelayCommand OrderFert => _orderfert ??
                                           (_orderfert = new RelayCommand((x) =>
                                           {
                                               Service.Service.frame.Navigate(new Pages.AdminPages.OrderFertPage());
                                           }));
        public RelayCommand Sotrud => _sotrudniki ??
                                           (_sotrudniki = new RelayCommand((x) =>
                                           {
                                               Service.Service.frame.Navigate(new Pages.AdminPages.SotrudnikiPage());
                                           }));
        public RelayCommand Cultures => _culture ??
                                            (_culture = new RelayCommand((x) =>
                                            {
                                                Service.Service.frame.Navigate(new Pages.AdminPages.CultureAdmPage());
                                            }));
        public RelayCommand Techniks => _technika ??
                                            (_technika = new RelayCommand((x) =>
                                            {
                                                Service.Service.frame.Navigate(new Pages.AdminPages.TechnikaAdmPage());
                                            }));
        public RelayCommand Areas => _area ??
                                            (_area = new RelayCommand((x) =>
                                            {
                                                Service.Service.frame.Navigate(new Pages.AdminPages.AreaAdmPage());
                                            }));
        public RelayCommand Farmings => _farmings ??
                                            (_farmings = new RelayCommand((x) =>
                                            {
                                                Service.Service.frame.Navigate(new Pages.AdminPages.FarmingsPage());
                                            }));
        public RelayCommand Fertilizer => _fertil ??
                                           (_fertil = new RelayCommand((x) =>
                                           {
                                               Service.Service.frame.Navigate(new Pages.AdminPages.FertilizerAdmPage());
                                           }));
        public RelayCommand Provider => _provider ??
                                          (_provider = new RelayCommand((x) =>
                                          {
                                              Service.Service.frame.Navigate(new Pages.AdminPages.ProviderPage());
                                          }));
        public RelayCommand Otchet => _otchet ??
                                      (_otchet = new RelayCommand((x) =>
                                      {
                                          Service.Service.frame.Navigate(new Pages.AdminPages.OtchetPage());
                                      }
                                      ));
    }
}