using StudyProject.Model;
using StudyProject.Stores;
using StudyProject.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace StudyProject.ViewModels.Abstract
{
    public abstract class AllViewModel<T> :BaseViewModel where T : class
    {
        #region Fields
        private readonly ZaliczenieEntities zaliczenieEntities;
        public NavigationToolBarViewModel NavigationToolBarViewModel { get; set; }

        public ICommand NavigateAllBrandsCmd { get; }
        public ICommand NavigateAllComoditiesCmd { get; }
        public ICommand NavigateAllComodityCategoryCmd { get; }
        public ICommand NavigateAllContractorsCmd { get; }
        public ICommand NavigateAllContractorTypesCmd { get; }
        public ICommand NavigateAllCurenciesCmd { get; }
        public ICommand NavigateAllDeliveryItemsCmd { get; }
        public ICommand NavigateAllDeliveryStatusesCmd { get; }
        public ICommand NavigateAllDeliveryCmd { get; }
        public ICommand NavigateAllEmplyeesCmd { get; }
        public ICommand NavigateAllEmplyeeTypesCmd { get; }
        public ICommand NavigateAllInvoicesCmd { get; }
        public ICommand NavigateAllInvoiceItemsCmd { get; }
        public ICommand NavigateAllPaymentMethodsCmd { get; }
        public ICommand NavigateAllSizeTypesCmd { get; }
        public ICommand NavigateAllStoragesCmd { get; }
        public ICommand NavigateWarehousesCmd { get; }

        public ZaliczenieEntities ZaliczenieEntities
        { 
            get
            {
                return zaliczenieEntities;
            }
        }
        //private BaseCommand _LoadCommand;
      /*  public ICommand LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                {
                    _LoadCommand = new BaseCommand(() => Load());//pusta wywoluje load
                }
                return _LoadCommand;
            }
        }*/
        private ObservableCollection<T> _Data;
        public ObservableCollection<T> Data
        {
            get
            {
                if (_Data == null) 
                    Load();
                return _Data;
            }
            set
            {
                _Data = value;
                OnPropertyChanged("Data");
            }
        }
        #endregion
        #region Constructor
        public AllViewModel(NavStore navStore, NavigationToolBarViewModel navigationToolBarViewModel, string title)
        {
            base.Title = title;
            this.zaliczenieEntities = new ZaliczenieEntities();

            NavigateAllBrandsCmd = navigationToolBarViewModel.NavigateAllBrandsCmd;
            NavigateAllComoditiesCmd = navigationToolBarViewModel.NavigateAllComoditiesCmd;
            NavigateAllComodityCategoryCmd = navigationToolBarViewModel.NavigateAllComodityCategoryCmd;
            NavigateAllContractorsCmd = navigationToolBarViewModel.NavigateAllContractorTypesCmd;
            NavigateAllContractorTypesCmd = navigationToolBarViewModel.NavigateAllContractorTypesCmd;
            NavigateAllCurenciesCmd = navigationToolBarViewModel.NavigateAllCurenciesCmd;
            NavigateAllDeliveryItemsCmd = navigationToolBarViewModel.NavigateAllDeliveryItemsCmd;
            NavigateAllDeliveryStatusesCmd = navigationToolBarViewModel.NavigateAllDeliveryStatusesCmd;
            NavigateAllDeliveryCmd = navigationToolBarViewModel.NavigateAllDeliveryCmd;
            NavigateAllEmplyeesCmd = navigationToolBarViewModel.NavigateAllEmplyeesCmd;
            NavigateAllEmplyeeTypesCmd = navigationToolBarViewModel.NavigateAllEmplyeeTypesCmd;
            NavigateAllInvoicesCmd = navigationToolBarViewModel.NavigateAllInvoicesCmd;
            NavigateAllInvoiceItemsCmd = navigationToolBarViewModel.NavigateAllInvoiceItemsCmd;
            NavigateAllPaymentMethodsCmd = navigationToolBarViewModel.NavigateAllPaymentMethodsCmd;
            NavigateAllSizeTypesCmd = navigationToolBarViewModel.NavigateAllSizeTypesCmd;
            NavigateAllStoragesCmd = navigationToolBarViewModel.NavigateAllStoragesCmd;
            NavigateWarehousesCmd = navigationToolBarViewModel.NavigateWarehousesCmd;
        }
        #endregion
        #region Helpers
        public abstract void Load();

        #endregion

    }
}
