using StudyProject.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudyProject.ViewModels
{
    internal class NavigationToolBarViewModel
    {
        public ICommand NavigateAllBrandsCmd { get; set; }
        public ICommand NavigateAllComoditiesCmd { get; set; }
        public ICommand NavigateAllDeliveryStatusesCmd { get; set; }

        public NavigationToolBarViewModel()
        {
          //  NavigateAllBrandsCmd = new NavigateCommand<AllBrandsViewModel>();
        }
    }
}
