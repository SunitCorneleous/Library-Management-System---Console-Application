using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelClassLib.Models
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public bool IsBorrowed { get; set; }
    }
}
