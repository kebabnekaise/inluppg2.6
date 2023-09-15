using System;
using System.Runtime.InteropServices;

namespace inluppg2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening med tre ord och punkt i slutet");
            string mening = Console.ReadLine();
            int mellanslag1 = mening.IndexOf(' ');
            int mellanslag2 = mening.IndexOf(' ',mellanslag1 + 1);
            int punkt = mening.IndexOf('.');

            Console.WriteLine($"{mening[(mellanslag2+1)..punkt]}{mening[mellanslag1..mellanslag2]} {mening[..mellanslag1]}.");
        }
    }
}