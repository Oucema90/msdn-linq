using System;
using msdn_linq_samples.LINQ;

namespace msdn_linq_samples
{
    internal class Program
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Program");
            Console.WriteLine();
            Console.WriteLine("1. Restriction Operators");
            Console.WriteLine("2. Projections Operators");
            Console.WriteLine("3. Projections Operators");
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
                        var restrictionOperators = new RestrictionOperators();
                        restrictionOperators.RunRestrictionOperators();
                        break;
                    case "2":
                        var projectionsOperators = new ProjectionsOperators();
                        projectionsOperators.RunProjectionsOperators();
                        break;
                    case "3":
                        var partitioningOperators = new PartitioningOperators();
                        partitioningOperators.RunPartitioningOperators();
                        break;
                    default:
                        Console.WriteLine(cki.Key == ConsoleKey.Escape
                            ? "\nQuitting ..."
                            : "\nNo such choice in the list\n");
                        break;
                }
            } while (cki.Key != ConsoleKey.Escape);
            Console.ReadKey();
        }
    }
}
