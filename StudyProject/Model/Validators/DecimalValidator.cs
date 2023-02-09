using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.Validators
{
    public class DecimalValidator : Validators
    {
        public static string Positive(decimal value)
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
        public static string Negative(decimal value)
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
        public static string GreaterThan(decimal value, decimal check)
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
