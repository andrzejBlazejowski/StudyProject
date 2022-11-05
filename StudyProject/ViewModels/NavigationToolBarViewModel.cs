using StudyProject.Commands;
using StudyProject.Services;
using StudyProject.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudyProject.ViewModels
{
    public class NavigationToolBarViewModel
    {
        public ICommand NavigateAllBrandsCmd { get; }
        public ICommand NavigateAllComoditiesCmd { get; }
        public ICommand NavigateAllDeliveryStatusesCmd { get; }
        public NavigationToolBarViewModel(NavigationService<AllBrandsViewModel> brandsNavigationService, NavigationService<AllComoditiesViewModel> comoditiesNavigationService, NavigationService<AllDeliveryStatusesViewModel> deliverStatusesNavigationService)
        {
            NavigateAllBrandsCmd = new NavigateCmd<AllBrandsViewModel>(brandsNavigationService);
            NavigateAllComoditiesCmd = new NavigateCmd<AllComoditiesViewModel>(comoditiesNavigationService);
            NavigateAllDeliveryStatusesCmd = new NavigateCmd<AllDeliveryStatusesViewModel>(deliverStatusesNavigationService);
        }
    }
}
