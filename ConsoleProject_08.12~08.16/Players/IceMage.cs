﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Players
{
    internal class IceMage : Player
    {
        public IceMage(string name, Enums.JobType jobType) : base(name, jobType) { }
        public override void Skill()
        {
            throw new NotImplementedException();
        }
    }
}
