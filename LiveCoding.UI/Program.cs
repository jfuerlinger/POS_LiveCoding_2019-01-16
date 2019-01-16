using System;
using System.Collections.Generic;
using System.Linq;

namespace LiveCoding.UI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var result = Enumerable.Empty<string>();
            PrintResult("Ergebnis", result);

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
