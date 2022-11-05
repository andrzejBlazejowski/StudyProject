using StudyProject.ViewModels.Abstract;
using StudyProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Stores
{
    public class NavStore
    {
        #region Fields
        public event Action CurrViewModelChanded;
        private BaseViewModel _currentViewModel;
        private readonly NavigationToolBarViewModel _toolbarViewModel;
        public BaseViewModel CurrentViewModel { get => _currentViewModel; set
            {
                _currentViewModel = value;
                OnCurrViewModelChanged();
            }
        }

        #endregion
        public NavStore(NavigationToolBarViewModel navVM) {
            _toolbarViewModel = navVM;
            CurrentViewModel = new AllCurenciesViewModel(this, _toolbarViewModel);
        }

        private void OnCurrViewModelChanged()
        {
            CurrViewModelChanded?.Invoke();
        }
    }
}
