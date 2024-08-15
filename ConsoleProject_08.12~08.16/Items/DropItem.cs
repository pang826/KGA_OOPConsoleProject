using ConsoleProject_08._12_08._16.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject_08._12_08._16.Items
{
    public class DropItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DropItem(string name, string decription)
        {
            this.Name = name;
            this.Description = decription;
        }
    }
}
