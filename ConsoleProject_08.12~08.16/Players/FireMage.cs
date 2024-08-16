using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleProject_08._12_08._16.Monsters;

namespace ConsoleProject_08._12_08._16.Players
{
    internal class FireMage : Player
    {
        public FireMage(string name, Enums.JobType jobType) : base(name, jobType) { }
            
        public override void Skill(Monster monster)
        {
            Console.WriteLine("스킬을 시전합니다.");
            Waits.Wait(1);
            Console.WriteLine("\"파이어 볼\"");
            monster.hp -= ((this.dmg - monster.def) * 3 );
            this.curMp -= 20;
        }
    }
}
