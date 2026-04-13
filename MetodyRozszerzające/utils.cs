using System;
using System.Collections.Generic;
using System.Text;

namespace MetodyRozszerzające
{
    public static class utils
    {
        public static bool IsDateBetween(DateTime date, DateTime from, DateTime to)
        {
            return date > from && date < to;
        }
        public static bool IsBetween(this DateTime date, DateTime from, DateTime to)
        {
            return date > from && date < to;
        }
    }
}
