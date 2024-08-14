using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Items
{
    public class DropItem : Item
    {
        public DropItem(string name, string decription) : base(name, decription) 
        {
            this.Name = name;
            this.Description = decription;
        }

        public override void InputInven()
        {
            player.inventory.AddItem(this);
        }

        public override void OutputInven()
        {
            player.inventory.RemoveItem(this);
        }
    }
}
