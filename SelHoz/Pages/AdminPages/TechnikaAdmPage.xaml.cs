using SelHoz.VM.AdminVM;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace SelHoz.Pages.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для TechnikaAdmPage.xaml
    /// </summary>
    public partial class TechnikaAdmPage
    {
        public TechnikaAdmPage()
        {
            InitializeComponent();
            DataContext = new TechnikaAdmVM();

        }

        private void btn2_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ObservableCollection<Technique> order_list = new(Service.Service.db.Techniques);
            ICollectionView view = CollectionViewSource.GetDefaultView(order_list);
            lbox1.ItemsSource = view;
            view.SortDescriptions.Clear();
            view.SortDescriptions.Add(new System.ComponentModel.SortDescription("IdTechnique", System.ComponentModel.ListSortDirection.Ascending));
            view.Refresh();
        }

        private void btn3_Click(object sender, System.Windows.RoutedEventArgs e)
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
