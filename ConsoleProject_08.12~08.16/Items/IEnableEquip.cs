using ConsoleProject_08._12_08._16.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Items
{
    internal interface IEnableEquip
    {
        public void Equip(Player player);

        public void UnEquip(Player player);
    }
}
