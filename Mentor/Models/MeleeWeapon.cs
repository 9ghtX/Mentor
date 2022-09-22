using Mentor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.Models
{
    internal class MeleeWeapon : Item, IDurable, IWeapon
    {
        public MeleeWeapon(string name, string description = "") : base(name, description)
        {
            this.Name = name;
            this.Damage = new int[] {0, 1};
        }

        public int Durability { get; set; }
        public int[] Damage { get; set; }
        public int ST { get; set; }
        public int Reach { get; set; }
    }
}
