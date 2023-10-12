using System;

namespace Opakovani1rocnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random skodanadrz = new Random();
            Auto Škoda = new Auto();
            Škoda.jménoauta = "Škoda";
            Škoda.kilometrynalitr = 10;
            Škoda.nádrž = 55;
            Škoda.aktuálnínádrž = skodanadrz.Next(10, 55);

            Random ferarinadrz = new Random();
            Auto Ferari = new Auto();
            Ferari.jménoauta = "Škoda";
            Ferari.kilometrynalitr = 10;
            Ferari.nádrž = 80;
            Ferari.aktuálnínádrž = ferarinadrz.Next(10, 80);

            string vyber = "";

            while (vyber != "ukonceni") ;
            Console.WriteLine("Zdravím, vyber si auto s kterým chceš jet na výlet");
            Console.WriteLine("1.Škoda");
            Console.WriteLine("2.Ferrari");
            Console.WriteLine("Pro specifikace zadej |specifikace| a pro u končení |ukonceni|");
        }
    }
}
