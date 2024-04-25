using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeRPG
{
    internal class Status
    {
        public int level { get; set; }
        public string name { get; set; }
        public string job { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int health { get; set; }
        public int gold { get; set; }


        public Status(int Level, string Name, string Job, int Att, int Def, int Hearth, int Gold)
        {
            level = Level;
            name = Name;
            job =  Job;
            attack = Att;
            defense = Def;
            health = Hearth;
            gold = Gold;
        }

        public void InfoStatus()
        {
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");

            Console.WriteLine($"Lv. {level}");
            Console.WriteLine($"{name} : ( {job} )");
            Console.WriteLine($"공격력 : {attack}");
            Console.WriteLine($"방어력 : {defense}");
            Console.WriteLine($"체 력 : {health}");
            Console.WriteLine($"Gold : {gold} G\n");

            Console.WriteLine("0. 나가기\n");

            Console.Write("원하시는 행동을 입력해주세요.\n>> ");
        }
    }
}
