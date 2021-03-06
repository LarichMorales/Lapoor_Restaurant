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

namespace Lapoor_Restaurant.POS.Categories
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
        private Guid? parentId = null;

        public object CategoryBLL { get; private set; }

        public List(Guid? parentId = null, string parentName = "")
        {
            InitializeComponent();

            if (string.IsNullOrEmpty(parentName) == false)
            {
                lblTitle.Content = "Categories under " + parentName;
            }

            cboSortOrder.ItemsSource = Enum.GetValues(typeof(SortOrder)).Cast<SortOrder>();
            cboSortOrder.SelectedIndex = 0;
            this.parentId = parentId;
            showList();
        }

        private void showList()
        {
            Page <Category> categories = CategoryBLL.Search(pageSize, pageIndex, sortOrder, keyword, this.parentId);
            lblPages.Content = "page " + pageIndex + " of " + categories.PageCount;
            lblResults.Content = "Search Result : " + categories.QueryCount + " Categories";
            queryCount = categories.QueryCount;
            pageCount = categories.PageCount;
            grList.ItemsSource = categories.Items;
            txtPageSize.Text = categories.PageSize.ToString();
        }

        private void BtnLast_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageCount;
            showList();
        }

        private void BtnFirst_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = 1;
            showList();
        }

        private void BtnPrev_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex - 1;

            if (pageIndex < 1)
            {
                pageIndex = 1;
            }

            showList();
        }

        private void BtnNext_Click(object sender, RoutedEventArgs e)
        {
            pageIndex = pageIndex + 1;

            if (pageIndex > pageCount)
            {
                pageIndex = pageCount;
            }

            showList();
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
            showList();
        }

        private void BtnSearch_Click(object sender, RoutedEventArgs e)
        {
            keyword = txtSearch.Text;
            showList();
        }

        private void TxtPageSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                int newPageSize = 3;
                bool result = Int32.TryParse(txtPageSize.Text, out newPageSize);

                if (result == false)
                {
                    newPageSize = 3;

                }

                pageSize = newPageSize;
                showList();
            }
        }


        private void BtnViewChildren_Click(object sender, RoutedEventArgs e)
        {
            Category category = ((FrameworkElement)sender).DataContext as Category;
            Categories.List categoryWindow = new Categories.List(category.ParentId, category.Name);
            categoryWindow.Show();
        }


        private void BtnViewProducts_Click(object sender, RoutedEventArgs e)
        {
            Category category = ((FrameworkElement)sender).DataContext as Category;
            Products.List productWindow = new Products.List(category.ParentId, category.Name);
            productWindow.Show();
        }
    }
}