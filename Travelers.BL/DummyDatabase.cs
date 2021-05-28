using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelers.BL
{
    class DummyDatabase
    {
        public List<ItemData> Database { get; set; }

        public DummyDatabase()
        {
            Database = new List<ItemData>()
            {
                new ItemData {Name="Water",Description="Amount you need to drink while travelling is ",IsEssential=true },
                new ItemData {Name="Food",Description="Amount you need to eat while travelling in calories is ", IsEssential=true},
                new ItemData {Name="Hiking backpack", Description="You need to put your stuff somewhere",IsEssential=true},
                new ItemData {Name="Hiking boots", Description="To protect your feet",IsEssential=true},
                new ItemData {Name="Navigation tools",Description="You want to come back now dont you?",IsEssential=true},
                new ItemData {Name="First-aid kit",Description="Better go out prepared",IsEssential=true },
                new ItemData {Name="Multi-tool", Description="Trust me on this one",IsEssential=true },
                new ItemData {Name="Fire starting materials", Description="Fire good", IsEssential=true},
                new ItemData {Name="Toilet paper",Description="Self explanatory, for making papie mashe",IsEssential=true},

                new ItemData {Name="Tent", Description="Last defence against rain and animals",IsEssential=false,IsOvernight=true},
                new ItemData {Name="Sleeping bag",Description="Sleep like a king",IsEssential=false, IsOvernight=true },
                new ItemData {Name="Headlight", Description="Unless you can see in the dark", IsEssential=false,IsOvernight=true},

                new ItemData {Name="Warm socks", Description = "For those cozy winter nights", Season=SeasonEnum.Winter},
                new ItemData {Name="High gaiters", Description = "+3 to water and snow resistances", Season=SeasonEnum.Winter},
                new ItemData {Name="Hat", Description = "Lightweight or heavyweight fleece or wool hat", Season = SeasonEnum.Winter},
                new ItemData {Name="Gloves",Description = "Waterproof shell mitts or gloves, with insulated liners", Season = SeasonEnum.Winter},
                new ItemData {Name="Jacket", Description = "Puffy insulated jacket with attached hood", Season = SeasonEnum.Winter},
                new ItemData {Name="Pants",Description = "Hardshell pants that are waterproof and windproof with full-length zippers along the sides", Season = SeasonEnum.Winter},
                new ItemData {Name="Mid layer insulation", Description = "Fleece jacket, fleece pullover, fleece vest, insulated vest, or softshell jacket (at least one, possibly several)",Season=SeasonEnum.Winter},
                new ItemData {Name="Base layer insulation", Description ="Long sleeve jersey, boxer jock underwear to prevent chafing", Season = SeasonEnum.Winter},
                new ItemData {Name = "Winter traction aids", Description = "Microspikes, Snowshoes (depending on conditions)",Season = SeasonEnum.Winter},

                new ItemData {Name="Pants",Description ="Warm yet breathable leggings",Season = SeasonEnum.Autumn},
                new ItemData {Name="Top", Description="Long sleeve top",Season=SeasonEnum.Autumn },
                new ItemData {Name="Insulated hoodie", Description="Insulated hoodie duh",Season = SeasonEnum.Autumn },
                new ItemData {Name ="Rain jacket", Description="Protection from rain",Season = SeasonEnum.Autumn },
                new ItemData {Name ="Gloves", Description = "For hands only", Season= SeasonEnum.Autumn },
                new ItemData {Name = "Beanie", Description="Beanie",Season = SeasonEnum.Autumn},

                new ItemData {Name="Pants",Description ="Warm yet breathable leggings",Season = SeasonEnum.Spring},
                new ItemData {Name="Top", Description="Long sleeve top",Season=SeasonEnum.Spring },
                new ItemData {Name="Insulated hoodie", Description="Insulated hoodie duh",Season = SeasonEnum.Spring },
                new ItemData {Name ="Rain jacket", Description="Protection from rain",Season = SeasonEnum.Spring },
                new ItemData {Name ="Gloves", Description = "For hands only", Season= SeasonEnum.Spring },
                new ItemData {Name = "Beanie", Description="Beanie",Season = SeasonEnum.Spring}
            };
        }
    }
}
