using System;

namespace Generics
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfEntries = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfEntries; i++)
            {
                var input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                Console.WriteLine(box);
            }
        }
    }
}
