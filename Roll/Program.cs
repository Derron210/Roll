using System;

namespace Roll
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxBound = 100;
            if (args.Length > 0)
            {
                if (!Int32.TryParse(args[0], out maxBound))
                {
                    Console.WriteLine("Usage: roll [number]. Example: roll 100");
                    return;
                }
            }
            Random rand = new Random();
            Console.WriteLine(rand.Next(maxBound) + 1);
        }
    }
}
