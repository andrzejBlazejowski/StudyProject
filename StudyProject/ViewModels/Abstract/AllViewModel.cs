using StudyProject.Model;

using StudyProject.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System;

namespace StudyProject.ViewModels.Abstract
{
    public abstract class AllViewModel<T> :TabVM where T : class
    {
        #region Fields
        private readonly ZaliczenieEntities zaliczenieEntities;
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
                OnPropertyChanged(()=>Data);
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
