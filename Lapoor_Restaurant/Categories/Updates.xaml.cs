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
using static System.Net.Mime.MediaTypeNames;

namespace Lapoor_Restaurant.Category
{
    /// <summary>
    /// Interaction logic for Update.xaml
    /// </summary>
    public partial class Update : Window
    {
        private Lapoor_Restaurant.Domain.Model.Category _category;
        private Category.List _sender;
        private object txtboxName;
        private object category;

        public object CategoryBLL { get; private set; }
        public object Initialize { get; }

        public UpdateCategory(List sender, Domain.Model.Category category)
        {
            this._category = category;
            this._sender = sender;

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void BtnUpdate_Click_1(object sender, RoutedEventArgs e)
        {
            if (Validate() == false)
            {
                return;
            }

            if (CategoryBLL = Name + TextBox!= null)
            {
                MessageBox.Show("Categoryname is already used");
            }
            else
            {
                Lapoor_Restaurant.Domain.Model.Category category = new Domain.Model.Category
                {
                };




                category.Id = this._category.Id;
                CategoryBLLUpdate(category);
                MessageBox.Show("User successfully Updated.");
                this._sender.showList();
                this.Close();
            }
        }

        private void CategoryBLLUpdate(Domain.Model.Category category)
        {
            throw new NotImplementedException();
        }

        private bool Validate()

            {
                MessageBox.Show("Please input correct values");
                return false;


#pragma warning disable CS0162 // Unreachable code detected
            return true;
#pragma warning restore CS0162 // Unreachable code detected
        }
    }
}