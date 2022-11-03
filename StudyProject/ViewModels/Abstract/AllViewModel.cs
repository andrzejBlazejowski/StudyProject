using StudyProject.Model;
using StudyProject.ViewModels.Abstract;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace StudyProject.ViewModels.Abstract
{
    public abstract class AllViewModel<T> :BaseViewModel where T : class
    {
        #region Fields
        private readonly ZaliczenieEntities zaliczenieEntities;
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
        public AllViewModel(string title)
        {
            base.Title = title;
            this.zaliczenieEntities = new ZaliczenieEntities();
        }
        #endregion
        #region Helpers
        public abstract void Load();
        #endregion

    }
}
