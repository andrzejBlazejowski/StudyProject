using StudyProject.Commands;
using StudyProject.Model;
using StudyProject.Model.BusinessLogic;
using StudyProject.Model.EntitiesForViewModel;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace StudyProject.ViewModels.BuisnesLogic
{
    public class ComoditySalesReportVM : TabVM
    {

        public int _comodityId;
        public int ComodityId
        {
            get { return _comodityId; }
            set
            {
                if (value != _comodityId)
                {
                    _comodityId = value;
                    OnPropertyChanged(()=>(_comodityId));
                }
            }
        }
        private ICommand _SaveCommand;
        public ICommand saveCommand
        {
            get
            {
                return _SaveCommand;
            }
        }


        public IQueryable<KeyAndValue> comodity
        {
            get
            {
                return new ComodityB(zaliczenieEntities).GetActivecomodity();
            }
        }

        public decimal? _takings;
        public decimal? Takings
        {
            get { return _takings; }
            set
            {
                if (value != _takings)
                {
                    _takings = value;
                    OnPropertyChanged(()=>(_takings));
                    OnPropertyChanged(()=>(Takings));
                }
            }
        }

        public ZaliczenieEntities zaliczenieEntities { get; set; }

        public ComoditySalesReportVM()
        {
            base.Title = "raport spżedaży dla zadanego towaru";
            zaliczenieEntities = new ZaliczenieEntities();

            ComodityId = 1;
            Takings = 0;
        }



        //TODO: remove this when you will not render unesesery buttons on add page
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
        // end TODO

        //TODO: remove this when you will not render filtering and sorting on add pages
        public string FilterField { get; set; }
        public string FilterValue { get; set; }
        public string SortField { get; set; }
        public string SortType { get; set; }
        public List<string> FilterFields
        {
            get
            {
                return new List<string> { };
            }
        }
        public List<string> SortFields
        {
            get
            {
                return new List<string> { };
            }
        }
        public List<string> SortTypes
        {
            get
            {
                return new List<string> { };
            }
        }

        public ICommand SortCommand
        {
            get
            {
                return new BaseCommand(() => { });
            }
        }
        public ICommand FilterCommand
        {
            get
            {
                return new BaseCommand(() => { });
            }
        }
        public ICommand SaveCommand
        {
            get
            {
                return null;
            }
        }

        // end TODO
        private BaseCommand _ObliczCommand;
        public BaseCommand ObliczCommand
        {
            get
            {
                if (_ObliczCommand == null)
                {
                    _ObliczCommand = new BaseCommand(() => GetTakingsClickHandler());
                }
                return _ObliczCommand;
            }
        }

        private void GetTakingsClickHandler()
        {
            Takings = new SalesB(zaliczenieEntities).SalesComodity(ComodityId);
        }


    }
}
