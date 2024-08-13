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
        Enums.MonsterType monsterType;
        public string name {  get; set; }
        public int hp {  get; set; }
        public int dmg {  get; set; }
        public int def;
        public string dropItem;
        private bool yesNo;

        public MonsterFactory(Enums.MonsterType monType)
        {
            yesNo = true;
            do
            {
                if (monType == Enums.MonsterType.MagmaSlime)
                {
                    Monster monster = new Monster();
                    this.name = "마그마 슬라임";
                    this.hp = 50;
                    this.dmg = 10;
                    this.def = 3;
                    this.dropItem = "타고남은 재";
                    yesNo = false;
                }
                else if (monType == Enums.MonsterType.MagmaGolem)
                {
                    Monster monster = new Monster();
                    this.name = "마그마 골렘";
                    this.hp = 300;
                    this.dmg = 25;
                    this.def = 10;
                    this.dropItem = "뜨거운 심장";
                    yesNo = false;
                }
                else if(monType == Enums.MonsterType.IceSlime)
                {
                    Monster monster = new Monster();
                    this.name = "아이스 슬라임";
                    this.hp = 50;
                    this.dmg = 10;
                    this.def = 3;
                    this.dropItem = "얼음 부스러기";
                    yesNo = false;
                }
                else if(monType == Enums.MonsterType.IceGolem)
                {
                    Monster monster = new Monster();
                    this.name = "아이스 골렘";
                    this.hp = 300;
                    this.dmg = 25;
                    this.def = 10;
                    this.dropItem = "얼어붙은 심장";
                    yesNo = false;
                }
                else if(monType == Enums.MonsterType.EarthSlime)
                {
                    Monster monster = new Monster();
                    this.name = "대지 슬라임";
                    this.hp = 50;
                    this.dmg = 10;
                    this.def = 3;
                    this.dropItem = "딱딱한 돌";
                    yesNo = false;
                }
                else if (monType == Enums.MonsterType.EarthGolem)
                {
                    Monster monster = new Monster();
                    this.name = "대지 골렘";
                    this.hp = 300;
                    this.dmg = 25;
                    this.def = 10;
                    this.dropItem = "딱딱한 심장";
                    yesNo = false;
                }
            } while(yesNo);
        }

        

    }
}
