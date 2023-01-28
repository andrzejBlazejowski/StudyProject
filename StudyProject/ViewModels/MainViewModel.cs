using StudyProject.Commands;
using StudyProject.Model.EntitiesForViewModel;

using StudyProject.View;
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
                //OnPropertyChanged(()=>(Actions));
                return _Actions; 
            } 
        }
        #endregion

        private Collection<ActionVM> createActions() {

            return new Collection<ActionVM>() {
                new ActionVM("brands",
                new BaseCommand(() => createTab(new AllBrandsViewModel()))),
                new ActionVM("comodities",
                new BaseCommand(() => createTab(new AllComoditiesViewModel()))),
                new ActionVM("comodities Categories",
                new BaseCommand(() => createTab(new AllComodityCategoriesViewModel()))),
                new ActionVM("kontrachenci",
                new BaseCommand(() => createTab(new AllContractorsViewModel()))),
                new ActionVM("contractor types",
                new BaseCommand(() => createTab(new AllContractorTypesViewModel()))),
            };
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
            Debug.Assert(this.Tabs.Contains(tab));

            ICollectionView defaultView = CollectionViewSource.GetDefaultView(this.Tabs);
            if (defaultView != null)
                defaultView.MoveCurrentTo(tab);
        }
    }
}
