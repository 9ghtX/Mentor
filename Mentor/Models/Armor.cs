using Mentor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.Models
{
    internal class Armor : Item, IDurable
    {
        public int Durability { get; set; }
        
        public Armor(string name, string description = "", int weight = 0, int lc = 0) : base(name, description, weight, lc)
        {
            
        }
    }
}
