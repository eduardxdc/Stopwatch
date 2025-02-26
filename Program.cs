using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("Welcome to the stopwatch! Select how long you want to count below:");
            Console.WriteLine("");

            Console.WriteLine("S => Seconds = 10s = 10 Seconds");
            Console.WriteLine("M => Minutes = 1m = 1 Minute");
            Console.WriteLine("E => Exit");

            Console.WriteLine("");
            Console.Write("Enter your choice: ");

            string value = Console.ReadLine().ToLower();
            char type = char.Parse(value.Substring(value.Length - 1, 1));
            int time = int.Parse(value.Substring(0, value.Length - 1));

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 'e')
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);

            Console.WriteLine("Set...");
            Thread.Sleep(1000);

            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();

                currentTime++;
                Console.WriteLine(currentTime);

                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.Write("Stopwatch Finish!");
            Thread.Sleep(2500);

            Menu();
        }
    }
}
