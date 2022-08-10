using Mentor.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.ViewModels.Character
{
    internal class MainCharsViewModel : ViewModelBase
    {
        // MainChars //
        private int _ST = 10;
        public int ST
        {
            get
            {
                return _ST;
            }
            set
            {
                _ST = value;
                OnPropertyChanged(nameof(ST));
            }
        }

        private int _DX = 10;
        public int DX
        {
            get
            {
                return _DX;
            }
            set
            {
                _DX = value;
                OnPropertyChanged(nameof(DX));
            }
        }

        private int _IN = 10;
        public int IN
        {
            get
            {
                return _IN;
            }
            set
            {
                _IN = value;
                OnPropertyChanged(nameof(IN));
            }
        }

        private int _HT = 10;
        public int HT
        {
            get
            {
                return _HT;
            }
            set
            {
                _HT = value;
                OnPropertyChanged(nameof(HT));
            }
        }

        // Secondary Chars //

        private int _HP;
        public int HP
        {
            get
            {
                return _HP;
            }
            set
            {
                _HP = value;
                OnPropertyChanged(nameof(HP));
            }
        }

        private int _Move;
        public int Move
        {
            get
            {
                return _Move;
            }
            set
            {
                _Move = value;
                OnPropertyChanged(nameof(Move));
            }
        }

        private double _Speed;
        public double Speed
        {
            get
            {
                return _Speed;
            }
            set
            {
                _Speed = value;
                OnPropertyChanged(nameof(Speed));
            }
        }

        private int _Will;
        public int Will
        {
            get
            {
                return _Will;
            }
            set
            {
                _Will = value;
                OnPropertyChanged(nameof(Will));
            }
        }

        private int _Per;
        public int Per
        {
            get
            {
                return _Per;
            }
            set
            {
                _Per = value;
                OnPropertyChanged(nameof(Per));
            }
        }

        private int _FP;
        public int FP
        {
            get
            {
                return _FP;
            }
            set
            {
                _FP = value;
                OnPropertyChanged(nameof(FP));
            }
        }

        public MainCharsViewModel()
        {
            HP = ST;
            Speed = (DX + HT) / 4;
            Move = (int)Math.Round(Speed, 1);
            Will = IN;
            Per = IN;
            FP = HT;
        }
    }
}
