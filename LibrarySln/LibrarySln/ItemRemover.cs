using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySln
{
    public class ItemRemover
    {
        public static void RemoveItem(List<LibraryItem> items)
        {
            Console.WriteLine("\n=========== Remove Item ===========");
            Console.Write("Enter ID of item to remove: ");
            string idToRemove = Console.ReadLine();

            var itemToRemove = items.FirstOrDefault(item => item.ID == idToRemove);

            if (itemToRemove != null)
            {
                Console.WriteLine("\nFound the following item:");
                itemToRemove.DisplayDetails();

                Console.Write("\nAre you sure you want to remove this item? (y/n): ");
                string confirm = Console.ReadLine().ToLower();

                if (confirm == "y")
                {
                    items.Remove(itemToRemove);
                    Console.WriteLine("Item removed successfully.");
                }
                else
                {
                    Console.WriteLine("Item not removed.");
                }
            }
            else
            {
                Console.WriteLine("Item with ID " + idToRemove + " not found.");
            }

        }
    }
}       
