using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeRPG
{
    internal class Item
    {
        public bool equip { get; set; } // 아이템이 장착되었는지 여부
        public string name { get; set; }
        public int statBonus { get; set; }
        public string description { get; set; }
        public string statType { get; set; }

        public Item(string Name, int StatBonus, string StatType, string Description)
        {
            equip = false;
            name = Name;
            statBonus = StatBonus;
            statType = StatType;
            description = Description;
        }
    }
}
