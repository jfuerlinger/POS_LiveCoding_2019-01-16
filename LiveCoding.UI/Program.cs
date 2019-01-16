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

            // Sortierung (Groß-/Kleinschreibung egal)
            //var result = text.OrderBy(x => char.ToUpper(x));

            // Position des ersten Leerzeichens ermitteln
            //var result = text
            //    .Select((c, idx) => new
            //    {
            //        Ch = c,
            //        Index = idx + 1
            //    })
            //    .Where(helper => helper.Ch == ' ')
            //    .Select(helper => helper.Index)
            //    .FirstOrDefault();

            // 10 Zufallszahlen generieren
            Random rand = new Random();
            var result = Enumerable.Range(1, 10).Select(x => rand.Next());

            PrintResult("Ergebnis", result);
            Console.WriteLine("-------------");

            result = result.Take(3);

            PrintResult("Ergebnis", result);

            //PrintResult("Ergebnis", result);
            Console.WriteLine(result);

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
