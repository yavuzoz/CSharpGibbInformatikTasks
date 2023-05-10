using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace definition for Aufgabe_11
namespace Aufgabe_11
{
    internal class Program
    {
        // Main function declaration with string array argument    
        public static void Main(string[] args)
        {
            // Declaration of string variables named zeichen and result
            string result;
            string zeichen;
            // Declaration of integer variables named zahl and i
            int zahl;
            int i;

            // Prompt user to enter a string and a number, then read the string input
            Console.WriteLine("Geben Sie eine Zeichen ein und  dann zahl ein ");
            zeichen = Console.ReadLine();

            // Call to the inputValue function to read a double value and cast it to an integer
            zahl = (int)inputValue();

            // Initialize the i variable to 0 and the result variable to an empty string
            i = 0;
            result = "";

            // While loop that runs as long as i is less than zahl
            while (i < zahl)
            {
                // Print the concatenation of the result string and the zeichen string
                Console.Write(result + zeichen);

                // Increment the i variable by 1
                i = i + 1;
            }

            // Wait for the user to press enter before closing the console window
            Console.ReadLine();
        }

        // Function to safely read a double value from the console
        private static double inputValue()
        {
            // Declaration of double variable named result
            double result;

            // While loop that continues until a valid double value is read from the console
            while (!double.TryParse(Console.ReadLine(), out result)) ;

            // Return the double value
            return result;
        }
    }
}
