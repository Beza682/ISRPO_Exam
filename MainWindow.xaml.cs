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

namespace ISRPO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DatabaseEntities db;
        public MainWindow()
        {
            InitializeComponent();
            db = new DatabaseEntities();
        }
        private void Click(object sender, RoutedEventArgs e)
        {
            Class cl = new Class();
            if (cl.Add((Row.SelectedItem as Row).Id, (Place.SelectedItem as Place).Id) == true)
            {
                Row.SelectedIndex = -1;
                Place.SelectedIndex = -1;
                db = new DatabaseEntities();
                BookingGrid.ItemsSource = db.Booking.ToList();
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            BookingGrid.ItemsSource = db.Booking.ToList();
            Row.ItemsSource = db.Row.ToList();
            Place.ItemsSource = db.Place.ToList();
        }
    }
}
