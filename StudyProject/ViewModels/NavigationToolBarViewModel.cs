using StudyProject.ViewModels;
using StudyProject.Commands;
using StudyProject.Services;
using StudyProject.Stores;
using StudyProject.ViewModels.List;
using StudyProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StudyProject.View.Add;
using StudyProject.ViewModels.BuisnesLogic;

namespace StudyProject.ViewModels
{
    public class NavigationToolBarViewModel
    {
        private readonly NavStore _navStore;
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
        public ICommand NavigateAllWarehousesCmd { get; }
        public ICommand NavigateAddBrandsCmd { get; }
        public ICommand NavigateAddComoditiesCmd { get; }
        public ICommand NavigateAddComodityCategoryCmd { get; }
        public ICommand NavigateAddDeliveryStatusesCmd { get; }
        public ICommand NavigateAddContractorsCmd { get; }
        public ICommand NavigateAddContractorTypesCmd { get; }
        public ICommand NavigateAddCurenciesCmd { get; }
        public ICommand NavigateAddDeliveryCmd { get; }
        public ICommand NavigateAddDeliveryItemsCmd { get; }
        public ICommand NavigateAddEmplyeesCmd { get; }
        public ICommand NavigateAddEmplyeeTypesCmd { get; }
        public ICommand NavigateAddInvoiceItemsCmd { get; }
        public ICommand NavigateAddInvoicesCmd { get; }
        public ICommand NavigateAddPaymentMethodsCmd { get; }
        public ICommand NavigateAddSizeTypesCmd { get; }
        public ICommand NavigateAddStoragesCmd { get; }
        public ICommand NavigateAddWarehousesCmd { get; }
        public ICommand NavigateSalesMonthlyReportCmd { get; }
        public ICommand NavigateComoditySalesReportReportCmd { get; }
        

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
            NavigationService<AllEmplyeesViewModel> EmplyeesNavigationService,
            NavigationService<AddBrandViewModel> AddBrandsNavigationService,
            NavigationService<AddComodityViewModel> AddcomoditiesNavigationService,
            NavigationService<AddComodityCategoryViewModel> AddcomodityCategoryNavigationService,
            NavigationService<AddContractorViewModel> AddcontractorsNavigationService,
            NavigationService<AddContractorTypeViewModel> AddcontractorTypesService,
            NavigationService<AddCurrencyViewModel> AddCurenciesNavigationService,
            NavigationService<AddDeliveryItemViewModel> AddDeliveryItemsNavigationService,
            NavigationService<AddDeliveryViewModel> AddDeliveryNavigationService,
            NavigationService<AddDeliveryStatusViewModel> AdddeliverStatusesNavigationService,
            NavigationService<AddEmployeeTypeViewModel> AddEmplyeeTypesNavigationService,
            NavigationService<AddInvoiceItemViewModel> AddInvoiceItemsNavigationService,
            NavigationService<AddInvoiceViewModel> AddInvoicesNavigationService,
            NavigationService<AddPaymentMethodViewModel> AddPaymentMethodsNavigationService,
            NavigationService<AddSizeTypeViewModel> AddSizeTypesNavigationService,
            NavigationService<AddStorageViewModel> AddStoragesNavigationService,
            NavigationService<AddWarehouseViewModel> AddWarehousesNavigationService,
            NavigationService<AddEmployeeViewModel> AddEmplyeesNavigationService,
            NavigationService<MonthlySalesReport> SalesMonthlyReportNavigationService,
            NavigationService<ComoditySalesReportVM> ComoditySalesReportNavigationService
            )
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
            NavigateAllWarehousesCmd = new NavigateCmd<AllWarehousesViewModel>(WarehousesNavigationService);
            NavigateAddBrandsCmd = new NavigateCmd<AddBrandViewModel>(AddBrandsNavigationService);
            NavigateAddComoditiesCmd = new NavigateCmd<AddComodityViewModel>(AddcomoditiesNavigationService);
            NavigateAddComodityCategoryCmd = new NavigateCmd<AddComodityCategoryViewModel>(AddcomodityCategoryNavigationService);
            NavigateAddContractorsCmd = new NavigateCmd<AddContractorViewModel>(AddcontractorsNavigationService);
            NavigateAddContractorTypesCmd = new NavigateCmd<AddContractorTypeViewModel>(AddcontractorTypesService);
            NavigateAddCurenciesCmd = new NavigateCmd<AddCurrencyViewModel>(AddCurenciesNavigationService);
            NavigateAddDeliveryItemsCmd = new NavigateCmd<AddDeliveryItemViewModel>(AddDeliveryItemsNavigationService);
            NavigateAddDeliveryStatusesCmd = new NavigateCmd<AddDeliveryStatusViewModel>(AdddeliverStatusesNavigationService);
            NavigateAddDeliveryCmd = new NavigateCmd<AddDeliveryViewModel>(AddDeliveryNavigationService);
            NavigateAddEmplyeesCmd = new NavigateCmd<AddEmployeeViewModel>(AddEmplyeesNavigationService);
            NavigateAddEmplyeeTypesCmd = new NavigateCmd<AddEmployeeTypeViewModel>(AddEmplyeeTypesNavigationService);
            NavigateAddInvoicesCmd = new NavigateCmd<AddInvoiceViewModel>(AddInvoicesNavigationService);
            NavigateAddInvoiceItemsCmd = new NavigateCmd<AddInvoiceItemViewModel>(AddInvoiceItemsNavigationService);
            NavigateAddPaymentMethodsCmd = new NavigateCmd<AddPaymentMethodViewModel>(AddPaymentMethodsNavigationService);
            NavigateAddSizeTypesCmd = new NavigateCmd<AddSizeTypeViewModel>(AddSizeTypesNavigationService);
            NavigateAddStoragesCmd = new NavigateCmd<AddStorageViewModel>(AddStoragesNavigationService);
            NavigateAddWarehousesCmd = new NavigateCmd<AddWarehouseViewModel>(AddWarehousesNavigationService);
            NavigateSalesMonthlyReportCmd = new NavigateCmd<MonthlySalesReport>(SalesMonthlyReportNavigationService);
            NavigateComoditySalesReportReportCmd = new NavigateCmd<ComoditySalesReportVM>(ComoditySalesReportNavigationService);
        }

        private NavigationService<AllBrandsViewModel> CreateBrandsNavigationService()
        {
            return new NavigationService<AllBrandsViewModel>(_navStore, () => new AllBrandsViewModel(_navStore, this));
        }

    }
}
