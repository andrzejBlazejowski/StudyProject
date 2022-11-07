﻿using StudyProject.Model;
using StudyProject.Stores;
using StudyProject.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace StudyProject.ViewModels.List
{
    public class AllInvoiceItemsViewModel : AllViewModel<invoice_item>
    {

        #region Constructor
        public AllInvoiceItemsViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "pozycje faktury")
        {
            NavigateAddCmd =NavigateAddInvoiceItemsCmd;
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<invoice_item>
                (

                  from invoice_item in ZaliczenieEntities.invoice_item
                  where invoice_item.is_active == true
                  select invoice_item
                );
        }
        #endregion
    }
}
