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

namespace Glow_for_employees
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public string loginText;

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string enteredLogin = Login.Text;
            string enteredPassword = Password.Text;

            if (enteredLogin == "admin" && enteredPassword == "12345")
            {
                WelcomePage welcomePage = new WelcomePage(enteredLogin);
                NavigationService.Navigate(welcomePage);
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль. Попробуйте еще раз.");
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = string.Empty;
        }
    }
}
