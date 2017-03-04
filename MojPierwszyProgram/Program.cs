using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojPierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imię");
            string name = Console.ReadLine();
            Console.WriteLine($"Witaj {name}, miło Cię widzieć. Podaj swój ulubiony kolor");
            var color = Console.ReadLine();
            Console.WriteLine($"Cieszę się, że Twój ulubiony kolor to {color}" );
            Console.ReadKey();
            //
        }
    }
}
