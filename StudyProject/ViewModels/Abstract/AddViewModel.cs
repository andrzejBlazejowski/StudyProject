using GalaSoft.MvvmLight.Messaging;
using StudyProject.Commands;
using StudyProject.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudyProject.ViewModels.Abstract
{
    public abstract class AddViewModel<T> : TabVM
    {
        public ZaliczenieEntities DB { get; set; }
        private BaseCommand _SaveCommand;
        public BaseCommand SaveCommand
        {
            get
            {
                if (_SaveCommand == null)
                {
                    _SaveCommand = new BaseCommand(() =>
                    {
                        Save();
                    });
                }
                return _SaveCommand;
            }
            set
            {
                _SaveCommand = value;
                OnPropertyChanged(() => _SaveCommand);
            }
        }

        private BaseCommand _DeleteCommand;
        public BaseCommand DeleteCommand
        {
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
                    _NavigateAddCommand = null;
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
                    _RefreshCommand = null;
                return _RefreshCommand;
            }
            set
            {
                _RefreshCommand = value;
                OnPropertyChanged(() => _RefreshCommand);
            }
        }

        public T Item { get; set; }
        public AddViewModel(string title)
        {
            base.Title = title;
            DB = new ZaliczenieEntities();
        }

        public abstract void Save();
        private void saveAndClose()
        {
            Save();
            this.OnRequestClose();
        }
    }
}
