using System;
using System.Collections.Generic;

namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in namn på matvaror:");
            string matvaror = Console.ReadLine().ToLower();
            string[] deladvaror = matvaror.Split(' ');

            Console.WriteLine("Skriv in matvarornas priser:");
            string priser = Console.ReadLine();
            string[] deladpriser = priser.Split(' ');

            Dictionary<string, int> handlingslista = new Dictionary<string, int>();

            for (int i = 0; i < deladvaror.Length; i++)
            {
                handlingslista[deladvaror[i]] = int.Parse(deladpriser[i]);
            }

            Console.WriteLine("Skriv in din handlingslista");
            string svar = Console.ReadLine().ToLower();
            string[] deladsvar = svar.Split(' ');

            int sum = 0;
            for (int i = 0; i < deladsvar.Length; i++)
            {
                sum += handlingslista[deladsvar[i]];
            }

            Console.WriteLine("Priset för handlingslistan är " + sum);
        }
    }
}