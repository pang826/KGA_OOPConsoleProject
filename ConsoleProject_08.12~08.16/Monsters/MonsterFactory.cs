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
        public static Monster SpawnMon(int num)
        {
                if (num == (int)Enums.MonsterType.MagmaSlime)
                {
                    MagmaSlime magmaSlime = new MagmaSlime();
                    return magmaSlime;
                }
                else if (num == (int)Enums.MonsterType.MagmaGolem)
                {
                    MagmaGolem magmaGolem = new MagmaGolem();
                    return magmaGolem;
                }
                else if(num == (int)Enums.MonsterType.IceSlime)
                {
                    IceSlime iceSlime = new IceSlime();
                    return iceSlime;
                }
                else if(num == (int)Enums.MonsterType.IceGolem)
                {
                    IceGolem iceGolem = new IceGolem();
                    return iceGolem;
                }
                else if(num == (int)Enums.MonsterType.EarthSlime)
                {
                    EarthSlime earthSlime = new EarthSlime();
                    return earthSlime;
                }
                else if (num == (int)Enums.MonsterType.EarthGolem)
                {
                    EarthGolem earthGolem = new EarthGolem();
                    return earthGolem;
                }
                else { return null; }
        }
    }
}
