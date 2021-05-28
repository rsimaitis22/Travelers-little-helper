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
    /// Interaction logic for PackingHelperWindow.xaml
    /// </summary>
    public partial class PackingHelperWindow : Window
    {
        DatabaseViewerService dbService;
        SeasonEnum season;
        List<ItemData> items;
        JourneyData data;
        int distance;

        public PackingHelperWindow(int distance, SeasonEnum season)
        {
            InitializeComponent();
            this.distance = distance;
            this.season = season;
            this.Title = "Things you will need";

            dbService = new DatabaseViewerService();
            data = new JourneyData();
            items = new List<ItemData>();

            CalculateTripInfo();
            PopulateList();
        }
        private void PopulateList()
        {
            if (data.Overnight)
                items.AddRange(dbService.GetOvernightStuff());
            
            items.AddRange(dbService.GetEssentials());
            items.AddRange(dbService.GetSeasonalStuff(season));

            FormatEssentialItems();

            lstBoxSidePanel.ItemsSource = items;
        }

        private void FormatEssentialItems()
        {
            var temp = items.FirstOrDefault(x => x.Name == "Food");
            temp.Description += data.Food;
            temp = items.FirstOrDefault(x => x.Name == "Water");
            temp.Description += data.Water;
        }

        private void CalculateTripInfo()
        {
            JourneyCalculations jc = new JourneyCalculations(distance);
            data.Food = jc.CalculateFood();
            data.Water = jc.CalculateWater();
            data.Overnight = jc.CheckIfOvernight();
        }
        private void grdList_PreviewMouseDown(object sender, RoutedEventArgs e)
        {

        }

        private void sidePanelScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scv = (ScrollViewer)sender;
            scv.ScrollToVerticalOffset(scv.VerticalOffset - e.Delta);
            e.Handled = true;
        }
    }
    class JourneyData
    {
        public int Food { get; set; }
        public decimal Water { get; set; }
        public bool Overnight { get; set; }
    }
}
