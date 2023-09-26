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
using SelHoz.VM.AdminVM;

namespace SelHoz.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для FarmingsPage.xaml
    /// </summary>
    public partial class FarmingsPage
    {
        public FarmingsPage()
        {
            InitializeComponent();
            DataContext = new FarmingsVM();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Farming> order_list = new(Service.Service.db.Farmings);
            ICollectionView view = CollectionViewSource.GetDefaultView(order_list);
            lbox1.ItemsSource = view;
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new System.ComponentModel.SortDescription("IdFarming", System.ComponentModel.ListSortDirection.Ascending));
            view.Refresh();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
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
