using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySln
{
    public class ItemAdder
    {
        public static LibraryItem AddItem()
        {
            try
            {
                Console.WriteLine("\n=========== Add New Item ===========");

                Console.Write("Enter ID: ");
                string id = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(id))
                {
                    Console.WriteLine("ID cannot be empty. Please try again.");
                    return null;
                }

                Console.Write("Enter Title: ");
                string title = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(title))
                {
                    Console.WriteLine("Title cannot be empty. Please try again.");
                    return null;
                }


                Console.Write("Enter Year Published: ");
                string yearPublished = Console.ReadLine();

                while (true)
                {
                    Console.WriteLine("\nSelect the type of item: ");
                    Console.WriteLine("1. Book");
                    Console.WriteLine("2. Magazine");
                    Console.WriteLine("3. DVD");

                    Console.Write("Enter your choice (1, 2, or 3): ");
                    string typeChoice = Console.ReadLine();

                    switch (typeChoice)
                    {
                        case "1":
                            Console.Write("Enter Author: ");
                            string author = Console.ReadLine();

                            Console.Write("Enter Genre: ");
                            string genre = Console.ReadLine();

                            var book = new Book(id, title, yearPublished, author, genre);
                            Console.WriteLine("\n=========== Item Added Successfully ===========");
                            book.DisplayDetails();
                            Console.WriteLine("=============================================");
                            return book;

                        case "2":
                            Console.Write("Enter Issue Number: ");
                            string issueNumber = Console.ReadLine();

                            Console.Write("Enter Month: ");
                            string month = Console.ReadLine();

                            var magazine = new Magazine(id, title, yearPublished, issueNumber, month);
                            Console.WriteLine("\n=========== Item Added Successfully ===========");
                            magazine.DisplayDetails();
                            Console.WriteLine("=============================================");
                            return magazine;

                        case "3":
                            Console.Write("Enter Duration: ");
                            string duration = Console.ReadLine();

                            Console.Write("Enter Director: ");
                            string director = Console.ReadLine();

                            var dvd = new DVD(id, title, yearPublished, duration, director);
                            Console.WriteLine("\n=========== Item Added Successfully ===========");
                            dvd.DisplayDetails();
                            Console.WriteLine("=============================================");
                            return dvd;

                        default:
                            Console.WriteLine("Wrong choice. Please try again.");
                            continue;
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }

        }
    }
}

