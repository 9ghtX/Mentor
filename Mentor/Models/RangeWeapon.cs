using Mentor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.Models
{
    internal class RangeWeapon : Item, IDurable, IWeapon
    {
        public RangeWeapon(string name, string description = "") : base(name, description)
        {

        }

        public int Durability { get; set; }
        public int[] Damage { get; set; }
        public int ST { get; set; }
        public int Acc { get; set; }
        public int Blk { get; set; }
        public int ROF { get; set; }
        public int Shots { get; set; }
        public int Rcl { get; set; }
        public Enums.AmmoType AmmoType { get; set; }
    }
}
