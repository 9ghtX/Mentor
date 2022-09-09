using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.Models
{
    internal class Item
    {
        public Item(string name, string description = "", int weight = 0, int lc = 0)
        {
            Name = name;
            Description = description;
            Weight = weight;
            LC = lc;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public int LC { get; set; }
    }
}
