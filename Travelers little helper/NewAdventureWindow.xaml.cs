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
using Travelers.BL;

namespace Travelers_little_helper
{
    /// <summary>
    /// Interaction logic for NewAdventureWindow.xaml
    /// </summary>
    public partial class NewAdventureWindow : Window
    {
        SeasonEnum? seasonEn = null;
        int distance;

        public NewAdventureWindow()
        {
            InitializeComponent();
        }
        private void CheckForPackButton()
        {
            if (distance > 0 && seasonEn != null)
                btnPack.IsEnabled = true;
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            distance += 1;
            lblActualDistance.Content = distance.ToString();
            CheckForPackButton();
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (distance > 0)
                distance -= 1;

            lblActualDistance.Content = distance.ToString();
            CheckForPackButton();
        }
        private void img_Click(object sender, RoutedEventArgs e)
        {
            var temp = (Image)sender;
            SelectSeason(temp);
        }
        private void btnPack_Click(object sender, RoutedEventArgs eventArgs)
        {
            PackingHelperWindow helper = new PackingHelperWindow(distance, (SeasonEnum)seasonEn);
            helper.Show();
            this.Close();
        }


        private void SelectSeason(Image temp)
        {
            if (temp.Name == "imgWinter")
            {
                seasonEn = SeasonEnum.Winter;
                lblSeason.Content = seasonEn;
            }
            if (temp.Name == "imgSpring")
            {
                seasonEn = SeasonEnum.Spring;
                lblSeason.Content = seasonEn;
            }
            if (temp.Name == "imgSummer")
            {
                seasonEn = SeasonEnum.Summer;
                lblSeason.Content = seasonEn;
            }
            if (temp.Name == "imgAutumn")
            {
                seasonEn = SeasonEnum.Autumn;
                lblSeason.Content = seasonEn;
            }
            CheckForPackButton();
        }
    }
}
