using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2CsOOP
{
    public class HireDate
    {
        #region Properties
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        #endregion

        #region Constructor
        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        #endregion

        #region methods
        public DateTime ToDateTime()
        {
            return new DateTime(Year, Month, Day);
        }
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        } 
        #endregion
    }
}
