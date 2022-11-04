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
    internal class NavigationToolBarViewModel
    {
        public ICommand NavigateAllBrandsCmd { get; set; }
        public ICommand NavigateAllComoditiesCmd { get; set; }
        public ICommand NavigateAllDeliveryStatusesCmd { get; set; }
        public NavigationToolBarViewModel(NavigationService<AllBrandsViewModel> brandsNavigationService, NavigationService<AllComoditiesViewModel> comoditiesNavigationService, NavigationService<AllDeliveryStatusesViewModel> deliverStatusesNavigationService)
        {
            NavigateAllBrandsCmd = new NavigateCmd<AllBrandsViewModel>(brandsNavigationService);
            NavigateAllComoditiesCmd = new NavigateCmd<AllComoditiesViewModel>(comoditiesNavigationService);
            NavigateAllDeliveryStatusesCmd = new NavigateCmd<AllDeliveryStatusesViewModel>(deliverStatusesNavigationService);
        }
    }
}
