using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.Interfaces
{
    internal interface IWeapon
    {
        void Atack(int damage);
        void Parry();
        void Block();
    }
}
