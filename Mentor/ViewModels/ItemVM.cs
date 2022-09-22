using Mentor.Models;
using Mentor.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.ViewModels
{
    internal class ItemVM : VMBase
    {
        private readonly Item item;

        public string Name => item.Name;
        public string Description => item.Description;
        public float Weight => item.Weight;
        public int LC => item.LC;

        public ItemVM(Item item)
        {
            this.item = item;
        }

        public void ChangeName(string name)
        {
            item.Name = name;
        }
        public void ChangeDescription(string description)
        {
            item.Description = description;
        }
        public void ChangeWeight(int weight)
        {
            item.Weight = weight;
        }
        public void ChangeLC(int lc)
        {
            item.LC = lc;
        }
    }
}
