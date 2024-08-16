using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProject_08._12_08._16.Items;

namespace ConsoleProject_08._12_08._16.Monsters
{
    public class MagmaSlime : Monster
    {
        public MagmaSlime() 
        {
            this.name = "마그마 슬라임";
            this.hp = 50;
            this.dmg = 10;
            this.def = 3;
            dropItem = new DropItem("타고남은 재", "마그마 슬라임의 부산물");

        }
        public override void ItemDrop()
        {
            player.dropInventory.AddDropItem(dropItem);
        }
    }
}
