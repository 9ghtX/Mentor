using Mentor.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.ViewModels.Character
{
    internal class CharacterViewModel : ViewModelBase
    {
        public ViewModelBase HeaderViewModel { get; }
        public ViewModelBase MainCharsViewModel { get; }

        public CharacterViewModel()
        {
            HeaderViewModel = new HeaderViewModel();
            MainCharsViewModel = new MainCharsViewModel();
        }
    }
}
