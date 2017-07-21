using System;
using System.Collections.Generic;
using System.Linq;
using msdn_linq_samples.Anonymous_Types;

namespace msdn_linq_samples.LINQ
{
    public class GenerationOperators
    {
        #region Simples

        public IEnumerable<DigitEven> Simple65()
        {
            var numbers = Enumerable.Range(100, 50);
            return numbers.Select(x => new DigitEven
            {
                Digit = x.ToString(),
                Even = x % 2 == 0
            });
        }

        public IEnumerable<int> Simple66()
        {
            return Enumerable.Repeat(7, 10);
        }

        #endregion

        #region Displays

        public void DisplayMenu()
        {
            Console.WriteLine("\nGeneration Operators");
            Console.WriteLine();
            Console.WriteLine("1. Simple65\n2. Simple66\n\nEsc. Exit");
        }

        #endregion

        public void RunGenerationsOperations()
        {
            ConsoleKeyInfo cki;

            do
            {
                DisplayMenu();
                cki = Console.ReadKey(false);

                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        Console.WriteLine("\nNumbers from 100 to 150:");
                        Display.Display.DisplayDigitEvens(Simple65());
                        break;
                    case "2":
                        Console.WriteLine("\nRepeat 7:");
                        Display.Display.DisplayInts(Simple66());
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
