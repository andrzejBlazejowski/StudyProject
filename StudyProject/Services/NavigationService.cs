using StudyProject.Stores;
using StudyProject.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Services
{
    public class NavigationService<Tvm>
      where Tvm : BaseViewModel
    {
        private NavStore _navStore;
        private readonly Func<Tvm> _createViewModel;

        public NavigationService(NavStore navStore, Func<Tvm> createViewModel)
        {
            _navStore = navStore;
            _createViewModel = createViewModel;
        }

        public void Navigate()
        {
            _navStore.CurrentViewModel = _createViewModel();
        }
    }
}
