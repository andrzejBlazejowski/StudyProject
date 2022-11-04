using StudyProject.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.ViewModels
{
    public class MainViewModel:BaseViewModel
    {
        #region Fields
        public BaseViewModel CurrentViewModel { get; set; }
        #endregion
        #region Constructor
        public MainViewModel() {
            CurrentViewModel = new AllCurenciesViewModel();
        }
        #endregion
    }
}
