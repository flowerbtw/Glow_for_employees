using Glow_for_employees.Users.Admin;
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
    /// Логика взаимодействия для Catalog.xaml
    /// </summary>
    public partial class Catalog : Page
    {
        public Catalog(string loginText)
        {
            InitializeComponent();
            storedLoginText = loginText;
        }

        public string storedLoginText;

        private void MenuToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (MenuContainer.Visibility == Visibility.Collapsed)
            {
                MenuContainer.Visibility = Visibility.Visible;
                Image? menuImage = MenuToggleButton.Template.FindName("MenuImage", MenuToggleButton) as Image;
                if (menuImage != null)
                {
                    menuImage.Source = new BitmapImage(new Uri("/menu_active.png", UriKind.Relative));
                }
            }
            else
            {
                MenuContainer.Visibility = Visibility.Collapsed;
                Image? menuImage = MenuToggleButton.Template.FindName("MenuImage", MenuToggleButton) as Image;
                if (menuImage != null)
                {
                    menuImage.Source = new BitmapImage(new Uri("/menu_inactive.png", UriKind.Relative));
                }
            }
        }

        private void SiteName_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            Page nextPage = new WelcomePage(storedLoginText);
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(nextPage);
        }

        private void MenuQuotations_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            Page nextPage = new Quotations(storedLoginText);
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(nextPage);
        }

        private void MenuStorage_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            Page nextPage = new Storage(storedLoginText);
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(nextPage);
        }

        private void MenuDeliveries_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            Page nextPage = new Deliveries(storedLoginText);
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(nextPage);
        }

        private void MenuCatalog_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            Page nextPage = new Catalog(storedLoginText);
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(nextPage);
        }

        private void MenuOrders_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            Page nextPage = new Orders(storedLoginText);
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(nextPage);
        }

        private void MenuFeedback_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            Page nextPage = new Feedback(storedLoginText);
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(nextPage);
        }

        private void MenuReturns_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            Page nextPage = new Returns(storedLoginText);
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(nextPage);
        }

        private void MenuNews_MouseLeftButtonDown(object sender, RoutedEventArgs e)
        {
            Page nextPage = new News(storedLoginText);
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(nextPage);
        }

        private void ProfileToggleButton_Click(object sender, RoutedEventArgs e)
        {
            if (ProfileContainer.Visibility == Visibility.Collapsed)
            {
                ProfileContainer.Visibility = Visibility.Visible;
                Image? profileImage = ProfileToggleButton.Template.FindName("ProfileImage", ProfileToggleButton) as Image;
                if (profileImage != null)
                {
                    profileImage.Source = new BitmapImage(new Uri("/profile_active.png", UriKind.Relative));
                }
            }
            else
            {
                ProfileContainer.Visibility = Visibility.Collapsed;
                Image? profileImage = ProfileToggleButton.Template.FindName("ProfileImage", ProfileToggleButton) as Image;
                if (profileImage != null)
                {
                    profileImage.Source = new BitmapImage(new Uri("/profile_inactive.png", UriKind.Relative));
                }
            }
        }
    }
}
