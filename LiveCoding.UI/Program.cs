using System;
using System.Collections.Generic;
using System.Linq;

namespace LiveCoding.UI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string text = "HTL Leonding";

            // Eindeutige Großbuchstaben zählen
            //var result = text.Distinct().Count(c => char.IsUpper(c));
            
            //PrintResult("Ergebnis", result);
            //Console.WriteLine(result);

            Console.WriteLine("Bitte eine beliebige Taste zum Beenden drücken.");
        }

        private static void PrintResult<T>(string caption, IEnumerable<T> enumeration)
        {
            ConsoleColor originColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine();
            Console.WriteLine($"===================== {caption} ======================");
            foreach (var item in enumeration)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"======================= ENDE ========================");
            Console.WriteLine();

            Console.ForegroundColor = originColor;
        }
    }
}
