using ConsoleProject_08._12_08._16.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Items
{
    public class ArmorItem : PlayerItem, IEnableEquip
    {
        public Player player { get; set; }
        public int plusDef { get; set; }

        public ArmorItem(string name, string description, int cost) : base(name, description, cost) 
        {
            this.Name = name;
            this.Description = description;
            this.Cost = cost;
        }

        public void Equip(Player player)
        {
            player.curArmor = this;
            player.def += this.plusDef;
        }

        public void UnEquip(Player player)
        {
            player.curArmor = null;
            player.def -= this.plusDef;
        }

        public void ArmorInputDef(int def)
        {
            this.plusDef = def;
        }
    }
    
}
