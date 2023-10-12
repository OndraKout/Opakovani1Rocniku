using System;

namespace Opakovani1rocnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zdravím, vyber si auto s kterým chceš jet na výlet.(Zadej číslo)");
            Console.WriteLine("1.Škoda");
            Console.WriteLine("2.Ferrari");
            int vyber = int.Parse(Console.ReadLine());
            Console.Clear();
            Specifikace(vyber);
            int potvrzeni = int.Parse(Console.ReadLine());
            if(vyber == 2)
            {

            }
        }

        static public void Specifikace(int vyber)
        {
            if (vyber == 1)
            {
                Random skodanadrz = new Random();
                Auto Škoda = new Auto();
                Console.WriteLine($"Značka auta=        {Škoda.jménoauta = "Škoda"}");
                Console.WriteLine($"Spotřeba=           {Škoda.kilometrynalitr = 10}");
                Console.WriteLine($"Maximální nádrž=    {Škoda.nádrž = 55}");
                Console.WriteLine($"Aktuální nádrž=     {Škoda.aktuálnínádrž = skodanadrz.Next(10, 55)}");
            }
            if (vyber == 2)
            {
                Random ferarinadrz = new Random();
                Auto Ferari = new Auto();
                Console.WriteLine($"Značka auta=        {Ferari.jménoauta = "Ferari"}");
                Console.WriteLine($"Spotřeba=           {Ferari.kilometrynalitr = 15}");
                Console.WriteLine($"Maximální nádrž=    {Ferari.nádrž = 80}");
                Console.WriteLine($"Aktuální nádrž=     {Ferari.aktuálnínádrž = ferarinadrz.Next(10, 80)}");
            }
            Console.WriteLine("1.Nechat si auto");
            Console.WriteLine("2.Změnit auto");
        }
    }
}
