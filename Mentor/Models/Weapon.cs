using Mentor.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.Models
{
    internal class Weapon : Item, IWeapon, IDurable
    {
        public Weapon(string name, string description = "", int weight = 0, int lc = 0) : base(name, description, weight, lc)
        {

        }

        public int Durability { get; set; }

        public void Atack(int damage)
        {
            throw new NotImplementedException();
        }

        public void Block()
        {
            throw new NotImplementedException();
        }

        public void Parry()
        {
            throw new NotImplementedException();
        }
    }
}
