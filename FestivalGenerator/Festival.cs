namespace FestivalGenerator
{
    using System;
    using System.Collections.Generic;

    public class Festival
    {
        public Festival()
        {
            this.FirstDayBands = new List<string>();
        }

        public string FestivalName;
        public int FestivalLength;
        public DateTime FestivalStartDate;
        public DayOfWeek StartDay;
        public DayOfWeek EndDay;
        public DateTime EndDate;
        public List<string> FirstDayBands;

        public void AddBands(string bands)
        {
            this.FirstDayBands.Add(bands);
        }

        public DayOfWeek StartDayCalculator(DateTime festivalStartDate)
        {
            StartDay = festivalStartDate.DayOfWeek;
            return StartDay;
        }

        public DayOfWeek EndDayCalculator(DateTime festivalStartDate, int festivalLength)
        {
            EndDay = festivalStartDate.AddDays(festivalLength).DayOfWeek;
            return EndDay;
        }

        public DateTime EndDateCalculator(DateTime festivalStartDate, int festivalLength)
        {
            EndDate = festivalStartDate.AddDays(festivalLength).Date;
            return EndDate;
        }
       
    }
}