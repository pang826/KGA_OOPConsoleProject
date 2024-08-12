using ConsoleProject_08._12_08._16.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Monsters
{
    public class MonsterFactory
    {
        Player player;
        public string name {  get; set; }
        public int hp {  get; set; }
        public int dmg {  get; set; }
        public int def;
        public string dropItem;
        private bool yesNo;

        public MonsterFactory(string name)
        {
            yesNo = true;
            this.name = name;
            do
            {
                if (this.name == "마그마슬라임")
                {
                    Monster monster = new Monster();
                    this.name = "마그마슬라임";
                    this.hp = 100;
                    this.dmg = 10;
                    this.def = 3;
                    this.dropItem = "타고남은 재";
                    yesNo = false;
                }
                else
                {
                    name = null;
                    Console.WriteLine("잘못된 값 입력");
                }
            } while(yesNo);
        }

        public void TakeDamage(Monster monster, Player player) 
        {
            monster.hp -= (player.dmg - monster.def);
        }
        public void ItemDrop(string dropItem) { }
    }
}
