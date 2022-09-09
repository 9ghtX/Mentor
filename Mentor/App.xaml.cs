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

            character.PlayerName = "Test Player Name";
            character.Height = 180;
            character.SM = 0;
            character.Status = "Test Status";
            character.Notes = "Test Notes";
            character.Inventory.Add(new Item(name: "Test Item", "Test Description", 5, 0));
            character.Inventory.Add(new Armor("Test Armor"));
            character.Features.Add(new Feature("Test Feature", "Test Description", 5));

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
