using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trydem.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dob) //date of  birth
        {
            var today = DateTime.Today;
            var age = today.Year - dob.Year;
            if (dob.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
