using Mentor.Models;
using Mentor.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.ViewModels.Character
{
    internal class CharacterVM : VMBase
    {
        public VMBase HeaderViewModel { get; }
        public VMBase MainCharsViewModel { get; }
        public VMBase InventoryViewModel { get; }

        public CharacterVM(Models.Character character)
        {
            HeaderViewModel = new HeaderVM(character);
            MainCharsViewModel = new MainCharsVM(character);
            InventoryViewModel = new InventoryVM(character);
        }
    }
}
