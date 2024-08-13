﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProject_08._12_08._16;

namespace ConsoleProject_08._12_08._16.Players
{
    public class Player
    {
        public Enums.JobType JobType;
        public string name;
        public int maxHp {  get; set; }
        public int curHp {  get; set; }
        public int maxMp { get; set; }
        public int curMp { get; set; }
        public int dmg { get; set; }
        public int def {  get; set; }
        public int gold { get; set; }
        public int evasion { get; set; }
        public string[] inventory;

        public void PrintStat()
        {
            Console.WriteLine(this.JobType);
            Console.WriteLine(this.name);
            Console.WriteLine($"전체체력 : {this.maxHp} / 현재체력 : {this.curHp}");
            Console.WriteLine($"전체마나 : {this.maxMp} / 현재마나 : {this.curMp}");
            Console.WriteLine($"데미지 : {this.dmg}");
            Console.WriteLine($"방어력 : {this.def}");
            Console.WriteLine($"골드량 : {this.gold}G");
            Console.WriteLine($"회피력 : {this.evasion}G");
            Console.WriteLine($"인벤토리 : {this.inventory}G");
        }
        // public void Skill();
    }
}
