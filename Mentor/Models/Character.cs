using Mentor.ViewModels.Character;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Mentor.Models
{
    internal class Character
    {
        public string Name { get; set; }
        public string PlayerName { get; set; }
        public string Status { get; set; }
        public int Height { get; set; }
        public int SM { get; set; }
        public string Notes { get; set; }
        public int MainArm { get; set; }

        /* Default points */

        public int ST { get; set; }
        public int IN { get; set; }
        public int DX { get; set; }
        public int HT { get; set; }

        /* Added chars for points count */
        public int AddedST { get; set; }
        public int AddedIN { get; set; }
        public int AddedDX { get; set; }
        public int AddedHT { get; set; }

        public int AddedHP { get; set; }
        public int AddedMove { get; set; }
        public int AddedSpeed { get; set; }
        public int AddedWill { get; set; }
        public int AddedPer { get; set; }
        public int AddedFP { get; set; }

        public List<Feature> Advanteges = new List<Feature>();

        public List<Item> Inventory = new List<Item>();

        public List<MeleeWeapon> MeleeWeapons = new List<MeleeWeapon>();
        public List<RangeWeapon> RangeWeapons = new List<RangeWeapon>();

        public Character(string name)
        {
            Name = name;
            PlayerName = "";
            Status = "";
            Notes = "";
        }

        public void Save()
        {
            var options = new JsonSerializerOptions{ WriteIndented = true };
            using (FileStream fs = new FileStream($"{this.Name}.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync<Character>(fs, this, options);
            }
        }
    }
}
