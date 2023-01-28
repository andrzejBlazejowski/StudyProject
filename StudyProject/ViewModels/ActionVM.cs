using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudyProject.ViewModels
{
    public class ActionVM:TabVM
    {
        public string Key { get; set; }
        public ICommand Action { get; set; }
        public TabVM AddVM { get; set; }
        public ActionVM(string key, ICommand action, TabVM AddVM = null)
        {
            if (action == null)
                throw new ArgumentNullException("Command");
            Key = key;
            Action = action;
            AddVM = AddVM;
        }
    }
}
