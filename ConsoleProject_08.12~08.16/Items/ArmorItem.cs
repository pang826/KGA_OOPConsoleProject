using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Items
{
    public class ArmorItem : Item, IEnableEquip
    {
        public int plusDef {  get; set; }
        public int Cost { get; set; }

        public ArmorItem(string name, string description, int cost) : base(name, description) 
        {
            this.Name = name;
            this.Description = description;
            this.Cost = cost;
        }

        public void ItemDefense(int def)
        {
            this.plusDef = def;
        }

        public override void InputInven()
        {
            player.inventory.AddItem(this);
        }

        public override void OutputInven()
        {
            player.inventory.RemoveItem(this);
        }

        public void Equip()
        {
            player.curArmor = this;
            player.def += this.plusDef;
        }

        public void UnEquip()
        {
            player.curArmor = null;
            player.def -= this.plusDef;
        }
    }
    
}
