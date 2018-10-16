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

            Loaded += new RoutedEventHandler(MainWindow_Loaded);        //when the mainwindow is loaded, proceed to this function
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var createDB = new DBClass();            
            List<Author> authors = new List<Author>();
            authors = createDB.DBData(); //reading the data from DB 
            booksHierarchy.ItemsSource = authors; //setting the ItemsSource for the TreeView 
        }
    }
}
