using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int PageCount { get; set; }

        public DateTime CreationDate { get; set; }

        public virtual Genre Genre { get; set; }

        public string Url { get; set; }
    }
}
