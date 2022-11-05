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
            CreateEmplyeesNavigationService()
                
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

    }
}

