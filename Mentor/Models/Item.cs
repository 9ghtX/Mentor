using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.Models
{
    internal abstract class Item
    {
        public Item(string name, string description = "")
        {
            Name = name;
            Description = description;
            Count = 1;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int LC { get; set; }
        public float Weight { get; set; }
        public int Cost { get; set; }
        public int Count { get; set; }
        
    }
}
