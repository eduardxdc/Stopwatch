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
            Start(5);
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
