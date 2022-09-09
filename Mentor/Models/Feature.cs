using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.Models
{
    internal class Feature
    {
        public Feature(string name, string description, int cost)
        {
            Name = name;
            Description = description;
            Cost = cost;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
    }
}
