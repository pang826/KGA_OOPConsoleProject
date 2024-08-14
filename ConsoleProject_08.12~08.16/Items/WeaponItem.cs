using ConsoleProject_08._12_08._16.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Items
{
    public class WeaponItem : Item, IEnableEquip
    {
        public int plusDmg { get; private set; }
        public int cost { get; set; }

        public WeaponItem(string name, string description, int cost) : base(name, description) 
        {
            this.Name = name;
            this.cost = cost;
        }

        public void ItemDamage(int dmg)
        {
            this.plusDmg = dmg;
        }

        public override void InputInven()
        {
            if (player.gold > this.cost)
            {
                player.inventory.AddItem(this);
            }
            else
            {
                Console.WriteLine("골드가 부족합니다");
            }
        }

        public override void OutputInven()
        {
            player.inventory.RemoveItem(this);
        }
        public void Equip()
        {
            player.curWeapon = this;
            player.dmg += this.plusDmg;
        }

        public void UnEquip()
        {
            player.curWeapon = null;
            player.dmg -= this.plusDmg;
        }
    }
}
