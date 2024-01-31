namespace P05_DateModifier
{
    using System;

    public class StartUp
    {
        //The code is a simple C# console application
        //that calculates the difference in days between two dates using the DateModifier class.
        //The program takes two dates as input, converts them to DateTime objects,
        //and then calculates the absolute difference in days.
        static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            DateModifier dateModifier = new DateModifier(date1, date2);
            Console.WriteLine(dateModifier.GetDaysDifference(date1, date2));
        }
    }
}
