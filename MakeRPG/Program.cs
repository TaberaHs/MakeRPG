using System.Numerics;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace MakeRPG
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            Status status = new Status();

            bool continuePlay = true;

            


            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.\n이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");

            while (continuePlay)
            {
                templateForGuide();
                templateForCommend();

                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    // 선택에 따라 각각의 기능 실행
                    switch (choice)
                    {
                        case 1:
                            Status();
                            break;
                        case 2:
                            Inventory();
                            break;
                        case 3:
                            Shop();
                            break;
                        default:
                            Console.WriteLine("잘못된 입력입니다.\n");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.\n");
                }

            }
        }
       
        static void Status()
        {
            
        }

        static void Inventory()
        {
            Console.WriteLine("인벤토리 기능을 실행합니다.\n");
            // 여기에 인벤토리 기능 구현
        }

        static void Shop()
        {
            Console.WriteLine("상점 기능을 실행합니다.\n");
            // 여기에 상점 기능 구현
        }


        static void templateForGuide()
        {
            Console.WriteLine("1. 상태 보기\n2. 인벤토리\n3. 상점");
        }
        static void templateForCommend()
        {
            Console.WriteLine("원하시는 행동을 입력해주세요.\n>>>>>>>>>>");
        }        
    }
}
