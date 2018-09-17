using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FestivalGenerator
{
    public class Festival
    {
        public Festival()
        {
            firstDayBands = new List<string>();
        }

        public string FestivalName;
        public int FestivalLength;
        public DateTime FestivalDate;

        public void AddBands(string bands)
        {
            firstDayBands.Add(bands);
        }

        public DayOfWeek StartDayCalculator(DateTime FestivalDate)
        {
            var dayOfWeek = FestivalDate.DayOfWeek;
            return dayOfWeek;
        }

        public DayOfWeek EndDayCalculator(DateTime FestivalDate, int FestivalLength)
        {
            var endDateDayOfWeek = FestivalDate.AddDays(FestivalLength).DayOfWeek;
            return endDateDayOfWeek;
        }

        public DateTime EndDateCalculator(DateTime FestivalDate, int FestivalLength)
        {
            var endDate = FestivalDate.AddDays(FestivalLength).Date;
            return endDate;
        }

      private List<string> firstDayBands;
       
    }
}