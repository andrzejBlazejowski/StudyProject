using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.Validators
{
    public class StringValidator:Validators
    {
        public static string NotEmpty(string value)
        {
            try
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    return "wypełnij to pole !";
                }
            }
            catch (Exception) { };

            return null;
        }
    }
}
