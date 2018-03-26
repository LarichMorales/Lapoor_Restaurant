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

namespace Lapoor_Restaurant.Delivery
{
    /// <summary>
    /// Interaction logic for Add.xaml
    /// </summary>
    public partial class AddDelivery : Window
    {
        public CustomDelivery delivery = new CustomDelivery();
        private Delivery.List _sender;
        private object lblDate;
        private object grDeliveryItemList;

        public object DeliveryBLL { get; private set; }
        public int Items { get; private set; }

        public AddDelivery(List sender)
        {
            InitializeComponent();
            lblDate= DateTime.Now.ToString("ddd dd MMMM yyyy");
            delivery.Date = DateTime.Now;
            _sender = sender;

        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            Delivery.Additem addItemWindow = new Delivery.Additem(this);
            addItemWindow.Show();
        }
        public void ShowList()
        {
   
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            var saved = DeliveryBLL.(delivery);
            this._sender.ShowList();
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}