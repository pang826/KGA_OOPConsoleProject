using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Monsters
{
    internal class EarthSlime : Monster
    {
        public EarthSlime() 
        {
            this.name = "대지 슬라임";
            this.hp = 50;
            this.dmg = 10;
            this.def = 3;
            this.dropItem = "딱딱한 돌";
        }
        public override void ItemDrop()
        {

        }
    }
}
