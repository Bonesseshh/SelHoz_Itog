using SelHoz.VM.SotrudnikVM;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace SelHoz.Pages.SotrudnikPage
{
    /// <summary>
    /// Логика взаимодействия для AreaPage.xaml
    /// </summary>
    public partial class AreaPage
    {
        public AreaPage()
        {
            InitializeComponent();
            DataContext = new AreaPosevaVM();
        }

        private void btn2_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ObservableCollection<CultivatedArea> order_list = new(Service.Service.db.CultivatedAreas);
            ICollectionView view = CollectionViewSource.GetDefaultView(order_list);
            lbox1.ItemsSource = view;
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new System.ComponentModel.SortDescription("IdArea", System.ComponentModel.ListSortDirection.Ascending));
            view.Refresh();
        }

        private void btn3_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ObservableCollection<CultivatedArea> order_list = new(Service.Service.db.CultivatedAreas);
            ICollectionView view = CollectionViewSource.GetDefaultView(order_list);
            lbox1.ItemsSource = view;
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new System.ComponentModel.SortDescription("IdArea", System.ComponentModel.ListSortDirection.Descending));
            view.Refresh();
        }
    }
}
