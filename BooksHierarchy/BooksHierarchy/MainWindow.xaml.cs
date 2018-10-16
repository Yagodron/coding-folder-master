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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BooksHierarchy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)    
        {
            var createDB = new DBClass();           // Creating the data in DB
            createDB.CreateData();
            Author auth = new Author();             
            List<Author> authors = new List<Author>();
            authors.AddRange(auth.ReadData());      //reading the data from DB

            booksHierarchy.ItemsSource = authors;            //setting the ItemsSource for the TreeView
        }
    }
}
