
using StudyProject.Commands;
using StudyProject.Model;
using StudyProject.Services;
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
using System.Windows.Navigation;

namespace StudyProject.ViewModels
{
    public class AllCurenciesViewModel : AllViewModel<curency>
    {


        public ICommand goToAllBrandsCmd { get; }

        #region Constructor
        public AllCurenciesViewModel(NavStore navStore, NavigationToolBarViewModel navToolBarvm)
            : base(navStore, navToolBarvm, "waluty")
        {
            goToAllBrandsCmd = new NavigateCmd<AllBrandsViewModel>(new NavigationService<AllBrandsViewModel>(navStore ,() => new AllBrandsViewModel(navStore, navToolBarvm)) );
        }
        #endregion
        #region Helpers
        public override void Load()
        {
            Data = new ObservableCollection<curency>
                (
                  
                  from curency in ZaliczenieEntities.curencies 
                  where curency.is_active == true
                  select curency 
                );
        }
        #endregion
    }
}
