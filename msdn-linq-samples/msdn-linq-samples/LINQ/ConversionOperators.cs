using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using msdn_linq_samples.Anonymous_Types;

namespace msdn_linq_samples.LINQ
{
    public class ConversionOperators
    {

        #region Simples

        public double[] Simple54()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };
            return doubles.OrderByDescending(x => x).ToArray();
        }

        public List<string> Simple55()
        {
            string[] words = { "cherry", "apple", "blueberry" };
            return words.OrderBy(x => x).ToList();
        }

        public Dictionary<string, ScoreRecord> Simple56()
        {
            var scoreRecords = new[] { new ScoreRecord{Name = "Alice", Score = 50},
                new ScoreRecord{Name = "Bob"  , Score = 40},
                new ScoreRecord{Name = "Cathy", Score = 45}
            };
            return scoreRecords.ToDictionary(x => x.Name);
        }

        public IEnumerable<double> Simple57()
        {
            object[] numbers = { null, 1.0, "two", 3, "four", 5, "six", 7.0 };
            return numbers.OfType<double>();
        }
        #endregion

        #region Displays

        public void DisplayMenu()
        {
            Console.WriteLine("\nConversions Operators");
            Console.WriteLine();
            for (var i = 1; i <= 4; i++)
                Console.WriteLine("{0}. Simple{1}", i, i + 53);
            Console.WriteLine("\nEsc. Exit");
        }

        #endregion

        public void RunConversionsOperators()
        {
            ConsoleKeyInfo cki;

            do
            {
                DisplayMenu();
                cki = Console.ReadKey(false);

                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        Console.WriteLine("\nEvery other double from highest to lowest:");
                        Display.Display.DisplayDoubles(Simple54());
                        break;
                    case "2":
                        Console.WriteLine("\nThe sorted word list:");
                        Display.Display.DisplayStrings(Simple55(), 1);
                        break;
                    case "3":
                        Console.WriteLine("\nScore records:");
                        Display.Display.DisplayScoreRecords(Simple56());
                        break;
                    case "4":
                        Console.WriteLine("\nNumbers stored as doubles:");
                        Display.Display.DisplayDoubles(Simple57());
                        break;
                    default:
                        Console.WriteLine(cki.Key == ConsoleKey.Escape
                            ? "\nGoing back to Main Menu"
                            : "\nNo such choice in the list\n");
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
