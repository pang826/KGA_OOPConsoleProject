using ConsoleProject_08._12_08._16.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Monsters
{
    internal class Monster
    {
        public string name { get; set; }
        public int hp { get; set; }
        public int dmg { get; set; }
        public int def;
        public string dropItem;

        public void TakeDamage(Player player)
        {
            this.hp -= (this.def - player.dmg);
        }

        public void ItemDrop()
        {

        }
    }
}
