﻿using System;
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
using Lapoor_Restaurant.Domain.Infrastructure;
using Lapoor_Restaurant.Domain.Models;
using Lapoor_Restaurant.Domain.Models.Enums;

namespace Lapoor_Restaurant.POS.Users
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
            cboRole.ItemsSource = Enum.GetValues(typeof(Role)).Cast<Role>().ToList();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (Validate() == false)
            {
                return;
            }

            if (UsersBLL.Get = User.ByUserName(txtUserName.Text) != null)
            {
                MessageBox.Show("Username is already used");
            }
            else
            {
                User user = new User();
                user.Id = Guid.NewGuid();
                user.UserName = txtUserName.Text;
                user.LastName = txtLastName.Text;
                user.FirstName = txtFirstName.Text;

                Role role = new Role();
                if (cboRole.SelectedValue.ToString() == Role.Admin.ToString())
                {
                    role = Role.Admin;
                }
                else if (cboRole.SelectedValue.ToString() == Role.Cashier.ToString())
                {
                    role = Role.Cashier;
                }
                else if (cboRole.SelectedValue.ToString() == Role.Chef.ToString())
                {
                    role = Role.Chef;
                }
                else if (cboRole.SelectedValue.ToString() == Role.InventoryController.ToString())
                {
                    role = Role.InventoryController;
                }
                else if (cboRole.SelectedValue.ToString() == Role.Waiter.ToString())
                {
                    role = Role.Waiter;
                }

                user.Role = role;
                user.Password = this.RandomString(6);
                UsersBLL.Create(user);
                MessageBox.Show("User successfully created.");
                this.Close();
            }
        }

        private object ByUserName(string text)
        {
            throw new NotImplementedException();
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

        private Random random = new Random();

        public object UsersBLL { get; private set; }

        private string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}