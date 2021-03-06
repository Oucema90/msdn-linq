﻿using System;
using msdn_linq_samples.Display;
using msdn_linq_samples.LINQ;

namespace msdn_linq_samples
{
    internal class Program
    {
        public void DisplayMenu()
        {
            Console.WriteLine("Program");
            EnumsDisplay.DisplayProgramMenu();
            Console.WriteLine("Esc. Exit");
        }

        private static void Main()
        {
            var program = new Program();

            string cki;

            do
            {
                program.DisplayMenu();
                cki = Console.ReadLine();
                switch (cki)
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
                    case "4":
                        var orderingOperators = new OrderingOperators();
                        orderingOperators.RunOrderingOperators();
                        break;
                    case "5":
                        var groupingOperators = new GroupingOperators();
                        groupingOperators.RunGroupingOperators();
                        break;
                    case "6":
                        var setsOperators = new SetsOperators();
                        setsOperators.RunSetsOperators();
                        break;
                    case "7":
                        var conversionsOperators = new ConversionOperators();
                        conversionsOperators.RunConversionsOperators();
                        break;
                    case "8":
                        var elementsOperators = new ElementOperators();
                        elementsOperators.RunElementsOperators();
                        break;
                    case "9":
                        var generationsOperators = new GenerationOperators();
                        generationsOperators.RunGenerationsOperations();
                        break;
                    case "10":
                        var quantifiersOperators = new QuantifierOperators();
                        quantifiersOperators.RunQuantifiersOperators();
                        break;
                    case "11":
                        var aggregatesOperators = new AggregateOperators();
                        aggregatesOperators.RunAggregatesOperators();
                        break;
                    case "12":
                        var miscellaneousOperators = new MiscellaneousOperators();
                        miscellaneousOperators.RunMiscellaneousOperators();
                        break;
                    case "13":
                        var queryExecutionOperators = new QueryExecutionOperators();
                        queryExecutionOperators.RunQueryExecutionsOperators();
                        break;
                    case "14":
                        var joinOperators = new JoinOperators();
                        joinOperators.RunJoinsOperators();
                        break;
                    default:
                        Console.WriteLine(cki == "Esc"
                            ? "\nQuitting ..."
                            : "\nNo such choice in the list\n");
                        break;
                }
            } while (cki != "Esc");
            Console.ReadKey();
        }
    }
}
