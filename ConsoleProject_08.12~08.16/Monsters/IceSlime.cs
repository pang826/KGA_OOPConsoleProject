﻿using ConsoleProject_08._12_08._16.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Monsters
{
    internal class IceSlime : Monster
    {
        public IceSlime() 
        {
            this.name = "아이스 슬라임";
            this.hp = 50;
            this.dmg = 10;
            this.def = 3;
            dropItem = new DropItem("얼음 부스러기", "아이스 슬라임의 부산물");
        }
        public override void ItemDrop()
        {
            player.dropInventory.AddDropItem(dropItem);
        }
    }
}
