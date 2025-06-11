using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySln
{
    public class ItemSearcher
    {
        public static void SearchItems(List<LibraryItem> items)
        {
            Console.WriteLine("\n=========== Search Items ===========");
            Console.WriteLine("Search by:");
            Console.WriteLine("1. ID");
            Console.WriteLine("2. Title");
            Console.WriteLine("3. Year Published");
            Console.WriteLine("4. Type (Book/Magazine/DVD)");

            Console.Write("Enter your search choice: ");
            string searchChoice = Console.ReadLine();

            List<LibraryItem> results = new List<LibraryItem>();

            switch (searchChoice)
            {
                case "1":
                    Console.Write("Enter ID to search: ");
                    string searchId = Console.ReadLine();
                    results = items.Where(item => item.ID.Contains(searchId)).ToList();
                    break;

                case "2":
                    Console.Write("Enter title to search: ");
                    string searchTitle = Console.ReadLine();
                    results = items.Where(item => item.Title.Contains(searchTitle, StringComparison.OrdinalIgnoreCase)).ToList();
                    break;

                case "3":
                    Console.Write("Enter year published to search: ");
                    string searchYear = Console.ReadLine();
                    results = items.Where(item => item.YearPublished.Contains(searchYear)).ToList();
                    break;

                case "4":
                    Console.Write("Enter type (Book/Magazine/DVD): ");
                    string searchType = Console.ReadLine().ToLower();
                    results = items.Where(item =>
                        (searchType == "book" && item is Book) ||
                        (searchType == "magazine" && item is Magazine) ||
                        (searchType == "dvd" && item is DVD)).ToList();
                    break;

                default:
                    Console.WriteLine("Invalid search option.");
                    return;
            }

            Console.WriteLine("\n=========== Search Results ===========");
            if (results.Count == 0)
            {
                Console.WriteLine("No items found matching your criteria.");
            }
            else
            {
                foreach (var item in results)
                {
                    item.DisplayDetails();
                    Console.WriteLine("-----------------------------------");
                }
            }
        }
    }


}

