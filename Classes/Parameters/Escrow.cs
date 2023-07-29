using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Classes.Parameters
{
    public class Escrow
    {
        public int ID { get; set; }
        public int ReaderID { get; set; }
        public int BookID { get; set; }    
        public string EscrowDate { get; set; }
        public string ReturnDate { get; set; }
        public string NameSurname { get; set; }
    }
}
