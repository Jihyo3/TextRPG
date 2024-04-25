using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap2_Project
{
    internal class InventoryItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public bool Equip { get; set; }

        public InventoryItem(string name, string description, int attack, int defense)
        {
            Name = name;
            Description = description;
            Attack = attack;
            Defense = defense;
            Equip = false;
        }

        public void PrintItem()
        {
            string equippedIndicator = Equip ? "[E] " : "";
            Console.WriteLine($"{Name} | {Defense} | {Description}");
        }
        public void ToggleEquip()
        {
            Equip = !Equip;
        }
    }



    internal class Inventory
    {

        private Dictionary<int, InventoryItem> items = new Dictionary<int, InventoryItem>();

        public void AddItem(int itemId, InventoryItem item)
        {
            items.Add(itemId, item);
        }

        public void InitItems()
        {
            AddItem(1, new InventoryItem("무쇠갑옷", "방어력 +5 | 무쇠로 만들어져 튼튼한 갑옷입니다.", 0, 5));
            AddItem(2, new InventoryItem("스파르타의 창", "공격력 +7 | 스파르타의 전사들이 사용했다는 전설의 창입니다.", 7, 0));
            AddItem(3, new InventoryItem("낡은 검", "공격력 +2 | 쉽게 볼 수 있는 낡은 검 입니다.\n", 2, 0));

            while (true)
            {
                ShowInventory();

                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || !items.ContainsKey(choice))
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    continue;
                }

                if (choice == 0)
                    break;

                if (choice == 1)
                {
                    PutInventory();
                }

                InventoryItem selected = items[choice];

                selected.ToggleEquip();

                if (selected.Equip)
                {
                    selected.Equip = false;
                    Console.WriteLine($"{selected.Name}를 장착 해제했습니다.");
                }
                else
                {
                    selected.Equip = true;
                    Console.WriteLine($"{selected.Name}를 장착했습니다.");
                }
            }
        }

        public void ShowInventory()
        {
            Console.Clear();
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");

            Console.WriteLine("[ 아이템 목록 ]");
            Console.WriteLine();

            foreach (InventoryItem item in items.Values)
            {
                item.PrintItem();
            }

            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            
            Console.Write("원하시는 행동을 선택해주세요.\n >> ");

            string userInput = Console.ReadLine();
            Console.Clear();

            switch (userInput)
            {
                case "1":
                    PutInventory();
                    break;

                case "0":
                    Program.MainMenu();
                    break;

                default:
                    Console.WriteLine("잘못된 입력입니다.\n");
                    break;
            }

        }

        public void PutInventory()
        {
            Console.WriteLine("인벤토리 - 장착관리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");

            Console.WriteLine("[ 아이템 목록 ]");
            Console.WriteLine();

            foreach (InventoryItem item in items.Values)
            {
                item.PrintItem();
            }

            string userInput = Console.ReadLine();
            Console.Clear();

            switch (userInput)
            {
                case "1":
                case "2":
                case "3":
                    int itemIndex = int.Parse(userInput);
                    InventoryItem selectedItem = items[itemIndex];

                    selectedItem.ToggleEquip();

                    if (selectedItem.Equip)
                    {
                        selectedItem.Equip = false;
                        Console.WriteLine($"{selectedItem.Name}를 장착 해제했습니다.");
                    }
                    else
                    {
                        selectedItem.Equip = true;
                        Console.WriteLine($"{selectedItem.Name}를 장착했습니다.");
                    }
                    break;

                case "0":
                    break;

                default:
                    Console.WriteLine("잘못된 입력입니다.\n");
                    break;
            }
            Console.WriteLine("0. 나가기");
            Console.WriteLine();

            Console.Write("원하시는 행동을 선택해주세요.\n >> ");
        }
    }
}
