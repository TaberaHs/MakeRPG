using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeRPG
{
    internal class Inventory
    {
        public List<Item> items;

        public Inventory()
        {
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");


            Console.WriteLine("[아이템 목록]");

            if (items.Count == 0)
            {                
                Console.WriteLine("아이템이 없습니다.\n");
                return;
            }

            for (int i = 0; i < items.Count; i++)
            {
                string equiped = "";

                if (items[i].equip)
                {
                    equiped = "[E] ";
                }
                else
                {
                    equiped = "";
                }
                Console.WriteLine($"{i + 1}. {equiped}{items[i].name} | {items[i].statType} +{items[i].statBonus} | {items[i].description}");
            }

            Console.WriteLine("0. 나가기\n");
        }
    }    
}

