using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySln
{
    internal class Magazine : LibraryItem

    {
        public string IssueNumber { get; set; }
        public string Month { get; set; }

        public Magazine(string iD, string title, string yearPublished, string issueNumber, string month) : base(iD, title, yearPublished)
        {
            IssueNumber = issueNumber;
            Month = month;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine(" Magazine Details");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Year Published: {YearPublished}");
            Console.WriteLine($"Issue Number: {IssueNumber}");
            Console.WriteLine($"Month: {Month}");
        }

    }
}
