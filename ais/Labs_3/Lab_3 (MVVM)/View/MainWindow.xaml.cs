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
using ViewModel;

namespace View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainModel DataModel => (MainModel) DataContext; 

        public MainWindow()
        {
            DataContext = new MainModel();
            InitializeComponent();
            ComboBoxStatus.ItemsSource = DataModel.ListStatus;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            DataModel.AddEmployee();
            UpdateTable();
        }

        private void ButtonDelete_Click(object sender, RoutedEventArgs e)
        {
            DataModel.DeleteEmployee();
            UpdateTable();
        }

        private void UpdateTable()
        {
            ListView.ItemsSource = DataModel.ListEmployee;
        }
    }
}
