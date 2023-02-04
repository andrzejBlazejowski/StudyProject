using StudyProject.Commands;
using StudyProject.Model;
using StudyProject.Model.BusinessLogic;
using StudyProject.Model.EntitiesForViewModel;
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
