using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyProject.Model.Validators
{
    public class BusinesValidator:Validators
    {
        public static string IsValidNIP(string nip)
        {
            if (string.IsNullOrWhiteSpace(nip) || nip.Length != 10)
            {
                return "podja nip";
            }

            int[] weights = { 6, 5, 7, 2, 3, 4, 5, 6, 7 };
            int sum = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                sum += weights[i] * (nip[i] - '0');
            }

            int controlNumber = sum % 11;
            int lastDigit = nip[9] - '0';

            if (controlNumber != lastDigit) 
            {
                return "nieprawidłowy numer nip";
            }
            return null;
        }
    }
}
