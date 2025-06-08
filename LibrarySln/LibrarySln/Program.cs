using System;
using System.IO;
using System.Linq.Expressions;
using System.Reflection;

namespace LibrarySln
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("=========== Welcome to the Archives ===========");
            

            Console.WriteLine();
            Console.Write("Enter ID: ");
            string id = Console.ReadLine();


            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Year Published: ");
            string yearPublished = Console.ReadLine();

            LibraryItem item = null;
            while (true)
            {

            Console.WriteLine("\nSelect the type of item: ");
            Console.WriteLine("1. Book");
            Console.WriteLine("2. Magazine");
            Console.WriteLine("3. DVD");
            
            Console.Write("Enter your choice (1, 2, or 3): ");
            string choice = Console.ReadLine();
        
            
                switch (choice)
                {

                    case "1":
                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();

                        Console.Write("Enter Genre: ");
                        string genre = Console.ReadLine();

                        item = new Book(id, title, yearPublished, author, genre);
                     
                        break;

                    case "2":
                        Console.Write("Enter Issue Number: ");
                        string issueNumber = Console.ReadLine();

                        Console.Write("Enter Month: ");
                        string month = Console.ReadLine();

                        item = new Magazine(id, title, yearPublished, issueNumber, month);
                       
                        break;


                    case "3":
                        Console.Write("Enter Duration: ");
                        string duration = Console.ReadLine();

                        Console.Write("Enter Director: ");
                        string director = Console.ReadLine();

                        item = new DVD(id, title, yearPublished, duration, director);
                  
                        break;

                    default:

                        Console.WriteLine("Wrong choice. Please try again.");
                        continue;
           
                }
                if (item != null)
                {
                    Console.WriteLine("\n=========== Item Details ===========");
                    item.DisplayDetails();
                    Console.WriteLine("===================================");
                }

                break;


            }

            Console.WriteLine("\nPress any key to continue or type 'exit' to quit...");
            if (Console.ReadLine().ToLower() == "exit")
            {
                Console.WriteLine("Exiting the program. Goodbye!");
                return;
            }

           
        }
    }
}
