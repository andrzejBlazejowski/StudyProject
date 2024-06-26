﻿using GalaSoft.MvvmLight.Messaging;
using StudyProject.Commands;
using StudyProject.Model.EntitiesForViewModel;

using StudyProject.View;
using StudyProject.ViewModels.BuisnesLogic;
using StudyProject.ViewModels.List;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace StudyProject.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        #region Fields
        private Collection<ActionVM> _Actions;
        public Collection<ActionVM> Actions { get { 
                if(_Actions == null) {
                    _Actions = createActions();
                }
                return _Actions; 
            } 
        }
        #endregion

        private Collection<ActionVM> createActions() {
            Messenger.Default.Register<string>(this, handleMessage);

            return new Collection<ActionVM>() {
                new ActionVM("Miesięczny raport sprzedaży",
                new BaseCommand(() => createTab(new MonthlySalesReport()))),

                new ActionVM("Raport sprzedaży towaru",
                new BaseCommand(() => createTab(new ComoditySalesReportVM()))),

                new ActionVM("producenci",
                new BaseCommand(() => createTab(new AllbrandViewModel())),
                new AddBrandViewModel()),

                new ActionVM("towary",
                new BaseCommand(() => createTab(new AllcomodityViewModel())),
                new AddComodityViewModel()),

                new ActionVM("typy towarów",
                new BaseCommand(() => createTab(new AllComodityCategoriesViewModel())),
                new AddComodityCategoryViewModel()),

                new ActionVM("kontrachenci",
                new BaseCommand(() => createTab(new AllcontractorViewModel())),
                new AddContractorViewModel()),

                new ActionVM("typy kontrachentów",
                new BaseCommand(() => createTab(new AllContractorTypesViewModel())),
                new AddContractorTypeViewModel()),

                new ActionVM("waluty",
                new BaseCommand(() => createTab(new AllcurencyViewModel())), 
                new AddCurrencyViewModel()),

                new ActionVM("pozycje dostawy",
                new BaseCommand(() => createTab(new AllDeliveryItemsViewModel())), 
                new AddDeliveryItemViewModel()),

                new ActionVM("dostawy",
                new BaseCommand(() => createTab(new AllDeliveryViewModel())), 
                new AddDeliveryViewModel()),

                new ActionVM("statusy dostawy",
                new BaseCommand(() => createTab(new AllDeliveryStatusesViewModel())), 
                new AddDeliveryStatusViewModel()),

                new ActionVM("pracownicy",
                new BaseCommand(() => createTab(new AllEmplyeesViewModel())), 
                new AddEmployeeViewModel()),

                new ActionVM("typy pracowników",
                new BaseCommand(() => createTab(new AllEmplyeeTypesViewModel())), 
                new AddEmployeeTypeViewModel()),

                new ActionVM("pozycje faktury",
                new BaseCommand(() => createTab(new AllInvoiceItemsViewModel())),
                new AddInvoiceItemViewModel()),

                new ActionVM("faktury",
                new BaseCommand(() => createTab(new AllinvoiceViewModel())),
                new AddInvoiceViewModel()),
                
                new ActionVM("metody płatności",
                new BaseCommand(() => createTab(new AllPaymentMethodsViewModel())),
                new AddPaymentMethodViewModel()),
                
                new ActionVM("rozmiary",
                new BaseCommand(() => createTab(new AllSizeTypesViewModel())),
                new AddSizeTypeViewModel()),
                
                new ActionVM("miejsca magazynowe",
                new BaseCommand(() => createTab(new AllstorageViewModel())),
                new AddStorageViewModel()),
                
                new ActionVM("magazyny",
                new BaseCommand(() => createTab(new AllwarehouseViewModel())),
                new AddWarehouseViewModel()),
            };
        }

        private void handleMessage(string message)
        {
            Boolean lookupMode = true;
            switch (message)
            {
                case "Add":
                    NavigateAdd();
                    break;
                case "lookupbrand":
                    createTab(new AllbrandViewModel(lookupMode));
                    break;
                case "lookupComodity":
                    createTab(new AllcomodityViewModel(lookupMode));
                    break;
                case "lookupInvoice":
                    createTab(new AllinvoiceViewModel(lookupMode));
                    break;
                case "lookupContractor":
                    createTab(new AllcontractorViewModel(lookupMode));
                    break;
                case "lookupDelivery":
                    createTab(new AllDeliveryViewModel(lookupMode));
                    break;
                default:
                    MessageBox.Show(message);
                    break;
            }
        }

        private void NavigateAdd() {
            ICollectionView collectionView = CollectionViewSource.GetDefaultView(this.Tabs);
            TabVM currentTab = collectionView.CurrentItem as TabVM;
            if (currentTab != null)
            {
                foreach (ActionVM action in Actions)
                {
                    if(action != null && action.Key == currentTab.Title)
                    {
                        createTab(action.AddVM);
                    }
                }
            }
        }

        private void createTab(TabVM tab)
        {
            this.Tabs.Add(tab);
            this.setCurrentTab(tab);
        }

        private ObservableCollection<TabVM> _Tabs;
        public ObservableCollection<TabVM> Tabs
        {
            get
            {
                if (_Tabs == null) {
                    _Tabs = new ObservableCollection<TabVM>();
                    _Tabs.CollectionChanged += this.onTabsChanged;
                }
                return _Tabs;
            }
        }
        private void onTabsChanged(object caller, NotifyCollectionChangedEventArgs action)
        {
            if (action != null && action.NewItems?.Count > 0) 
            {
                foreach(TabVM Tab in action.NewItems) 
                {
                    Tab.RequestClose += this.onTabReqClose;
                }
            }
            if (action != null && action.OldItems?.Count > 0)
            {
                foreach (TabVM Tab in action.OldItems)
                {
                    Tab.RequestClose += this.onTabReqClose;
                }
            }
        }

        private void onTabReqClose(object caller, EventArgs action)
        {
            this.Tabs.Remove((TabVM)caller);
        }
        private void setCurrentTab(TabVM tab)
        {
            ICollectionView defaultView = CollectionViewSource.GetDefaultView(this.Tabs);
            if (defaultView != null)
                defaultView.MoveCurrentTo(tab);
        }
    }
}
