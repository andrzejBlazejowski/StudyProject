using StudyProject.Services;
using StudyProject.Stores;
using StudyProject.ViewModels;
using StudyProject.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Commands
{
    public class NavigateCmd<Tvm> : CommandBase
        where Tvm : BaseViewModel
    {
        private readonly NavigationService<Tvm> _navService;

        public NavigateCmd(NavigationService<Tvm> navService)
        {
            _navService = navService;
        }

        public override void Execute(object param)
        {
            _navService.Navigate();
        }
    }
}
