using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySln
{
    public abstract class LibraryItem
    {
        
        public string  ID { get; set; }
        public string Title { get; set; }
        public string YearPublished { get; set; }

       public LibraryItem (string iD, string title, string yearPublished)
        {
            ID = iD;
            Title = title;
            YearPublished = yearPublished;  
        }

        public abstract void DisplayDetails();



    }


}
