using StudyProject.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using StudyProject.ViewModels;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using StudyProject.Stores;
using StudyProject.Services;
using StudyProject.ViewModels.List;
using StudyProject.ViewModels;
using StudyProject.View.Add;

namespace StudyProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    #region Fields
    #endregion
    public partial class App : Application
    {
        private readonly NavStore _navStore;
        private readonly NavigationToolBarViewModel _navToolBarVM;

        public App()
        {
            _navStore = new NavStore();
            _navToolBarVM = new NavigationToolBarViewModel(

            CreateBrandsNavigationService(),
            CreateComoditiesNavigationService(),
            CreateComodityCategoriesNavigationService(),
            CreateContractorsNavigationService(),
            CreateContractorTypesNavigationService(),
            CreateCurenciesNavigationService(),
            CreateDeliveryItemsNavigationService(),
            CreateDeliveryNavigationService(),
            CreateDeliveryStatusesNavigationService(),
            CreateEmplyeeTypesNavigationService(),
            CreateInvoiceItemsNavigationService(),
            CreateInvoicesNavigationService(),
            CreatePaymentMethodsNavigationService(),
            CreateSizeTypesNavigationService(),
            CreateStoragesNavigationService(),
            CreateWarehousesNavigationService(),
            CreateEmplyeesNavigationService(),
            CreateAddBrandsNavigationService(),
            CreateAddComoditiesNavigationService(),
            CreateAddComodityCategoriesNavigationService(),
            CreateAddContractorsNavigationService(),
            CreateAddContractorTypesNavigationService(),
            CreateAddCurenciesNavigationService(),
            CreateAddDeliveryItemsNavigationService(),
            CreateAddDeliveryNavigationService(),
            CreateAddDeliveryStatusesNavigationService(),
            CreateAddEmplyeeTypesNavigationService(),
            CreateAddInvoiceItemsNavigationService(),
            CreateAddInvoicesNavigationService(),
            CreateAddPaymentMethodsNavigationService(),
            CreateAddSizeTypesNavigationService(),
            CreateAddStoragesNavigationService(),
            CreateAddWarehousesNavigationService(),
            CreateAddEmplyeesNavigationService()

            );
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationService<AllBrandsViewModel> AllBrandsNavigationService = CreateBrandsNavigationService();
            AllBrandsNavigationService.Navigate();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navStore, _navToolBarVM)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }

        private NavigationService<AllBrandsViewModel> CreateBrandsNavigationService() 
        {
            return new NavigationService<AllBrandsViewModel>(_navStore, () => new AllBrandsViewModel(_navStore, _navToolBarVM));
        }

        private NavigationService<AllComoditiesViewModel> CreateComoditiesNavigationService()
        {
            return new NavigationService<AllComoditiesViewModel>(_navStore, () => new AllComoditiesViewModel(_navStore, _navToolBarVM));
        }

        private NavigationService<AllDeliveryStatusesViewModel> CreateDeliveryStatusesNavigationService()
        {
            return new NavigationService<AllDeliveryStatusesViewModel>(_navStore, () => new AllDeliveryStatusesViewModel(_navStore, _navToolBarVM));
        }


        private NavigationService<AllComodityCategoriesViewModel> CreateComodityCategoriesNavigationService()
        {
            return new NavigationService<AllComodityCategoriesViewModel>(_navStore, () => new AllComodityCategoriesViewModel(_navStore, _navToolBarVM));
        }


        private NavigationService<AllContractorsViewModel> CreateContractorsNavigationService()
        {
            return new NavigationService<AllContractorsViewModel>(_navStore, () => new AllContractorsViewModel(_navStore, _navToolBarVM));
        }



        private NavigationService<AllContractorTypesViewModel> CreateContractorTypesNavigationService()
        {
            return new NavigationService<AllContractorTypesViewModel>(_navStore, () => new AllContractorTypesViewModel(_navStore, _navToolBarVM));
        }


        private NavigationService<AllCurenciesViewModel> CreateCurenciesNavigationService()
        {
            return new NavigationService<AllCurenciesViewModel>(_navStore, () => new AllCurenciesViewModel(_navStore, _navToolBarVM));
        }


        private NavigationService<AllDeliveryItemsViewModel> CreateDeliveryItemsNavigationService()
        {
            return new NavigationService<AllDeliveryItemsViewModel>(_navStore, () => new
            AllDeliveryItemsViewModel(_navStore, _navToolBarVM));
        }


        private NavigationService<AllDeliveryViewModel> CreateDeliveryNavigationService()
            {
                return new NavigationService<AllDeliveryViewModel>(_navStore, () => new
            AllDeliveryViewModel(_navStore, _navToolBarVM));
        }




        private NavigationService<AllEmplyeesViewModel> CreateEmplyeesNavigationService()
                {
                    return new NavigationService<AllEmplyeesViewModel>(_navStore, () => new
            AllEmplyeesViewModel(_navStore, _navToolBarVM));
        }




        private NavigationService<AllEmplyeeTypesViewModel> CreateEmplyeeTypesNavigationService()
                    {
                        return new NavigationService<AllEmplyeeTypesViewModel>(_navStore, () => new
            AllEmplyeeTypesViewModel(_navStore, _navToolBarVM));
        }




        private NavigationService<AllInvoicesViewModel> CreateInvoicesNavigationService()
                        {
                            return new NavigationService<AllInvoicesViewModel>(_navStore, () => new
            AllInvoicesViewModel(_navStore, _navToolBarVM));
        }




        private NavigationService<AllInvoiceItemsViewModel> CreateInvoiceItemsNavigationService()
                            {
                                return new NavigationService<AllInvoiceItemsViewModel>(_navStore, () => new
            AllInvoiceItemsViewModel(_navStore, _navToolBarVM));
        }




        private NavigationService<AllPaymentMethodsViewModel> CreatePaymentMethodsNavigationService()
                                {
                                    return new NavigationService<AllPaymentMethodsViewModel>(_navStore, () => new
            AllPaymentMethodsViewModel(_navStore, _navToolBarVM));
        }






        private NavigationService<AllSizeTypesViewModel> CreateSizeTypesNavigationService()
                                    {
                                        return new NavigationService<AllSizeTypesViewModel>(_navStore, () => new
            AllSizeTypesViewModel(_navStore, _navToolBarVM));
        }


        private NavigationService<AllStoragesViewModel> CreateStoragesNavigationService()
        {
                                            return new NavigationService<AllStoragesViewModel>(_navStore, () => new
            AllStoragesViewModel(_navStore, _navToolBarVM));
        }




        private NavigationService<AllWarehousesViewModel> CreateWarehousesNavigationService()
        {
                                                return new NavigationService<AllWarehousesViewModel>(_navStore, () => new
            AllWarehousesViewModel(_navStore, _navToolBarVM));
        }








        private NavigationService<AddBrandViewModel> CreateAddBrandsNavigationService()
        {
            return new NavigationService<AddBrandViewModel>(_navStore, () => new AddBrandViewModel(_navStore, _navToolBarVM));
        }

        private NavigationService<AddComodityViewModel> CreateAddComoditiesNavigationService()
        {
            return new NavigationService<AddComodityViewModel>(_navStore, () => new AddComodityViewModel(_navStore, _navToolBarVM));
        }

        private NavigationService<AddDeliveryStatusViewModel> CreateAddDeliveryStatusesNavigationService()
        {
            return new NavigationService<AddDeliveryStatusViewModel>(_navStore, () => new AddDeliveryStatusViewModel(_navStore, _navToolBarVM));
        }


        private NavigationService<AddComodityCategoryViewModel> CreateAddComodityCategoriesNavigationService()
        {
            return new NavigationService<AddComodityCategoryViewModel>(_navStore, () => new AddComodityCategoryViewModel(_navStore, _navToolBarVM));
        }


        private NavigationService<AddContractorViewModel> CreateAddContractorsNavigationService()
        {
            return new NavigationService<AddContractorViewModel>(_navStore, () => new AddContractorViewModel(_navStore, _navToolBarVM));
        }



        private NavigationService<AddContractorTypeViewModel> CreateAddContractorTypesNavigationService()
        {
            return new NavigationService<AddContractorTypeViewModel>(_navStore, () => new AddContractorTypeViewModel(_navStore, _navToolBarVM));
        }


        private NavigationService<AddCurrencyViewModel> CreateAddCurenciesNavigationService()
        {
            return new NavigationService<AddCurrencyViewModel>(_navStore, () => new AddCurrencyViewModel(_navStore, _navToolBarVM));
        }


        private NavigationService<AddDeliveryItemViewModel> CreateAddDeliveryItemsNavigationService()
        {
            return new NavigationService<AddDeliveryItemViewModel>(_navStore, () => new AddDeliveryItemViewModel(_navStore, _navToolBarVM));
        }


        private NavigationService<AddDeliveryViewModel> CreateAddDeliveryNavigationService()
        {
            return new NavigationService<AddDeliveryViewModel>(_navStore, () => new AddDeliveryViewModel(_navStore, _navToolBarVM));
        }




        private NavigationService<AddEmployeeViewModel> CreateAddEmplyeesNavigationService()
        {
            return new NavigationService<AddEmployeeViewModel>(_navStore, () => new AddEmployeeViewModel(_navStore, _navToolBarVM));
        }




        private NavigationService<AddEmployeeTypeViewModel> CreateAddEmplyeeTypesNavigationService()
        {
            return new NavigationService<AddEmployeeTypeViewModel>(_navStore, () => new AddEmployeeTypeViewModel(_navStore, _navToolBarVM));
        }




        private NavigationService<AddInvoiceViewModel> CreateAddInvoicesNavigationService()
        {
            return new NavigationService<AddInvoiceViewModel>(_navStore, () => new AddInvoiceViewModel(_navStore, _navToolBarVM));
        }




        private NavigationService<AddInvoiceItemViewModel> CreateAddInvoiceItemsNavigationService()
        {
            return new NavigationService<AddInvoiceItemViewModel>(_navStore, () => new AddInvoiceItemViewModel(_navStore, _navToolBarVM));
        }




        private NavigationService<AddPaymentMethodViewModel> CreateAddPaymentMethodsNavigationService()
        {
            return new NavigationService<AddPaymentMethodViewModel>(_navStore, () => new AddPaymentMethodViewModel(_navStore, _navToolBarVM));
        }






        private NavigationService<AddSizeTypeViewModel> CreateAddSizeTypesNavigationService()
        {
            return new NavigationService<AddSizeTypeViewModel>(_navStore, () => new AddSizeTypeViewModel(_navStore, _navToolBarVM));
        }


        private NavigationService<AddStorageViewModel> CreateAddStoragesNavigationService()
        {
            return new NavigationService<AddStorageViewModel>(_navStore, () => new AddStorageViewModel(_navStore, _navToolBarVM));
        }




        private NavigationService<AddWarehouseViewModel> CreateAddWarehousesNavigationService()
        {
            return new NavigationService<AddWarehouseViewModel>(_navStore, () => new AddWarehouseViewModel(_navStore, _navToolBarVM));
        }
    }
}

