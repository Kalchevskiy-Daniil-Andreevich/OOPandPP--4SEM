﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Лабораторная_работа___4_5.Class;

namespace Лабораторная_работа___4_5
{
    /// <summary>
    /// Логика взаимодействия для ShowProduct.xaml
    /// </summary>
    public partial class ShowProduct : Window
    {
        public Product product;
        public ShowProduct()
        {
            InitializeComponent();
            product = Serialize.DataDeserialize();
            Products.ItemsSource = product.bookList;
            Products.AutoGeneratedColumns += dg_AutoGeneratedColumns;
        }

        void dg_AutoGeneratedColumns(object sender, EventArgs e)
        {
            Products.Columns[0].Header = "Название книги";
            Products.Columns[1].Header = "Формат книги";
            Products.Columns[2].Header = "Категория книги";
            Products.Columns[3].Header = "Издательство книги";
            Products.Columns[4].Header = "Страна производства";
            Products.Columns[5].Header = "Цена книги";
            Products.Columns[6].Header = "Размер файла книги";
            Products.Columns[7].Header = "Автор книги";
        }

        private void ButtonCloseApp_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void addProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }

        private void ChangeProduct_Click(object sender, RoutedEventArgs e)
        {
            var selectedBook = (Book)Products.SelectedItem;

            EditProduct editProduct = new EditProduct(selectedBook);
            editProduct.Owner= this;

            if(selectedBook != null)
            {
                if(editProduct.ShowDialog() != true)
                {
                    selectedBook.NameBook = editProduct.NameBook.Text;
                    selectedBook.FormatBook = editProduct.FormatBook.Text;
                    selectedBook.Categories = editProduct.CategoriesBook.Text;
                    selectedBook.PublishingBook = editProduct.PublishingBook.Text;
                    selectedBook.Country = editProduct.CountryBook.Text;
                    selectedBook.CostBook = editProduct.CostBook.Text;
                    selectedBook.SizeBook= editProduct.SizeBook.Text;
                    selectedBook.AuthorBook = editProduct.AuthorBook.Text;

                    foreach(Book book in product.bookList)
                    {
                        if (book == (Book)Products.SelectedItem)
                            product.bookList[product.bookList.IndexOf(book)] = selectedBook;
                        break;
                    }
                    Serialize.DataSerialize(product);
                    Products.ItemsSource = product.bookList;
                }
            }
        }

        private void deleteProduct_Click(object sender, RoutedEventArgs e)
        {
            product.bookList.Remove((Book)Products.SelectedItem);
            Serialize.DataSerialize(product);
            Products.ItemsSource = product.bookList;
        }

        private void searchProduct_Click(object sender, RoutedEventArgs e)
        {
            var searchedItems = new Product();
            foreach(var book in product.bookList)
            {
                string pattern = @"^" + search.Text + @"\w*";
                if(book.NameBook == search.Text)
                    searchedItems.Add(book);
                else if (Regex.IsMatch(book.NameBook, pattern))
                    searchedItems.Add(book);
            }

            Products.ItemsSource = searchedItems.bookList;
        }

        private void filtrProduct_Click(object sender, RoutedEventArgs e)
        {
            var sortedList = new Product();
            if (filterProduct.SelectedIndex == 0)
            {
                foreach (Book book in product.bookList)
                {
                    if (book.FormatBook == tb_filterType.Text)
                    {
                        sortedList.Add(book);
                    }
                }
                Products.ItemsSource = sortedList.bookList;
            }
        }

        private void filterProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(filterProduct.SelectedIndex == 0)
            {
                tb_filterType.Visibility = Visibility.Visible;
            }
        }
    }
}
