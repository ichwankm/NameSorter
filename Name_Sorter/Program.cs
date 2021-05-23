using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Sorter
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            // To loop application when condition is not met
            while (running)
            {
                Console.WriteLine("Insert Command!");

                Console.WriteLine("");

                // Insert Command name-sorter ./unsorted-names-list.txt
                var command = Console.ReadLine();

                bool result = SortingName.ExecuteCommand(command);

                running = result;
            }
        }
    }

    public class SortingName
    {
        // Method to execute program with the correct command
        public static bool ExecuteCommand(string command)
        {
            // Condition to run the program
            if (command == "name-sorter ./unsorted-names-list.txt")
            {
                // Read file from directory file to sort by lastname
                string[] input = File.ReadAllLines(@"../../File/unsorted-names-list.txt");

                // Query LINQ to orderby lastname
                input = (from line in input
                         orderby OrderbyLastName(line) ascending
                         select line).ToArray();
                
                // Loop for show list to screen
                foreach (var i in input)
                {
                    Console.WriteLine(i);
                }

                // Write new file with the correct sort list
                File.WriteAllLines(@"../../File/sorted-names-list.txt", input);

                Console.WriteLine("");
                
                Console.WriteLine("Press Enter to exit application!");

                return false;
            }
            else
            {
                // If the command is wrong
                Console.WriteLine("");

                Console.WriteLine("Wrong Command!");

                Console.WriteLine("");

                Console.WriteLine("Please enter the correct command!");

                Console.WriteLine("");

                return true;
            }
        }

        // Method to get lastname from list
        public static string OrderbyLastName(string line)
        {
            string lastname = line.Split(' ').Last();

            return lastname;
        }
    }
}
