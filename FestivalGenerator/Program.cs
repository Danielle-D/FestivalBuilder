namespace FestivalGenerator
{
    using System;
    using System.Speech.Synthesis;

    public class Program
    {
        public static void Main(string[] args)
        {
            SpeechSynthesizer speech = new SpeechSynthesizer();
            speech.Speak("Welcome to the festival planner");

            Festival festival = new Festival();

            Console.WriteLine("What is the name of your festival?");
            festival.FestivalName = Console.ReadLine();

            Console.WriteLine("How many days is your festival?");
            festival.FestivalLength = Convert.ToInt32(Console.ReadLine());

            if (festival.FestivalLength <= 0)
            {
                Console.WriteLine("Please renter a number between 1 and 7:");
                festival.FestivalLength = Convert.ToInt32(Console.ReadLine());
            }

            else if (festival.FestivalLength > 7)
            {
                Console.WriteLine("Please renter a number between 1 and 7:");
                festival.FestivalLength = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("What date does your festival start?");
            festival.FestivalDate = Convert.ToDateTime(Console.ReadLine());

            if (festival.FestivalDate <= DateTime.Today)
            {
                Console.WriteLine("Please renter a valid festival start date:");
                festival.FestivalDate = Convert.ToDateTime(Console.ReadLine());
            }

            Console.WriteLine("What bands are playing on the first day?");
            festival.AddBands(Console.ReadLine());

            WriteDayResult("Your festival starts on", festival.StartDayCalculator(festival.FestivalDate));
            WriteDateResult("Your festival starts on", festival.FestivalDate);
            WriteDayResult("Your festival ends on",
                              festival.EndDayCalculator(festival.FestivalDate, festival.FestivalLength));
            WriteDateResult("Your festival ends on",
                              festival.EndDateCalculator(festival.FestivalDate, festival.FestivalLength));     
        }

        static void WriteDateResult(string description, DateTime result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteDayResult(string description, System.DayOfWeek result)
        {
            Console.WriteLine(description + " : " + result);
        }
    }
}