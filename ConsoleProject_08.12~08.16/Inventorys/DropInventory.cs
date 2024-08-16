using ConsoleProject_08._12_08._16.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Inventorys
{
    public class DropInventory
    {
        public List<DropItem> drop;

        public DropInventory()
        {
            drop = new List<DropItem>();
        }

        public int GetDropCount()
        {
            return drop.Count;
        }

        public void AddDropItem(DropItem item)
        {
            drop.Add(item);
        }

         public DropItem this[int index]
         {
             get { return drop[index]; }
         } 
    }
}
