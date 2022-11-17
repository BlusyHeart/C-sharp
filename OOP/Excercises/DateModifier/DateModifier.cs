using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public static class DateModifier
    {

        public static int DifferenceInDays(string firsData, string secondData)
        {

            DateTime fistDate = DateTime.Parse(firsData);
            DateTime secondDate = DateTime.Parse(secondData);

            int days = Math.Abs((fistDate - secondDate).Days);
            return days;
        }

    }
}
