namespace FestivalGenerator
{
    using System;
    using System.Collections.Generic;

    public class Festival
    {
        public Festival()
        {
            this.firstDayBands = new List<string>();
        }

        public string FestivalName;
        public int FestivalLength;
        public DateTime FestivalDate;

        public void AddBands(string bands)
        {
            this.firstDayBands.Add(bands);
        }

        public DayOfWeek StartDayCalculator(DateTime festivalDate)
        {
            var dayOfWeek = festivalDate.DayOfWeek;
            return dayOfWeek;
        }

        public DayOfWeek EndDayCalculator(DateTime festivalDate, int festivalLength)
        {
            var endDateDayOfWeek = festivalDate.AddDays(festivalLength).DayOfWeek;
            return endDateDayOfWeek;
        }

        public DateTime EndDateCalculator(DateTime festivalDate, int festivalLength)
        {
            var endDate = festivalDate.AddDays(festivalLength).Date;
            return endDate;
        }

      private List<string> firstDayBands;
       
    }
}