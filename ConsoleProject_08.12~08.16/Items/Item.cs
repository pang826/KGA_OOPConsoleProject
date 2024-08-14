using ConsoleProject_08._12_08._16.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Items
{
    public abstract class Item
    {
        public Player player;
        public string Name { get; set; }
        public string Description { get; set; }
        public Item(string name, string description) 
        {
            this.Name = name; 
            this.Description = description;
        }

        public abstract void InputInven();

        public abstract void OutputInven();
    }
}
