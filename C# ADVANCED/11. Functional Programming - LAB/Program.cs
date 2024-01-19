namespace _02._Sum_Numbers
{
    using System;
    using System.Linq;

    public class SumNumbers
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            Func <int[], int> func = a => a.Length;
            Func <int[], int> func2 = b => b.Sum();

            Console.WriteLine(func(arr));
            Console.WriteLine(func2(arr));
        }
    }
}
