using Mentor.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.ViewModels.Character
{
    internal class HeaderViewModel : ViewModelBase
    {
        private string _characterName = "Акира Акирман";
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

        private string _playerName = "Дэбич";
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

        private int _stasus = 0;
        public int Status
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

        private int _height = 180;
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

        private int _SM = 0;
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

        private string _notes = "Описание...";
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
    }
}
