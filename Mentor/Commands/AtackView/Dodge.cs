using Mentor.ViewModels.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.Commands.AtackView
{
    internal class Dodge : CommandBase
    {
        private readonly MeleeAtackWindowVM meleeAtackWindowVM;
        public Dodge(MeleeAtackWindowVM meleeAtackWindowVM)
        {
            this.meleeAtackWindowVM = meleeAtackWindowVM;
        }

        public override void Execute(object? parameter)
        {
            Random rand = new();
            int result = rand.Next(3, 18);
            if (result > meleeAtackWindowVM.Dgd) meleeAtackWindowVM.DgdResult = $"[{result} vs {meleeAtackWindowVM.Dgd}] Fail!";
            else meleeAtackWindowVM.DgdResult = $"[{result} vs {meleeAtackWindowVM.Dgd}] Success!";
        }
    }
}
