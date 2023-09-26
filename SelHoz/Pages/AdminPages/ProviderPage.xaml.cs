using SelHoz.VM.AdminVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SelHoz.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для ProviderPage.xaml
    /// </summary>
    public partial class ProviderPage
    {
        public ProviderPage()
        {
            InitializeComponent();
            DataContext = new Provider_VM();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Provider> order_list = new(Service.Service.db.Providers);
            ICollectionView view = CollectionViewSource.GetDefaultView(order_list);
            lbox1.ItemsSource = view;
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new System.ComponentModel.SortDescription("IdProvider", System.ComponentModel.ListSortDirection.Ascending));
            view.Refresh();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Provider> order_list = new(Service.Service.db.Providers);
            ICollectionView view = CollectionViewSource.GetDefaultView(order_list);
            lbox1.ItemsSource = view;
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new System.ComponentModel.SortDescription("IdProvider", System.ComponentModel.ListSortDirection.Descending));
            view.Refresh();
        }
    }
}
