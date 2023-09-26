using SelHoz.VM.SotrudnikVM;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace SelHoz.Pages.SotrudnikPage
{
    /// <summary>
    /// Логика взаимодействия для FarmPage.xaml
    /// </summary>
    public partial class FarmPage  
    {
        public FarmPage()
        {
            InitializeComponent();
            DataContext = new FarmVM();
        }

        private void btn2_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ObservableCollection<Farming> order_list = new(Service.Service.db.Farmings);
            ICollectionView view = CollectionViewSource.GetDefaultView(order_list);
            lbox1.ItemsSource = view;
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new System.ComponentModel.SortDescription("IdArea", System.ComponentModel.ListSortDirection.Ascending));
            view.Refresh();
        }

        private void btn3_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ObservableCollection<Farming> order_list = new(Service.Service.db.Farmings);
            ICollectionView view = CollectionViewSource.GetDefaultView(order_list);
            lbox1.ItemsSource = view;
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new System.ComponentModel.SortDescription("IdFarming", System.ComponentModel.ListSortDirection.Descending));
            view.Refresh();
        }
    }
}
