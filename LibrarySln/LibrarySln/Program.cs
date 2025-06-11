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
            List<LibraryItem> items = new List<LibraryItem>();

            Console.WriteLine("=========== Welcome to the Archives ===========");

            while (true)
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. Add new item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. Search items");
                Console.WriteLine("4. Display all items");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        items.Add(ItemAdder.AddItem());
                        break;
                    case "2":
                        ItemRemover.RemoveItem(items);
                        break;
                    case "3":
                        ItemSearcher.SearchItems(items);
                        break;
                    case "4":
                        DisplayAllItems(items);
                        break;
                    case "5":
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void DisplayAllItems(List<LibraryItem> items)
        {
            Console.WriteLine("\n=========== All Items in Archive ===========");
            if (items.Count == 0)
            {
                Console.WriteLine("No items in the archive yet.");
            }
            else
            {
                foreach (var item in items)
                {
                    item.DisplayDetails();
                    Console.WriteLine("-----------------------------------");
                }
            }
        }




    }
    
}
