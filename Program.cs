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
            Console.WriteLine("Welcome to the stopwatch! Select how long you want to count below:");
            Console.WriteLine("");

            Console.WriteLine("S => Seconds");
            Console.WriteLine("M => Minutes");
            Console.WriteLine("E => Exit");

            Console.WriteLine("");
            Console.Write("Enter your choice: ");

            string value = Console.ReadLine();

            Console.WriteLine($"parabéns você selecionou: {value}");
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


        }
    }
}
