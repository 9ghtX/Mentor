using Mentor.ViewModels;
using Mentor.ViewModels.Character;
using Mentor.ViewModels.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Mentor.Commands.Weapon
{
    internal class MeleeAtack : CommandBase
    {
        private readonly MeleeAtackWindowVM meleeAtackWindowVM;
        public MeleeAtack(MeleeWeaponVM meleeWeaponVM, CharacterVM characterVM)
        {
            meleeAtackWindowVM = new(characterVM, meleeWeaponVM);
        }

        public override void Execute(object? parameter)
        {
            var win = new Views.Atack.AtackView();
            win.DataContext = meleeAtackWindowVM;
            win.Show();
        }
    }
}
