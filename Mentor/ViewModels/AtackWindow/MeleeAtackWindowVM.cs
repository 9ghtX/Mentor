using Mentor.Commands.AtackView;
using Mentor.ViewModels.Base;
using Mentor.ViewModels.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mentor.ViewModels.NewFolder
{
    internal class MeleeAtackWindowVM : VMBase
    {
        private readonly CharacterVM characterVM;
		private readonly MeleeWeaponVM meleeWeaponVM;
        public MeleeAtackWindowVM(CharacterVM characterVM, MeleeWeaponVM meleeWeaponVM)
        {
            this.characterVM = characterVM;
			this.meleeWeaponVM = meleeWeaponVM;

			DX = characterVM.MainCharsViewModel.DX;
			Skill = DX;

			Dgd = 9;

			MinDmg = int.Parse(meleeWeaponVM.Damage.Split("-")[0]);
            MaxDmg = int.Parse(meleeWeaponVM.Damage.Split("-")[1]);
			Reach = meleeWeaponVM.Reach;

			MakeAtack = new MakeAtack(this);
            Dodge = new Dodge(this);
        }
		
		private int dx;
		public int DX
		{
			get
			{
				return dx;
			}
			set
			{
				dx = value;
				OnPropertyChanged(nameof(DX));
			}
		}

		private int skill;
		public int Skill
		{
			get
			{
				return skill;
			}
			set
			{
				skill = value;
				OnPropertyChanged(nameof(Skill));
			}
		}

		private string weaponName;
		public string WeaponName
		{
			get
			{
				return weaponName;
			}
			set
			{
				weaponName = value;
				OnPropertyChanged(nameof(WeaponName));
			}
		}

		private int minDmg;
		public int MinDmg
		{
			get
			{
				return minDmg;
			}
			set
			{
				minDmg = value;
				OnPropertyChanged(nameof(MinDmg));
			}
		}

		private int maxDmg;
		public int MaxDmg
		{
			get
			{
				return maxDmg;
			}
			set
			{
				maxDmg = value;
				OnPropertyChanged(nameof(MaxDmg));
			}
		}

		private int reach;
		public int Reach
		{
			get
			{
				return reach;
			}
			set
			{
				reach = value;
				OnPropertyChanged(nameof(Reach));
			}
		}

		private string atackResult;
		public string AtackResult
        {
			get
			{
				return atackResult;
			}
			set
			{
				atackResult = value;
				OnPropertyChanged(nameof(AtackResult));
			}
		}

		private int dmgResult;
		public int DmgResult
        {
			get
			{
				return dmgResult;
			}
			set
			{
				dmgResult = value;
				OnPropertyChanged(nameof(DmgResult));
			}
		}
		private int dmg;
		public int Dmg
		{
			get
			{
				return dmg;
			}
			set
			{
				dmg = value;
				OnPropertyChanged(nameof(Dmg));
			}
		}

		private string dgdResult;
		public string DgdResult
        {
			get
			{
				return dgdResult;
			}
			set
			{
				dgdResult = value;
				OnPropertyChanged(nameof(DgdResult));
			}
		}
		private int dgd;
		public int Dgd
		{
			get
			{
				return dgd;
			}
			set
			{
				dgd = value;
				OnPropertyChanged(nameof(Dgd));
			}
		}

		public ICommand MakeAtack { get; }
        public ICommand Dodge { get; }
	}
}
