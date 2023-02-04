using StudyProject.Commands;
using StudyProject.Model;
using StudyProject.Model.BusinessLogic;
using StudyProject.Model.EntitiesForViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;

namespace StudyProject.ViewModels.BuisnesLogic
{
    public class MonthlySalesReport: TabVM
    {
        public int _month;
        public int Month { 
            get { return _month; }
            set {
                if (value != _month) 
                {
                    _month = value;
                    OnPropertyChanged(()=>(_month));
                }
            }
        }
        public IQueryable<KeyAndValue> Months{ get; set; }
        public int _year;
        public int Year
        {
            get { return _year; }
            set
            {
                if (value != _year)
                {
                    _year = value;
                    OnPropertyChanged(()=>(_year));
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

        public IQueryable<KeyAndValue> Years { get; set; }

        public int _contractorId;
        public int ContractorId
        {
            get { return _contractorId; }
            set
            {
                if (value != _contractorId)
                {
                    _contractorId = value;
                    OnPropertyChanged(()=>(_contractorId));
                }
            }
        }

        public IQueryable<KeyAndValue> Contractors
        {
            get
            {
                return new ContractorB(zaliczenieEntities).GetActiveContractors();
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

        public MonthlySalesReport()
        {
            base.Title = "raport spżedaży dla zadanego miesiąca";
            zaliczenieEntities = new ZaliczenieEntities();
            Month = DateTime.Today.Month;
            Year = DateTime.Today.Year;
            ContractorId = 1;
            Takings = 0;

            Years = new List<KeyAndValue>
            {
                new KeyAndValue { Key = 2017, Value = "2017" },
                new KeyAndValue { Key = 2018, Value = "2018" },
                new KeyAndValue { Key = 2019, Value = "2019" },
                new KeyAndValue { Key = 2020, Value = "2020" },
                new KeyAndValue { Key = 2021, Value = "2021" },
                new KeyAndValue { Key = 2022, Value = "2022" },
                new KeyAndValue { Key = 2023, Value = "2023" },
            }.AsQueryable();


            Months = new List<KeyAndValue>
            {
                new KeyAndValue { Key = 1, Value = "styczeń" },
                new KeyAndValue { Key = 2, Value = "luty" },
                new KeyAndValue { Key = 3, Value = "marzec" },
                new KeyAndValue { Key = 4, Value = "kwiecień" },
                new KeyAndValue { Key = 5, Value = "maj" },
                new KeyAndValue { Key = 6, Value = "czerwiec" },
                new KeyAndValue { Key = 7, Value = "lipiec" },
                new KeyAndValue { Key = 8, Value = "sierpień" },
                new KeyAndValue { Key = 9, Value = "wrzesień" },
                new KeyAndValue { Key = 10, Value = "październik" },
                new KeyAndValue { Key = 11, Value = "listopad" },
                new KeyAndValue { Key = 12, Value = "grudzień" },
            }.AsQueryable();

        }


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
            Takings = new SalesB(zaliczenieEntities).SalesMonthContractor(ContractorId, Month, Year);
        }


    }
}
