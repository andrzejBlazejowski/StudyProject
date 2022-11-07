using StudyProject.Model;
using StudyProject.Stores;
using StudyProject.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System;

namespace StudyProject.ViewModels.Abstract
{
    public abstract class AllViewModel<T> :BaseViewModel where T : class
    {
        #region Fields
        private readonly ZaliczenieEntities zaliczenieEntities;
        public NavigationToolBarViewModel NavigationToolBarViewModel { get; set; }

        public ICommand NavigateAddCmd { get; set; }

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
        public ICommand NavigateAllWarehousesCmd { get; }
        public ICommand NavigateAddBrandsCmd { get; }
        public ICommand NavigateAddComoditiesCmd { get; }
        public ICommand NavigateAddComodityCategoryCmd { get; }
        public ICommand NavigateAddContractorsCmd { get; }
        public ICommand NavigateAddContractorTypesCmd { get; }
        public ICommand NavigateAddCurenciesCmd { get; }
        public ICommand NavigateAddDeliveryItemsCmd { get; }
        public ICommand NavigateAddDeliveryStatusesCmd { get; }
        public ICommand NavigateAddDeliveryCmd { get; }
        public ICommand NavigateAddEmplyeesCmd { get; }
        public ICommand NavigateAddEmplyeeTypesCmd { get; }
        public ICommand NavigateAddInvoicesCmd { get; }
        public ICommand NavigateAddInvoiceItemsCmd { get; }
        public ICommand NavigateAddPaymentMethodsCmd { get; }
        public ICommand NavigateAddSizeTypesCmd { get; }
        public ICommand NavigateAddStoragesCmd { get; }
        public ICommand NavigateAddWarehousesCmd { get; }
        public ICommand saveCommand
        {
            get
            {
                return null;
            }
        }
        public ZaliczenieEntities ZaliczenieEntities
        { 
            get
            {
                return zaliczenieEntities;
            }
        }
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
            NavigateAllWarehousesCmd = navigationToolBarViewModel.NavigateAllWarehousesCmd;
            NavigateAddBrandsCmd = navigationToolBarViewModel.NavigateAddBrandsCmd;
            NavigateAddComoditiesCmd = navigationToolBarViewModel.NavigateAddComoditiesCmd;
            NavigateAddComodityCategoryCmd = navigationToolBarViewModel.NavigateAddComodityCategoryCmd;
            NavigateAddContractorsCmd = navigationToolBarViewModel.NavigateAddContractorTypesCmd;
            NavigateAddContractorTypesCmd = navigationToolBarViewModel.NavigateAddContractorTypesCmd;
            NavigateAddCurenciesCmd = navigationToolBarViewModel.NavigateAddCurenciesCmd;
            NavigateAddDeliveryItemsCmd = navigationToolBarViewModel.NavigateAddDeliveryItemsCmd;
            NavigateAddDeliveryStatusesCmd = navigationToolBarViewModel.NavigateAddDeliveryStatusesCmd;
            NavigateAddDeliveryCmd = navigationToolBarViewModel.NavigateAddDeliveryCmd;
            NavigateAddEmplyeesCmd = navigationToolBarViewModel.NavigateAddEmplyeesCmd;
            NavigateAddEmplyeeTypesCmd = navigationToolBarViewModel.NavigateAddEmplyeeTypesCmd;
            NavigateAddInvoicesCmd = navigationToolBarViewModel.NavigateAddInvoicesCmd;
            NavigateAddInvoiceItemsCmd = navigationToolBarViewModel.NavigateAddInvoiceItemsCmd;
            NavigateAddPaymentMethodsCmd = navigationToolBarViewModel.NavigateAddPaymentMethodsCmd;
            NavigateAddSizeTypesCmd = navigationToolBarViewModel.NavigateAddSizeTypesCmd;
            NavigateAddStoragesCmd = navigationToolBarViewModel.NavigateAddStoragesCmd;
            NavigateAddWarehousesCmd = navigationToolBarViewModel.NavigateAddWarehousesCmd;
        }
        #endregion
        #region Helpers
        public abstract void Load();

        #endregion

    }
}
