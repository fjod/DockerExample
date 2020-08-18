using System;
using System.IO;
using System.Linq;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileLocation = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var directory = Path.GetDirectoryName(fileLocation);
            
            Console.WriteLine("Hello World from Console app!");
            DateTime finish = DateTime.Now;
            finish = finish.AddSeconds(1000);
            while (DateTime.Now < finish)
            {
                Console.WriteLine($"Console App Heartbeat {DateTime.Now.TimeOfDay}");
                Thread.Sleep(1000);
                var files = Directory.EnumerateFiles(directory);
                if (files.Any(f => f.Contains("stop")))
                {
                    Console.WriteLine($"Stopping");
                    break;
                }
            }
        }
    }
}