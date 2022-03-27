using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace _1911065208_CaoVanHau.ViewModel
{
    public class FutureDate : ValidationAttribute
    {
        public object Covert { get; private set; }

        public override bool IsValid(object value)
        {
            var isValid = DateTime.TryParseExact(Convert.ToString(value),
                "dd/m/yyyy",
                CultureInfo.CurrentCulture,
                System.Globalization.DateTimeStyles.None,
                out DateTime dateTime);
            return (isValid && dateTime > DateTime.Now);
        }
    }
}