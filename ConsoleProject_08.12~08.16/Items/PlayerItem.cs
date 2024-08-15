using ConsoleProject_08._12_08._16.Players;
using ConsoleProject_08._12_08._16.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace ConsoleProject_08._12_08._16.Items
{
    public abstract class PlayerItem
    {
        public Game game;
        public Player player;
        public Inventory inventory;


        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost {  get; set; }
        public PlayerItem(string name, string description, int cost) 
        {
            this.Name = name; 
            this.Description = description;
            this.Cost = cost;
        }
        
    }
}
