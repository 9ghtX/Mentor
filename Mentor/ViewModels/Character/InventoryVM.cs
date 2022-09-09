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

        public InventoryVM(Models.Character character)
        {
            inventory = new ObservableCollection<ItemVM>();
            foreach (Item item in character.Inventory)
            {
                inventory.Add(new ItemVM(item));
            }
        }
    }
}
