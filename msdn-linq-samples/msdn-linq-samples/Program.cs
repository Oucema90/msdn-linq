using System;
using msdn_linq_samples.LINQ;
using msdn_linq_samples.Utils;

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
                        Console.WriteLine("Numbers < 5:");
                        RestrictionOperatorsUtils.DisplayInts(restrictionOperators.Simple1());
                        break;
                    case "2":
                        Console.WriteLine("Sold out products:");
                        RestrictionOperatorsUtils.DisplayProducts(restrictionOperators.Simple2(), cki.KeyChar.ToString());
                        break;
                    case "3":
                        Console.WriteLine("In-stock products that cost more than 3.00:");
                        RestrictionOperatorsUtils.DisplayProducts(restrictionOperators.Simple3(), cki.KeyChar.ToString());
                        break;
                    case "4":
                        Console.WriteLine("Customers from Washington and their orders:");
                        RestrictionOperatorsUtils.DisplayCustomers(restrictionOperators.Simple4());
                        break;
                    case "5":
                        Console.WriteLine("Short digits:");
                        RestrictionOperatorsUtils.DisplayStrings(restrictionOperators.Simple5());
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
