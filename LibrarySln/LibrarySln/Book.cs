using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySln
{
    internal class Book : LibraryItem
    {
        public string Author { get; set; }
        public string Genre { get; set; }

        public Book(string iD, string title, string yearPublished, string author,  string genre): base(iD, title, yearPublished)
        {
            Author = author;
            Genre = genre;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine(" Book Details ");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Year Published: {YearPublished}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Genre: {Genre}");
        }

    }


}
