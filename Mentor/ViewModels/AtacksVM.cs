using Mentor.ViewModels.Base;
using Mentor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Mentor.Views.Character;
using Mentor.ViewModels.Character;

namespace Mentor.ViewModels
{
    internal class AtacksVM : VMBase
    {
        private readonly ObservableCollection<RangeWeaponVM> rangeWeapons;
        public IEnumerable<RangeWeaponVM> RangeWeapons => rangeWeapons;
        private readonly ObservableCollection<MeleeWeaponVM> meleeWeapons;
        public IEnumerable<MeleeWeaponVM> MeleeWeapons => meleeWeapons;

        public AtacksVM(InventoryVM inventoryVM)
        {
            rangeWeapons = new ObservableCollection<RangeWeaponVM>();
            meleeWeapons = new ObservableCollection<MeleeWeaponVM>();

            foreach (var item in inventoryVM.Inventory)
            {
                if (item.GetType() == typeof(RangeWeaponVM))
                    rangeWeapons.Add((RangeWeaponVM)item);
                if (item.GetType() == typeof(MeleeWeaponVM))
                    meleeWeapons.Add((MeleeWeaponVM)item);
            }
            //rangeWeapons = new ObservableCollection<RangeWeaponVM>(inventoryVM.Inventory.Where(w => w.GetType() == typeof(RangeWeaponVM)));
            //meleeWeapons = new ObservableCollection<MeleeWeaponVM>(inventoryVM.Inventory.Where(w => w.GetType() == typeof(MeleeWeaponVM)));
        }
    }
}
