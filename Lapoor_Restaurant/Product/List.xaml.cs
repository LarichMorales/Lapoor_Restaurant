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
using Lapoor_Restaurant.Domain.Infrastructure;
using Lapoor_Restaurant.Domain.Models;
using Lapoor_Restaurant.Domain.Models.Enums;

namespace Lapoor_Restaurant.POS.Products
{
    /// <summary>
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class List : Window
    {
        private long pageSize = 3;
        private long pageIndex = 1;
        private long queryCount = 0;
        private long pageCount = 0;
        private SortOrder sortOrder = SortOrder.Ascending;
        private string keyword = "";
        private Guid? categoryId = null;

        public object ProductBLL { get; private set; }

        public List(Guid? categoryId = null, string categoryName = "")
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(categoryName) == false)
            {
                lblTitle.Content = "Products under " + categoryName;
            }

            cboSortOrder.ItemsSource = Enum.GetValues(typeof(SortOrder)).Cast<SortOrder>();
            cboSortOrder.SelectedIndex = 0;
            this.categoryId = categoryId;
            ShowList();
        }

        private void ShowList()
        {
            Page<Product> products = ProductBLL.Search(pageSize, pageIndex, sortOrder, keyword, this.categoryId);
            lblPages.Content = "page " + pageIndex + " of " + products.PageCount;
            lblResults.Content = "Search Result : " + products.QueryCount + " Categories";
            queryCount = products.QueryCount;
            pageCount = products.PageCount;
            grList.ItemsSource = products.Items;
            txtPageSize.Text = products.PageSize.ToString();
        }

        private void Result(long pageSize, long pageIndex, SortOrder sortOrder, string keyword, Guid? categoryId)
        {
            throw new NotImplementedException();
        }

        private void result(long pageSize, long pageIndex, SortOrder sortOrder, string keyword, Guid? categoryId)
        {
            throw new NotImplementedException();
        }

        private void BtnLast_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageCount;
            ShowList();
        }

        private void BtnFirst_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = 1;
            ShowList();
        }

        private void BtnPrev_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex - 1;

            if (pageIndex < 1)
            {
                pageIndex = 1;
            }

            ShowList();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex + 1;

            if (pageIndex > pageCount)
            {
                pageIndex = pageCount;
            }

            ShowList();
        }

        private void CboSortOrder_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboSortOrder.SelectedValue.ToString() == SortOrder.Ascending.ToString())
            {
                sortOrder = SortOrder.Ascending;
            }
            else if (cboSortOrder.SelectedValue.ToString() == SortOrder.Descending.ToString())
            {
                sortOrder = SortOrder.Descending;
            }
            ShowList();
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            keyword = txtSearch.Text;
            ShowList();
        }

        private void TxtPageSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                bool result = Int32.TryParse(txtPageSize.Text, out int newPageSize);

                if (result == false)
                {
                    newPageSize = 3;

                }

                pageSize = newPageSize;
                ShowList();
            }
        }
    }
}