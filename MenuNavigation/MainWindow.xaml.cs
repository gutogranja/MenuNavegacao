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

namespace MenuNavigation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void popUpLogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        
        private void openMenuButton_Click(object sender, RoutedEventArgs e)
        {
            openMenuButton.Visibility = Visibility.Collapsed;
            closeMenuButton.Visibility = Visibility.Visible;
        }

        private void closeMenuButton_Click(object sender, RoutedEventArgs e)
        {
            openMenuButton.Visibility = Visibility.Visible;
            closeMenuButton.Visibility = Visibility.Collapsed;
        }

    }
}
