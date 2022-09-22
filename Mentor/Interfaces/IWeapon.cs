using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.Interfaces
{
    internal interface IWeapon
    {
        int[] Damage { get; set; }
        int ST { get; set; }

        int Atack()
        {
            Random rand = new();
            return rand.Next(Damage[0], Damage[1]);
        }
        int Parry()
        {
            Random rand = new();
            return rand.Next(3, 18);
        }
        int Block()
        {
            Random rand = new();
            return rand.Next(3, 18);
        }
    }
}
