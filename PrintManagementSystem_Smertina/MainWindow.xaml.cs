using Microsoft.SqlServer.Server;
using System;
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

namespace PrintManagementSystem_Smertina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<TypeOperation> typeOperationList = TypeOperation.AllTypeOperation();
        public List<Format> formatsList = Format.AllFormats();

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            foreach (TypeOperation items in typeOperationList)
            {
                typeOperation.Items.Add(items.name);
            }

            foreach (Format item in formatsList)
            {
                formats.Items.Add(item.format);
            }
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void SelectedType(object sender, SelectionChangedEventArgs e)
        {
            // Реализация будет в шаге 17
        }

        private void SelectedFormat(object sender, SelectionChangedEventArgs e)
        {
            // Реализация будет в шаге 18
        }

        private void textBoxCount_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Реализация будет в шаге 19
        }

        private void ColorsChange(object sender, RoutedEventArgs e)
        {
            // Реализация будет в шаге 20
        }

        private void AddOperation(object sender, RoutedEventArgs e)
        {
            // Реализация будет в шаге 21
        }

        private void EditOperation(object sender, RoutedEventArgs e)
        {
            // Реализация будет в шаге 22
        }

        private void DeleteOperation(object sender, RoutedEventArgs e)
        {
            // Реализация будет в шаге 23
        }
    }
}