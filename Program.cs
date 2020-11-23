using System;
using System.Threading;

namespace CSharp_Sleep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check CPU Usage");
            while (true)
            {
                Thread.Sleep(0);
            }
        }
    }
}
