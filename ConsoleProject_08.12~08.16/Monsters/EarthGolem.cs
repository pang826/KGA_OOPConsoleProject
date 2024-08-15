using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Monsters
{
    internal class EarthGolem : Monster
    {
        public EarthGolem() 
        {
            this.name = "대지 골렘";
            this.hp = 300;
            this.dmg = 25;
            this.def = 10;
            this.dropItem = "딱딱한 심장";
        }
        public override void ItemDrop()
        {

        }
    }
}
