using ConsoleProject_08._12_08._16.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Items
{
    public class WeaponItem : PlayerItem, IEnableEquip
    {
        public int plusDmg { get; set; }

        public WeaponItem(string name, string description, int cost) : base(name, description, cost) { }

        public void Equip(Player player)
        {
            player.curWeapon = this;
            player.dmg += this.plusDmg;
        }

        public void UnEquip(Player player)
        {
            player.curWeapon = null;
            player.dmg -= this.plusDmg;
        }

        public void WeaponInputDmg(int dmg)
        {
            this.plusDmg = dmg;
        }
    }
}
