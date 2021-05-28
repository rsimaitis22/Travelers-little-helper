using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelers.BL
{
    public class ItemData
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsEssential { get; set; }
        public bool IsOvernight { get; set; }
        public SeasonEnum? Season{ get; set; }
    }
}
