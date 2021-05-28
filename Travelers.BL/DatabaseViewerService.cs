using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelers.BL
{
    public class DatabaseViewerService
    {
        DummyDatabase db = new DummyDatabase();

        public List<ItemData> GetEssentials()
        {
            return db.Database.Where(x => x.IsEssential).ToList();
        }
        public List<ItemData> GetOvernightStuff()
        {
            return db.Database.Where(x => x.IsOvernight).ToList();
        }
        public List<ItemData> GetSeasonalStuff(SeasonEnum season)
        {
            return db.Database.Where(x => x.Season == season).ToList();
        }
    }
}
