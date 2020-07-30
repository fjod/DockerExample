using System;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Console app!");
            DateTime finish = DateTime.Now;
            finish = finish.AddSeconds(10);
            while (DateTime.Now < finish)
            {
                Console.WriteLine($"Console App Heartbeat {DateTime.Now.TimeOfDay}");
                Thread.Sleep(1000);
            }
        }
    }
}