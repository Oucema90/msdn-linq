using System;
using System.Collections.Generic;
using System.Linq;

namespace msdn_linq_samples.LINQ
{
    public class QueryExecutionOperators
    {
        #region Simples

        public IEnumerable<int> Simple99()
        {
            var numbers = new[] {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            return numbers.Select(x => ++x);
        }

        public IEnumerable<int> Simple100()
        {
            var numbers = Simple99();
            return numbers.ToList();
        }

        public Tuple<IEnumerable<int>, IEnumerable<int>> Simple101()
        {
            var numbers = new[] {5, 4, 1, 3, 9, 8, 6, 7, 2, 0};
            var lowNumbers = numbers.Where(x => x <= 3);
            var lowNumbersAltred = numbers.Select(x => -x);
            return Tuple.Create(lowNumbers, lowNumbersAltred);
        }

        #endregion

        #region Displays

        public void DisplayMenu()
        {
            Console.WriteLine("\nQuery Executions Operators");
            Console.WriteLine();
            Console.WriteLine("1. Simple99\n2. Simple100\n3. Simple101");
            Console.WriteLine("\nEsc. Exit");
        }

        #endregion

        public void RunQueryExecutionsOperators()
        {
            ConsoleKeyInfo cki;

            do
            {
                DisplayMenu();
                cki = Console.ReadKey(false);

                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        Console.WriteLine("\nDeferred Execution:");
                        Display.Display.DisplayInts(Simple99());
                        break;
                    case "2":
                        Console.WriteLine("\nImmediate Execution:");
                        Display.Display.DisplayInts(Simple100());
                        break;
                    case "3":
                        Console.WriteLine("\nQuery Reuse:");
                        Console.WriteLine("First");
                        Display.Display.DisplayInts(Simple101().Item1);
                        Console.WriteLine("Second");
                        Display.Display.DisplayInts(Simple101().Item2);
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
