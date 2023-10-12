using System;

namespace Opakovani1rocnik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random ferarinadrz = new Random();
            Auto Ferari = new Auto();
            Ferari.jménoauta = "Škoda";
            Ferari.kilometrynalitr = 10;
            Ferari.nádrž = 80;
            Ferari.aktuálnínádrž = ferarinadrz.Next(10, 80);

            int vyber = 0;
            Console.WriteLine("Zdravím, vyber si auto s kterým chceš jet na výlet.(Zadej číslo)");
            Console.WriteLine("1.Škoda");
            Console.WriteLine("2.Ferrari");
            vyber = int.Parse(Console.ReadLine());
            Specifikace(vyber); 

            while (true)
            {
            }
        }

        static public void Specifikace(int vyber)
        {
            if (vyber == 1)
            {
                Random skodanadrz = new Random();
                Auto Škoda = new Auto();
                Console.WriteLine(Škoda.jménoauta = "Škoda");
                Console.WriteLine(Škoda.jménoauta);
                Škoda.kilometrynalitr = 10;
                Škoda.nádrž = 55;
                Škoda.aktuálnínádrž = skodanadrz.Next(10, 55);
            }


        }
    }
}
