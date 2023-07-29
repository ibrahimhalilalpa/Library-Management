using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Classes.Parameters
{
    public class Books
    {

        public int ID { get; set; }
        public int EscrowStatus { get; set; }
        public int State { get; set; }
        public string Barcode { get; set; }
        public string BookName { get; set; }
        public string Author { get; set; }
        public string BookType { get; set; }
        public string SubjectOfBook { get; set; }
        public string PageNumber { get; set; }
        public string LanguageOfBook { get; set; }
        public string PrintingDate { get; set; }
        public string Publisher { get; set; }
        public string AmountOfStock { get; set; }

    }
}
