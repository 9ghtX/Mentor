using Mentor.Commands.Weapon;
using Mentor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mentor.ViewModels
{
    internal class RangeWeaponVM : ItemVM
    {
        private readonly RangeWeapon weapon;
        public string Damage { get; }
        public int Durability { get; }
        public int Acc { get; }
        public int Blk { get; }
        public int ST { get; }
        public int ROF { get; }
        public int Shots { get; }
        public int Rcl { get; }

        public RangeWeaponVM(RangeWeapon weapon) : base(weapon)
        {
            this.weapon = weapon;

            Durability = weapon.Durability;
            Damage = $"{weapon.Damage[0]}-{weapon.Damage[1]}";
            Acc = weapon.Acc;
            Blk = weapon.Blk;
            ST = weapon.ST;
            ROF = weapon.ROF;
            Shots = weapon.Shots;
            Rcl = weapon.Rcl;

            Atack = new Atack();
        }

        ICommand Atack { get; }
    }
}
