using System;
using msdn_linq_samples.LINQ;

namespace msdn_linq_samples
{
    internal class Program
    {
        public void RunRestrictionOperators()
        {
            var restrictionOperators = new RestrictionOperators();

            ConsoleKeyInfo cki;

            do
            {
                restrictionOperators.DisplayMenu();
                cki = Console.ReadKey(false);
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        restrictionOperators.Simple1();
                        break;
                    case "2":
                        restrictionOperators.Simple2();
                        break;
                    case "3":
                        restrictionOperators.Simple1();
                        break;
                    case "4":
                        restrictionOperators.Simple2();
                        break;
                    case "5":
                        restrictionOperators.Simple1();
                        break;
                    default:
                        Console.WriteLine("No such choice in the list\n");
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Program");
            Console.WriteLine();
            Console.WriteLine("1. Restriction Operators");
            Console.WriteLine("Esc. Exit");
        }

        private static void Main()
        {
            var program = new Program();

            ConsoleKeyInfo cki;

            do
            {
                program.DisplayMenu();
                cki = Console.ReadKey(false);
                switch (cki.KeyChar.ToString())
                {
                    case "1":
                        program.RunRestrictionOperators();
                        break;
                    default:
                        Console.WriteLine("No such choice in the list\n");
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);

        }
    }
}
