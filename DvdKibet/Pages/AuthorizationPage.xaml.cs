using DvdKibet.Classes;
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

namespace DvdKibet.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }

        private void Authorization_Click(object sender, RoutedEventArgs e)
        {
            string login = TxbLogin.Text;
            string password = PbxPassword.Password;
            if (!string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password))
            {
                ConnectionClass.currentEmployee = ConnectionClass.entities.Employee
                    .Where(x => x.FIO == login && x.Phone_Number == password).FirstOrDefault();
                if (ConnectionClass.currentEmployee != null)
                {
                    if (ConnectionClass.currentEmployee.Id_Role == 1) //Admin
                    {
                        NavigationService.Navigate(new AdminPage());
                    }
                    else if (ConnectionClass.currentEmployee.Id_Role == 2) //Cashier
                    {
                        NavigationService.Navigate(new CashierPage());
                    }
                    else //Consultant
                    {
                        NavigationService.Navigate(new ConsultantPage());
                    }
                }
                else
                {
                    MessageBox.Show("Пользователь не найден");
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены");
            }
        }
    }
}
