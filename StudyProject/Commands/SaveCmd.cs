using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Commands
{
    public class SaveCmd : CommandBase
    {
        private readonly Action _command;

        public SaveCmd(Action command)
        {
            _command = command;
        }

        public override void Execute(object param)
        {
            if (_command != null) _command();
        }
    }
}
