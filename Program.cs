using System.Diagnostics;

namespace Chap2_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            MainMenu();
            while (isRunning)
            {
                Console.Write("원하시는 행동을 선택해주세요.\n>> ");

                string userInput = Console.ReadLine();
                Console.Clear();

                switch (userInput)
                {
                    case "1":
                        UserAbility userAbility = new UserAbility();
                        userAbility.ShowUserAbility();
                        break;
                    case "2":
                        Inventory inventory = new Inventory();
                        inventory.InitItems();
                        break;
                    case "3":
                       Store store = new Store();
                       store.ShowStore_buy();
                       break;
                    case "0":
                       MainMenu();
                       isRunning = true;
                       break;
                    default:
                       Console.WriteLine("잘못된 입력입니다.\n");
                       break;
                }
            }
        }
        public static void MainMenu()
        {
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.\n");

            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점\n");
        }
    }
}
