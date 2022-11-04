using StudyProject.Stores;
using StudyProject.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        #region Fields
        private readonly NavStore _navStore;
        public BaseViewModel CurrentViewModel  => _navStore.CurrentViewModel;
        #endregion
        #region Constructor
        public MainViewModel(NavStore navStore) {
            _navStore = navStore;

            _navStore.CurrViewModelChanded += OnCurrentViewModelChanged;
        }

        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
        #endregion
    }
}
