namespace FestivalGenerator
{
    using System;
    using System.IO;
    using System.Speech.Synthesis;
    using System.Text;

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
            festival.FestivalStartDate = Convert.ToDateTime(Console.ReadLine());

            if (festival.FestivalStartDate <= DateTime.Today)
            {
                Console.WriteLine("Please renter a valid festival start date:");
                festival.FestivalStartDate = Convert.ToDateTime(Console.ReadLine());
            }

            Console.WriteLine("What bands are playing on the first day?");
            festival.AddBands(Console.ReadLine());

            WriteResult("Your festival starts on", festival.StartDayCalculator(festival.FestivalStartDate));
            WriteResult("Your festival starts on the", festival.FestivalStartDate);
            WriteResult("Your festival ends on",
                festival.EndDayCalculator(festival.FestivalStartDate, festival.FestivalLength));
            WriteResult("Your festival ends on the",
                festival.EndDateCalculator(festival.FestivalStartDate, festival.FestivalLength));

            StringBuilder csvStringBuilderData = new StringBuilder();
            csvStringBuilderData.AppendLine("Festival Name,Number Of Days,Festival Start Date,Festival End Date");
            csvStringBuilderData
                .Append(festival.FestivalName + ",")
                .Append(festival.FestivalLength + ",")
                .Append(festival.StartDay + " ")
                .Append(festival.FestivalStartDate + ",")
                .Append(festival.EndDay + " ")
                .Append(festival.EndDate + ",");
            string csvPath = "C:\\CSVExport\\FestivalInformation.csv";
            File.AppendAllText(csvPath, csvStringBuilderData.ToString());
        }

        static void WriteResult(string description, DateTime result)
        {
            Console.WriteLine("{0}: {1:D}", description, result);
        }

        static void WriteResult(string description, System.DayOfWeek result)
        {
            Console.WriteLine("{0}: {1}", description, result);
        }
    }
}