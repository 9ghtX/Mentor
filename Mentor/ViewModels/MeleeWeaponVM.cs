﻿using Mentor.Commands.Weapon;
using Mentor.Interfaces;
using Mentor.Models;
using Mentor.ViewModels.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mentor.ViewModels
{
    internal class MeleeWeaponVM : ItemVM
    {
        private readonly MeleeWeapon weapon;

        public MeleeWeaponVM(MeleeWeapon weapon, CharacterVM characterVM) : base(weapon)
        {
            this.weapon = weapon;

            Durability = weapon.Durability;
            Damage = $"{weapon.Damage[0]}-{weapon.Damage[1]}";
            Reach = weapon.Reach;

            AtackCommand = new MeleeAtack(this, characterVM);
        }

        public string Damage { get; }
        public int Durability { get; }
        public int Reach { get; }

        public ICommand AtackCommand { get; }
    }
}
