using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.Validators
{
    public class IntValidator:Validators
    {
        public static string Positive(int value)
        {
            try
            {
                if (value < 0)
                {
                    return "wpisz cyfrę powyżej zera";
                }
            }
            catch (Exception) { };

            return null;
        }
        public static string Negative(int value)
        {
            try
            {
                if (value > 0)
                {
                    return "wpisz cyfrę ponizej zera";
                }
            }
            catch (Exception) { };

            return null;
        }
        public static string GreaterThan(int value, int check)
        {
            try
            {
                if (value < check)
                {
                    return "wpisz cyfrę powyżej " + check.ToString() + " !";
                }
            }
            catch (Exception) { };

            return null;
        }
    }
}
