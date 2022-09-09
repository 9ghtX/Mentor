using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.Models
{
    internal class Character
    {
        public string Name { get; set; }
        public string PlayerName { get; set; }
        public string Status { get; set; }
        public int Height { get; set; }
        public int SM { get; set; }
        public string Notes { get; set; }
        public int MainArm { get; set; }

        public int ST { get; set; }
        public int IN { get; set; }
        public int DX { get; set; }
        public int HT { get; set; }

        public List<Item> Inventory = new List<Item>();
        public List<Feature> Features = new List<Feature>();

        public Character(string name)
        {
            Name = name;
        }
    }
}
