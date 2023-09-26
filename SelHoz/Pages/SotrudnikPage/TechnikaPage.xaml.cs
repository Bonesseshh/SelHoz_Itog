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
using SelHoz.VM.SotrudnikVM;

namespace SelHoz.Pages.SotrudnikPage
{
    /// <summary>
    /// Логика взаимодействия для TechnikaPage.xaml
    /// </summary>
    public partial class TechnikaPage
    {
        public TechnikaPage()
        {
            InitializeComponent();
            DataContext = new TechnikaVM();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Technique> order_list = new(Service.Service.db.Techniques);
            ICollectionView view = CollectionViewSource.GetDefaultView(order_list);
            lbox1.ItemsSource = view;
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new System.ComponentModel.SortDescription("IdTechnique", System.ComponentModel.ListSortDirection.Ascending));
            view.Refresh();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Technique> order_list = new(Service.Service.db.Techniques);
            ICollectionView view = CollectionViewSource.GetDefaultView(order_list);
            lbox1.ItemsSource = view;
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new System.ComponentModel.SortDescription("IdTechnique", System.ComponentModel.ListSortDirection.Descending));
            view.Refresh();
        }
    }
}
