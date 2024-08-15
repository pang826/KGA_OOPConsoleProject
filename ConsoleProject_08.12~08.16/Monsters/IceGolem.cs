using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Monsters
{
    internal class IceGolem : Monster
    {
        public IceGolem() 
        {
            this.name = "아이스 골렘";
            this.hp = 300;
            this.dmg = 25;
            this.def = 10;
            this.dropItem = "얼어붙은 심장";
        }
        public override void ItemDrop()
        {

        }
    }
}
