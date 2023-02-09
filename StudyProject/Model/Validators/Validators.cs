using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.Validators
{
    public class Validators
    {
        public Validators()
        {

        }

        public static string NotNull(string value)
        {
            try
            {
                if(value == null)
                {
                    return "wypełnij to pole !";
                }
            }
            catch (Exception) { };
            
            return null;
        }
    }
}
