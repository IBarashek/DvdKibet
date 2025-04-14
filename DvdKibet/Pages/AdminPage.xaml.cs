using System;
using System.Collections.Generic;
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
using DvdKibet.Pages;

namespace DvdKibet.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.NavigationService.Navigate(new ProductListPage());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuFrame.NavigationService.Navigate(new ProductListPage());
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MenuFrame.NavigationService.Navigate(new NewProductPage());
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            MenuFrame.NavigationService.Navigate(new ClientListPage());
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MenuFrame.NavigationService.Navigate(new NewClientPage());
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            MenuFrame.NavigationService.Navigate(new EmployeerListPage());
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            MenuFrame.NavigationService.Navigate(new NewEmployeePage());
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            MenuFrame.NavigationService.Navigate(new PageApp.RepPage());
        }
    }
}
}
