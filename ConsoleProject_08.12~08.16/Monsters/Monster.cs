using ConsoleProject_08._12_08._16.Items;
using ConsoleProject_08._12_08._16.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Monsters
{
    public abstract class Monster
    {
        public DropItem dropItem;
        public Player player;
        public string name { get; set; }
        public int hp { get; set; }
        public int dmg { get; set; }
        public int def;

        public void TakeDamage(Player player)
        {
            this.hp -= (player.dmg - this.def);
        }

        public abstract void ItemDrop();
    }
}
