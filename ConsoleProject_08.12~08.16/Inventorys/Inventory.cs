using ConsoleProject_08._12_08._16.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Inventorys
{
    public class Inventory
    {
        public List<PlayerItem> inven;

        public Inventory()
        {
            inven = new List<PlayerItem>(9);
        }

        public int GetCount()
        {
            return inven.Count;
        }
        public void AddItem(PlayerItem item)
        {
            inven.Add(item);
        }

        public void RemoveItem(PlayerItem item)
        {
            inven.Remove(item);
        }

        public PlayerItem this[int index]
            {
                get { return inven[index]; }
            }

    }
}
