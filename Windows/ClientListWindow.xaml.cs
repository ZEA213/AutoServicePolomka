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
using static AutoServicePolomka.EF.AppData;
using AutoServicePolomka.EF;

namespace AutoServicePolomka.Windows
{
    /// <summary>
    /// Логика взаимодействия для ClientListWindow.xaml
    /// </summary>
    public partial class ClientListWindow : Window
    {
        private List<View_Client> ListClients = new List<View_Client>();

        public ClientListWindow()
        {
            InitializeComponent();
            ListClients = Context.View_Client.OrderBy(i => i.ID).ToList();
            TBElementsCount.Text = Context.View_Client.Count().ToString();


            LVClient.ItemsSource = ListClients;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LVClient_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void CB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}