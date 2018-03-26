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
using Lapoor_Restaurant.Domain;
using Lapoor_Restaurant.Domain.Model;

namespace Lapoor_Restaurant.Category
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class AddSender : Window
    {


        private Category.List _sender;

        public AddSender()
        {
            InitializeComponent();
            this._sender = sender;

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            if (Validate() == false)
            {
                return;
            }

            if (CategoryBLL.CategoryName = ByName(txtboxName) != null)
            {
                MessageBox.Show("Categoryname is already used");
            }
            else
            {
                Lapoor_Restaurant.Domain.Model.Category category = new Lapoor_Restaurant.Domain.Model.Category
                {
                    Id = Guid.NewGuid(),
                    ParentId = this._sender.parentId
                };


                MessageBox.Show("CategoryName successfully created.");
                this._sender.showList();
                this.Close();
            }
        }

        private object ByName(object text)
        {
            throw new NotImplementedException();
        }

        private object Categories(Domain.Model.Category category)
        {
            throw new NotImplementedException();
        }

        private bool Validate()
        {
            {
                MessageBox.Show("Please input correct values");
                return false;
            };

#pragma warning disable CS0162 // Unreachable code detected
            return true;
#pragma warning restore CS0162 // Unreachable code detected
        }
        private Random random = new Random();
        private object txtboxName;
        private List sender;

        public object CategoryBLL { get; private set; }

        private string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());

        }

        private void BtnCancel_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}