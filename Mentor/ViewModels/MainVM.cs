using Mentor.Stores;
using Mentor.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mentor.ViewModels
{
    internal class MainVM : VMBase
    {
        private readonly NavigationStore _navigationStore;

        public MainVM(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        public VMBase CurrentViewModel => _navigationStore.CurrentViewModel;
    }
}
