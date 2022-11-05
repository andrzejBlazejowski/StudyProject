using StudyProject.Commands;
using StudyProject.Services;
using StudyProject.Stores;
using StudyProject.ViewModels.List;
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
        public ICommand NavigateAllComodityCategoryCmd { get; }
        public ICommand NavigateAllDeliveryStatusesCmd { get; }
        public ICommand NavigateAllContractorsCmd { get; }
        public ICommand NavigateAllContractorTypesCmd { get; }
        public ICommand NavigateAllCurenciesCmd { get; }
        public ICommand NavigateAllDeliveryCmd { get; }
        public ICommand NavigateAllDeliveryItemsCmd { get; }
        public ICommand NavigateAllEmplyeesCmd { get; }
        public ICommand NavigateAllEmplyeeTypesCmd { get; }
        public ICommand NavigateAllInvoiceItemsCmd { get; }
        public ICommand NavigateAllInvoicesCmd { get; }
        public ICommand NavigateAllPaymentMethodsCmd { get; }
        public ICommand NavigateAllSizeTypesCmd { get; }
        public ICommand NavigateAllStoragesCmd { get; }
        public ICommand NavigateWarehousesCmd { get; }

        public NavigationToolBarViewModel(
            NavigationService<AllBrandsViewModel> brandsNavigationService, 
            NavigationService<AllComoditiesViewModel> comoditiesNavigationService, 
            NavigationService<AllComodityCategoriesViewModel> comodityCategoryNavigationService,
            NavigationService<AllContractorsViewModel> contractorsNavigationService,
            NavigationService<AllContractorTypesViewModel> contractorTypesService,
            NavigationService<AllCurenciesViewModel> CurenciesNavigationService,
            NavigationService<AllDeliveryItemsViewModel> DeliveryItemsNavigationService,
            NavigationService<AllDeliveryViewModel> DeliveryNavigationService,
            NavigationService<AllDeliveryStatusesViewModel> deliverStatusesNavigationService,
            NavigationService<AllEmplyeeTypesViewModel> EmplyeeTypesNavigationService,
            NavigationService<AllInvoiceItemsViewModel> InvoiceItemsNavigationService,
            NavigationService<AllInvoicesViewModel> InvoicesNavigationService,
            NavigationService<AllPaymentMethodsViewModel> PaymentMethodsNavigationService,
            NavigationService<AllSizeTypesViewModel> SizeTypesNavigationService,
            NavigationService<AllStoragesViewModel> StoragesNavigationService,
            NavigationService<AllWarehousesViewModel> WarehousesNavigationService,
            NavigationService<AllEmplyeesViewModel> EmplyeesNavigationService)
        {
            NavigateAllBrandsCmd = new NavigateCmd<AllBrandsViewModel>(brandsNavigationService);
            NavigateAllComoditiesCmd = new NavigateCmd<AllComoditiesViewModel>(comoditiesNavigationService);
            NavigateAllComodityCategoryCmd = new NavigateCmd<AllComodityCategoriesViewModel>(comodityCategoryNavigationService);
            NavigateAllContractorsCmd = new NavigateCmd<AllContractorsViewModel>(contractorsNavigationService);
            NavigateAllContractorTypesCmd = new NavigateCmd<AllContractorTypesViewModel>(contractorTypesService);
            NavigateAllCurenciesCmd = new NavigateCmd<AllCurenciesViewModel>(CurenciesNavigationService);
            NavigateAllDeliveryItemsCmd = new NavigateCmd<AllDeliveryItemsViewModel>(DeliveryItemsNavigationService);
            NavigateAllDeliveryStatusesCmd = new NavigateCmd<AllDeliveryStatusesViewModel>(deliverStatusesNavigationService);
            NavigateAllDeliveryCmd = new NavigateCmd<AllDeliveryViewModel>(DeliveryNavigationService);
            NavigateAllEmplyeesCmd = new NavigateCmd<AllEmplyeesViewModel>(EmplyeesNavigationService);
            NavigateAllEmplyeeTypesCmd = new NavigateCmd<AllEmplyeeTypesViewModel>(EmplyeeTypesNavigationService);
            NavigateAllInvoicesCmd = new NavigateCmd<AllInvoicesViewModel>(InvoicesNavigationService);
            NavigateAllInvoiceItemsCmd = new NavigateCmd<AllInvoiceItemsViewModel>(InvoiceItemsNavigationService);
            NavigateAllPaymentMethodsCmd = new NavigateCmd<AllPaymentMethodsViewModel>(PaymentMethodsNavigationService);
            NavigateAllSizeTypesCmd = new NavigateCmd<AllSizeTypesViewModel>(SizeTypesNavigationService);
            NavigateAllStoragesCmd = new NavigateCmd<AllStoragesViewModel>(StoragesNavigationService);
            NavigateWarehousesCmd = new NavigateCmd<AllWarehousesViewModel>(WarehousesNavigationService);
        }
    }
}
