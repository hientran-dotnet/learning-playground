namespace EnumurationSample
{

    enum DayOfWeek
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek today = DayOfWeek.Monday;
            Console.WriteLine(today);

            int dayValue = (int)DayOfWeek.Monday;
            Console.WriteLine(dayValue);

            DayOfWeek day = (DayOfWeek)4;
            Console.WriteLine(day);

            foreach (DayOfWeek dow in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine(dow);
            }

            Console.WriteLine("Enter number from 1 - 7:");
            int dayNumber = int.Parse(Console.ReadLine());

            if (Enum.IsDefined(typeof(DayOfWeek), dayNumber))
            {
                DayOfWeek day1 = (DayOfWeek)dayNumber;
                Console.WriteLine(day1);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
