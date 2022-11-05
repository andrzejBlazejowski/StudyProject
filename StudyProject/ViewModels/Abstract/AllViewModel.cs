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
            NavigationToolBarViewModel = navigationToolBarViewModel;
        }
        #endregion
        #region Helpers
        public abstract void Load();

        #endregion

    }
}
