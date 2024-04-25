using System;

namespace Chap2_Project
{
    internal class Store
    {
        public void ShowStore()
        {
            Console.WriteLine("상점");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");

            Console.WriteLine("[ 보유 골드 ]");
            Console.WriteLine(" G");
            Console.WriteLine();

            Console.WriteLine("[ 아이템 목록 ]");
            Console.WriteLine("- 수련자 갑옷    | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.             |  1000 G");
            Console.WriteLine("- 무쇠갑옷      | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.           |  구매완료");
            Console.WriteLine("- 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  3500 G");
            Console.WriteLine("- 낡은 검      | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.            |  600 G");
            Console.WriteLine("- 청동 도끼     | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.        |  1500 G");
            Console.WriteLine("- 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다. |  구매완료");
            Console.WriteLine();

            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
        }

        public void ShowStore_buy()
        {
            Console.Clear();
            Console.WriteLine("상점 - 아이템 구매");
            Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");

            Console.WriteLine("[ 보유 골드 ]");
            Console.WriteLine(" G");
            Console.WriteLine();

            Console.WriteLine("[ 아이템 목록 ]");
            Console.WriteLine("- 수련자 갑옷    | 방어력 +5  | 수련에 도움을 주는 갑옷입니다.             |  1000 G");
            Console.WriteLine("- 무쇠갑옷      | 방어력 +9  | 무쇠로 만들어져 튼튼한 갑옷입니다.           |  구매완료");
            Console.WriteLine("- 스파르타의 갑옷 | 방어력 +15 | 스파르타의 전사들이 사용했다는 전설의 갑옷입니다.|  3500 G");
            Console.WriteLine("- 낡은 검      | 공격력 +2  | 쉽게 볼 수 있는 낡은 검 입니다.            |  600 G");
            Console.WriteLine("- 청동 도끼     | 공격력 +5  |  어디선가 사용됐던거 같은 도끼입니다.        |  1500 G");
            Console.WriteLine("- 스파르타의 창  | 공격력 +7  | 스파르타의 전사들이 사용했다는 전설의 창입니다. |  구매완료");
            Console.WriteLine();

            Console.WriteLine("1. 아이템 구매");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
        }
    }

    internal class Storeitem
    {
        static void initstore(string[] args)
        {
            Store store = new Store();
            int gold = 800; // 초기 보유 골드 설정

            while (true)
            {
                store.ShowStore(); // 상점 출력

                Console.Write("\n원하시는 행동을 입력해주세요: ");
                string input = Console.ReadLine();
                Console.Clear();

                if (input == "0")
                    break;
                else if (input == "1")
                {
                    store.ShowStore_buy(); // 아이템 구매 메뉴 출력

                    // 사용자로부터 아이템 번호 입력 받기
                    Console.Write("\n구매할 아이템의 번호를 입력해주세요: ");
                    int itemNumber;
                    if (int.TryParse(Console.ReadLine(), out itemNumber))
                    {
                        // 아이템 번호에 따라 구매 여부 결정
                        switch (itemNumber)
                        {
                            case 1:
                                if (gold >= 1000)
                                {
                                    gold -= 1000;
                                    Console.WriteLine("\n수련자 갑옷을 구매하였습니다.");
                                }
                                else
                                {
                                    Console.WriteLine("\nGold가 부족합니다.");
                                }
                                break;
                            case 2:
                                Console.WriteLine("\n무쇠갑옷은 이미 구매한 아이템입니다.");
                                break;
                            case 3:
                                if (gold >= 3500)
                                {
                                    gold -= 3500;
                                    Console.WriteLine("\n스파르타의 갑옷을 구매하였습니다.");
                                }
                                else
                                {
                                    Console.WriteLine("\nGold가 부족합니다.");
                                }
                                break;
                            case 4:
                                if (gold >= 600)
                                {
                                    gold -= 600;
                                    Console.WriteLine("\n낡은 검을 구매하였습니다.");
                                }
                                else
                                {
                                    Console.WriteLine("\nGold가 부족합니다.");
                                }
                                break;
                            case 5:
                                if (gold >= 1500)
                                {
                                    gold -= 1500;
                                    Console.WriteLine("\n청동 도끼를 구매하였습니다.");
                                }
                                else
                                {
                                    Console.WriteLine("\nGold가 부족합니다.");
                                }
                                break;
                            case 6:
                                Console.WriteLine("\n스파르타의 창은 이미 구매한 아이템입니다.");
                                break;
                            default:
                                Console.WriteLine("\n잘못된 입력입니다.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n잘못된 입력입니다.");
                    }
                }
                else
                {
                    Console.WriteLine("\n잘못된 입력입니다.");
                }

                Console.WriteLine();
            }
        }
    }
}
