using StudyProject.Commands;
using StudyProject.Model;
using StudyProject.Model.BusinessLogic;
using StudyProject.Model.EntitiesForViewModel;
using StudyProject.Stores;
using StudyProject.ViewModels.Abstract;
using System.Linq;
using System.Windows.Input;

namespace StudyProject.ViewModels.BuisnesLogic
{
    public class ComoditySalesReportVM : BaseViewModel
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
                    OnPropertyChanged(nameof(_comodityId));
                }
            }
        }
        private SaveCmd _SaveCommand;
        public ICommand saveCommand
        {
            get
            {
                return _SaveCommand;
            }
        }


        public IQueryable<KeyAndValue> Comodities
        {
            get
            {
                return new ComodityB(zaliczenieEntities).GetActiveComodities();
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
                    OnPropertyChanged(nameof(_takings));
                    OnPropertyChanged(nameof(Takings));
                }
            }
        }

        public ZaliczenieEntities zaliczenieEntities { get; set; }

        public ComoditySalesReportVM(NavStore navStore, NavigationToolBarViewModel navigationToolBarViewModel)
              : base(navStore, navigationToolBarViewModel, "raport spżedaży dla zadanego towaru")
        {
            base.Title = "raport spżedaży dla zadanego towaru";
            zaliczenieEntities = new ZaliczenieEntities();

            ComodityId = 1;
            Takings = 0;
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
            Takings = new SalesB(zaliczenieEntities).SalesComodity(ComodityId);
        }


    }
}
