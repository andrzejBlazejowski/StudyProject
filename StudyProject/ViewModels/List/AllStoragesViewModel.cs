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
    public class AllStoragesViewModel : AllViewModel<storage>
    {

        #region Constructor
        public AllStoragesViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "miejsca w magazynach")
        {
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<storage>
                (

                  from storage in ZaliczenieEntities.storages
                  where storage.is_active == true
                  select storage
                );
        }
        #endregion
    }
}