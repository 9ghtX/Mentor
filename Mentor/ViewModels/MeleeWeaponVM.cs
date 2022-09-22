using Mentor.Interfaces;
using Mentor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.ViewModels
{
    internal class MeleeWeaponVM : ItemVM
    {
        private readonly MeleeWeapon weapon;

        public MeleeWeaponVM(MeleeWeapon weapon) : base(weapon)
        {
            this.weapon = weapon;

            Durability = weapon.Durability;
            Damage = $"{weapon.Damage[0]}-{weapon.Damage[1]}";
            Reach = weapon.Reach;
        }

        public string Damage { get; }
        public int Durability { get; }
        public int Reach { get; }
    }
}
