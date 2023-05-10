using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Total des Einkaufs: ");
            int total = int.Parse(Console.ReadLine());

            Console.Write("Bezahlter Betrag: ");
            int paid = int.Parse(Console.ReadLine());

            int diff = paid - total;

            if (diff == 0)
            {
                Console.WriteLine("Vielen Dank für Ihren Einkauf");
            }
            else if (diff > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Rückgeld: {0} Fr.", diff);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Differenz: {0} Fr.", -diff);
            }

            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
