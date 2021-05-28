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

namespace Travelers_little_helper
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            //Open New window 
            //Select season and distance
            //Create empty file if not exist, if exist rewrite to empty
            //Get data from data layer
            //Open packing window
            //Populate with dummy data
            //On save or on close save to file

            NewAdventureWindow newAdventure = new NewAdventureWindow();
            newAdventure.Show();
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {
            //Open existing file
            //Open packing window
            //Populate with data from file
        }
    }
}
