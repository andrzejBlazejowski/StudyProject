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
            _navToolBarVM = new NavigationToolBarViewModel(
                CreateBrandsNavigationService(), 
                CreateComoditiesNavigationService(), 
                CreateDeliveryStatusesNavigationService()
            );
            _navStore = new NavStore(_navToolBarVM);
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
    }
}
