using SelHoz.VM.AdminVM;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace SelHoz.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для CultureAdmPage.xaml
    /// </summary>
    public partial class CultureAdmPage 
    {
        public CultureAdmPage()
        {
            InitializeComponent();
            DataContext = new CultureAdmVM();
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
