using Mentor.ViewModels.NewFolder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.Commands.AtackView
{
    internal class MakeAtack : CommandBase
    {
        private readonly MeleeAtackWindowVM meleeAtackWindowVM;
        public MakeAtack(MeleeAtackWindowVM meleeAtackWindowVM)
        {
            this.meleeAtackWindowVM = meleeAtackWindowVM;
        }

        public override void Execute(object? parameter)
        {
            Random rand = new();
            int result = rand.Next(3, 18);
            if (result > meleeAtackWindowVM.Skill) meleeAtackWindowVM.AtackResult = $"[{result} vs {meleeAtackWindowVM.Skill}] Fail!";
            else
            {
                meleeAtackWindowVM.AtackResult = $"[{result} vs {meleeAtackWindowVM.Skill}] Success!";
                meleeAtackWindowVM.DmgResult = rand.Next(meleeAtackWindowVM.MinDmg, meleeAtackWindowVM.MaxDmg);
            }
        }
    }
}
