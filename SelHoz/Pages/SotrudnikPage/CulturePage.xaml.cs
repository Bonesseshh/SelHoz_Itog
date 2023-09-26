using SelHoz.VM.SotrudnikVM;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace SelHoz.Pages.SotrudnikPage
{
    /// <summary>
    /// Логика взаимодействия для CulturePage.xaml
    /// </summary>
    public partial class CulturePage
    {
        public CulturePage()
        {
            InitializeComponent();
            DataContext = new CultureVM();
        }

        private void btn2_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ObservableCollection<Culture> order_list = new(Service.Service.db.Cultures);
            ICollectionView view = CollectionViewSource.GetDefaultView(order_list);
            lbox1.ItemsSource = view;
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new System.ComponentModel.SortDescription("IdCulture", System.ComponentModel.ListSortDirection.Ascending));
            view.Refresh();
        }

        private void btn3_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ObservableCollection<Culture> order_list = new(Service.Service.db.Cultures);
            ICollectionView view = CollectionViewSource.GetDefaultView(order_list);
            lbox1.ItemsSource = view;
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new System.ComponentModel.SortDescription("IdCulture", System.ComponentModel.ListSortDirection.Descending));
            view.Refresh();
        }
    }
}
