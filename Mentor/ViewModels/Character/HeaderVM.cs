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
    internal class HeaderVM : VMBase
    {
        private string _characterName;
        public string CharacterName
        {
            get
            {
                return _characterName;
            }
            set
            {
                _characterName = value;
                OnPropertyChanged(nameof(CharacterName));
            }
        }

        private string _playerName;
        public string PlayerName
        {
            get
            {
                return _playerName;
            }
            set
            {
                _playerName = value;
                OnPropertyChanged(nameof(PlayerName));
            }
        }

        private string _stasus;
        public string Status
        {
            get
            {
                return _stasus;
            }
            set
            {
                _stasus = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        private int _height;
        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
                OnPropertyChanged(nameof(Height));
            }
        }

        private int _SM;
        public int SM
        {
            get
            {
                return _SM;
            }
            set
            {
                _SM = value;
                OnPropertyChanged(nameof(SM));
            }
        }

        private string _notes;
        public string Notes
        {
            get
            {
                return _notes;
            }
            set
            {
                _notes = value;
                OnPropertyChanged(nameof(Notes));
            }
        }

        private readonly ObservableCollection<string> _mainArm;
        public IEnumerable<string> MainArm => _mainArm;

        private int _selectedMainArm;
        public int SelectedMainArm
        {
            get
            {
                return _selectedMainArm;
            }
            set
            {
                _selectedMainArm = value;
                OnPropertyChanged(nameof(SelectedMainArm));
            }
        }

        public HeaderVM(Models.Character character)
        {
            _mainArm = new ObservableCollection<string> { "Правая", "Левая" };

            CharacterName = character.Name;
            PlayerName = character.PlayerName;
            Status = character.Status;
            Height = character.Height;
            SM = character.SM;
            Notes = character.Notes;
            SelectedMainArm = character.MainArm;
        }
    }
}
