using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Monsters
{
    internal class MagmaGolem : Monster
    {
        public MagmaGolem() 
        {
            this.name = "마그마 골렘";
            this.hp = 300;
            this.dmg = 25;
            this.def = 10;
            this.dropItem = "뜨거운 심장";
        }
        public override void ItemDrop()
        {
            
        }
    }
}
