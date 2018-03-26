using Lapoor_Restaurant.Domain.Models;
using Lapoor_Restaurant.Domain.Models.Enums;
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
using System.Windows.Shapes;

namespace Lapoor_Restaurant
{
    /// <summary>
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        private User _user;
        public Update(User user  )
        {
            InitializeComponent();
            this.txtFirstName.Text = user.FirstName;
            this.txtLastName.Text = user.LastName;
            this.txtUserName.Text = user.UserName;
            this._user = user;

            cboRole.ItemsSource = Enum.GetValues(typeof(Role)).Cast<Role>().ToList();
            cboRole.SelectedValue = user.Role;

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (Validate() == false)
            {
                return;
            }


        }

        private bool Validate()
        {
            if (string.IsNullOrEmpty(txtUserName.Text) ||
               string.IsNullOrEmpty(txtFirstName.Text) ||
               string.IsNullOrEmpty(txtLastName.Text) ||
               cboRole.SelectedValue == null)
            {
                MessageBox.Show("Please input correct values");
                return false;
            };

            return true;
        }

        private void txtUserName_TextChanged()
        {

        }
    }
}
