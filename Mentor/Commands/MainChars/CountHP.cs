using Mentor.ViewModels.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.Commands.MainChars
{
    internal class CountHP : CommandBase
    {
        MainCharsVM mainCharsViewModel;

        public CountHP(MainCharsVM mainCharsViewModel)
        {
            this.mainCharsViewModel = mainCharsViewModel;
        }

        public override void Execute(object? parameter)
        {
            mainCharsViewModel.HP = mainCharsViewModel.ST;
        }
    }
}
