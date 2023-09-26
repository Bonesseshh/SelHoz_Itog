using SelHoz.Page;

namespace SelHoz.VM
{
    public class SotrudnikMainVM : Helper
    {
        private RelayCommand _culture;
        private RelayCommand _technika;
        private RelayCommand _area;
        private RelayCommand _farm;
        private RelayCommand _fert;

        public RelayCommand Culture => _culture ??
                                            (_culture = new RelayCommand((x) =>
                                            {                                                                                            
                                                Service.Service.frame.Navigate(new Pages.SotrudnikPage.CulturePage());                                 
                                            }));
        public RelayCommand Technika => _technika ??
                                            (_technika = new RelayCommand((x) =>
                                            {
                                                Service.Service.frame.Navigate(new Pages.SotrudnikPage.TechnikaPage());
                                            }));
        public RelayCommand Area => _area ??
                                            (_area = new RelayCommand((x) =>
                                            {
                                                Service.Service.frame.Navigate(new Pages.SotrudnikPage.AreaPage());
                                            }));
        public RelayCommand Farm => _farm ??
                                            (_farm = new RelayCommand((x) =>
                                            { 
                                                Service.Service.frame.Navigate(new Pages.SotrudnikPage.FarmPage());
                                            }));
        public RelayCommand Fert => _fert ??
                                            (_fert = new RelayCommand((x) =>
                                            {
                                                Service.Service.frame.Navigate(new Pages.SotrudnikPage.FertPage());
                                            }));
    }
}
