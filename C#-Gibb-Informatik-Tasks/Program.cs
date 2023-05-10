using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Gibb_Informatik_Tasks
{
    internal class Program
    {
        static void Main()
        {
            // Total des Einkaufs und bezahlter Betrag abfragen
            Console.Write("Total des Einkaufs: ");
            int total = int.Parse(Console.ReadLine());

            Console.Write("Bezahlter Betrag: ");
            int bezahlt = int.Parse(Console.ReadLine());

            // Rückgeld oder offene Differenz berechnen
            int diff = bezahlt - total;

            if (diff >= 0)
            {
                // Rückgeld anzeigen
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Rückgeld: {0} Fr.", diff);
            }
            else
            {
                // Differenz anzeigen
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Differenz: {0} Fr.", -diff);
            }

            // Konsolenfenster offen halten
            Console.ReadLine();
        }
    }
}
