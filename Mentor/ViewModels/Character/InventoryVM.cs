using Mentor.Models;
using Mentor.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.ViewModels.Character
{
    internal class InventoryVM : VMBase
    {
        private readonly ObservableCollection<ItemVM> inventory;
        public IEnumerable<ItemVM> Inventory => inventory;

        public InventoryVM(Models.Character character, CharacterVM characterVM)
        {
            inventory = new ObservableCollection<ItemVM>();
            foreach (var item in character.Inventory)
            {
                if (item is RangeWeapon)
                {
                    inventory.Add(new RangeWeaponVM((RangeWeapon)item, characterVM));
                    continue;
                }
                    
                if (item is MeleeWeapon)
                {
                    inventory.Add(new MeleeWeaponVM((MeleeWeapon)item, characterVM));
                    continue;
                }
                inventory.Add(new ItemVM(item));
            }
        }
    }
}
