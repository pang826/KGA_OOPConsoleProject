using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProject_08._12_08._16;
using ConsoleProject_08._12_08._16.Inventorys;
using ConsoleProject_08._12_08._16.Items;
using ConsoleProject_08._12_08._16.Monsters;

namespace ConsoleProject_08._12_08._16.Players
{
    public abstract class Player
    {
        public WeaponItem? curWeapon;
        public ArmorItem? curArmor;
        public Inventory inventory;
        public DropInventory dropInventory;
        public Enums.JobType JobType;

        public string name;
        public int maxHp {  get; set; }
        public int curHp {  get; set; }
        public int maxMp { get; set; }
        public int curMp { get; set; }
        public int dmg { get; set; }
        public int def {  get; set; }
        public int gold { get; set; }
        //public int evasion { get; set; }
        // attribute 추가 예정 (속성)
        public Player(string name, Enums.JobType jobType) 
        {
            this.name = name;
            this.JobType = jobType;
            this.maxHp = 100;
            this.curHp = 100;
            this.maxMp = 100;
            this.curMp = 100;
            this.dmg = 10;
            this.def = 0;
            this.gold = 250;
            //this.evasion = 10;
            this.inventory = new Inventory();
            this.dropInventory = new DropInventory();
        }
        public void PrintStat()
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine($"직업 : { this.JobType}");
            Console.WriteLine($"이름 : {this.name}");
            Console.WriteLine($"전체체력 : {this.maxHp} / 현재체력 : {this.curHp}");
            Console.WriteLine($"전체마나 : {this.maxMp} / 현재마나 : {this.curMp}");
            Console.WriteLine($"데미지 : {this.dmg}");
            Console.WriteLine($"방어력 : {this.def}");
            Console.WriteLine($"골드량 : {this.gold}G");
            //Console.WriteLine($"회피력 : {this.evasion}");
            Console.Write("장비 인벤토리 : ");
            ShowInven();
            Console.Write("드랍템 인벤토리 : ");
            ShowDropInven();
            Console.WriteLine();
            Console.WriteLine("=======================================================");
        }
        
        public abstract void Skill(Monster monster);

        public void ShowInven()
        {
            for(int i = 0; i < inventory.GetInvenCount(); i++)
            {
                Console.Write($"|{inventory[i].Name}|");
            }
            Console.WriteLine();
        }

        public void ShowDropInven()
        {
            for (int i = 0; i < dropInventory.GetDropCount(); i++)
            {
                Console.Write($"|{dropInventory[i].Name}|");
            }
            Console.WriteLine();
        }
    }
}
