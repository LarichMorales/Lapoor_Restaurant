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
using Lapoor_Restaurant.Domain.Infrastructure;
using Lapoor_Restaurant.Domain.Models;

namespace Lapoor_Restaurant.POS
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

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void btnUsers_Click(object sender, RoutedEventArgs e)
        {
            Users.List userWindow = new Users.List();
            userWindow.Show();
        }

        private void btnCategories_Click(object sender, RoutedEventArgs e)
        {
            Categories.List categoryWindow = new Categories.List();
            categoryWindow.Show();
        }
    }
}