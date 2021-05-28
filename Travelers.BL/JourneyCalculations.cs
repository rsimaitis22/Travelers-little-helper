using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelers.BL
{
    public class JourneyCalculations
    {
        int currentDistance = 0;
        int oneDayDistance = 30;
        int calDay = 3000;
        decimal literDay = 3.7M;

        public JourneyCalculations(int distance)
        {
            currentDistance = distance;
        }
        public bool CheckIfOvernight()
        {
            return currentDistance > oneDayDistance;
        }
        public decimal CalculateWater()
        {
            var temp = literDay / oneDayDistance;
            return Math.Round( temp * currentDistance, 2);
            //tarkim 3.7 per diena
            //3.7 / 30 -> gaunam per viena km
        }
        public int CalculateFood()
        {
            var temp = calDay / oneDayDistance;
            //tarkim 3000 per diena
            //3000 / 30 - gaunam per diena
            return temp * currentDistance;
        }
    }
}
