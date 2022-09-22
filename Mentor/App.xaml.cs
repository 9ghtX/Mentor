using Mentor.Models;
using Mentor.Stores;
using Mentor.ViewModels;
using Mentor.ViewModels.Character;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Mentor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;

        private Character character = new Character("Test");

        public App()
        {
            _navigationStore = new NavigationStore();

            character.PlayerName = "Dummy";
            character.Height = 180;
            character.SM = 0;
            character.Status = "Scout";
            character.Notes = "This is dummy. His name is Dummy";

            character.Inventory.Add(new Armor("Steel Chestplate")
            {
                Description = "Common steel chestplate that knight wear",
                Weight = 5.0f,
                Cost = 300,
            });

            character.Inventory.Add(new MeleeWeapon("Machete")
            {
                Description = "Common instruent for cutting foliage. Or man...",
                Damage = new int[] {2, 6},
                Durability = 100,
                Weight = 5.0f,
                Reach = 1,
                ST = 8,
                Cost = 300,
            });

            character.Inventory.Add(new RangeWeapon("M1911")
            {
                Description = "Legendary wepon for a legendary man!",
                Damage = new int[] { 2, 6 },
                Durability = 100,
                Blk = 3,
                Rcl = 2,
                Acc = 1,
                ROF = 1,
                ST = 8,
                Weight = 1.2f,
                Cost = 300,
            });

            character.Inventory.Add(new RangeWeapon("Azple Stormer")
            {
                Description = "MEGA AUTOMATIC RIFLE",
                Damage = new int[] { 1, 5 },
                Durability = 100,
                Rcl = 2,
                Acc = 2,
                ROF = 3,
                ST = 12,
                Weight = 4.5f,
                Cost = 900,
            });

            character.Advanteges.Add(new Feature("Test Feature", "Test Description", 5));

            character.ST = 10;
            character.IN = 10;
            character.DX = 10;
            character.HT = 10;
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            _navigationStore.CurrentViewModel = new CharacterVM(character);

            MainWindow = new MainWindow()
            {
                DataContext = new MainVM(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }
    }
}
