﻿using StudyProject.Model;

using StudyProject.Commands;
using System.Collections.ObjectModel;
using System.Windows.Input;
using System;
using GalaSoft.MvvmLight.Messaging;

namespace StudyProject.ViewModels.Abstract
{
    public abstract class AllViewModel<T> :TabVM where T : class
    {
        #region Fields
        private readonly ZaliczenieEntities zaliczenieEntities;
        public ICommand SaveCommand
        {
            get
            {
                return null;
            }
        }
        private BaseCommand _DeleteCommand;
        public BaseCommand DeleteCommand { 
            get
            {
                if (_DeleteCommand == null)
                    _DeleteCommand = null;
                return _DeleteCommand;
            }
            set
            {
                _DeleteCommand = value;
                OnPropertyChanged(() => _DeleteCommand);
            }
        }
        private BaseCommand _NavigateAddCommand;
        public BaseCommand NavigateAddCommand
        {
            get
            {
                if (_NavigateAddCommand == null)
                    _NavigateAddCommand = new BaseCommand(() =>
                    {
                        Messenger.Default.Send("Add");
                    });
                return _NavigateAddCommand;
            }
            set
            {
                _NavigateAddCommand = value;
                OnPropertyChanged(() => _NavigateAddCommand);
            }
        }
        private BaseCommand _RefreshCommand;
        public BaseCommand RefreshCommand
        {
            get
            {
                if (_RefreshCommand == null)
                    _RefreshCommand = new BaseCommand(() => {
                        Load();
                    });
                return _RefreshCommand;
            }
            set
            {
                _RefreshCommand = value;
                OnPropertyChanged(() => _RefreshCommand);
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
        public Boolean LookupMode { get; set; }
        private T _selectedRow;
        public T SelectedRow {
            get { return _selectedRow; }
            set
            {
                if (LookupMode && _selectedRow != value)
                {
                    _selectedRow = value;
                    Messenger.Default.Send(_selectedRow);
                    OnRequestClose();
                }
            } 
        }
        #endregion
        #region Constructor
        public AllViewModel(string title, Boolean lookupMode = false)
        {
            base.Title = title;
            this.zaliczenieEntities = new ZaliczenieEntities();
            LookupMode = lookupMode;
        }
        #endregion
        #region Helpers
        public abstract void Load();

        #endregion

    }
}
