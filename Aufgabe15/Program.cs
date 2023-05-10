using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe15
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

            while (diff < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zu wenig bezahlt, bitte noch {0} Fr. bezahlen", -diff);
                paid += int.Parse(Console.ReadLine());
                diff = paid - total;
            }

            if (diff == 0)
            {
                Console.WriteLine("Vielen Dank für Ihren Einkauf");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Rückgeld: {0} Fr.", diff);
            }

            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
