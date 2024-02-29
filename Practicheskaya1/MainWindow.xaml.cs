using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Practicheskaya1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DateTime? today = DateTime.Today;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Registr(object sender, RoutedEventArgs e)
        {
            DateTime? selectedDate = Birthday.SelectedDate;

            MessageBox.Show($"Успешная регистрация: \n{FirstName.Text} {LastName.Text} {Patronymic.Text} {selectedDate.Value.Date.ToShortDateString()} \n дата регистрации {today.Value.Date.ToShortDateString()}");
        }
    }
}
