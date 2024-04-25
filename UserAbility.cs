using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Chap2_Project
{
    struct user
    {
        public string Name;
        public string Type;
        public int Level;
        public int Attack;
        public int Defense;
        public int Health;
        public int Gold;
    }

    internal class UserAbility
    {
        public user user;

        public UserAbility()
        {
            initability();
        }

        public void initability()
        {
            user = new user();
            user.Name = "Chad";
            user.Type = "전사";
            user.Level = 1;
            user.Attack = 10;
            user.Defense = 5;
            user.Health = 100;
            user.Gold = 1500;
        }

        public void ShowUserAbility()
        {
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");

            Console.WriteLine("Lv." + user.Level);
            Console.WriteLine(user.Name + " " + "( " + user.Type + " )");
            Console.WriteLine("공격력 : " + user.Attack);
            Console.WriteLine("방어력 : " + user.Defense);
            Console.WriteLine("체 력 : " + user.Health);
            Console.WriteLine("Gold : " + user.Gold + " G");
            Console.WriteLine();

            Console.WriteLine("0. 나가기");
            Console.WriteLine();
        }
    }
}
