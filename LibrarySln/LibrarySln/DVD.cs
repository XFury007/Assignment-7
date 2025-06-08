using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LibrarySln
{
    internal class DVD : LibraryItem
    {
        public string Duration { get; set; }
        public string Director { get; set; }

        public DVD(string iD, string title, string yearPublished, string director, string duration) : base(iD, title, yearPublished)
        {
            Duration = duration ;
            Director = director ;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine(" DVD Details");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Year Published: {YearPublished}");
            Console.WriteLine($"Duration: {Duration}");
            Console.WriteLine($"Director: {Director}");
        }

    }
}
