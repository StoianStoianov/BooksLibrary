namespace BooksLibrary.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Genre
    {
        private ICollection<Book> books;

        public Genre()
        {
            this.books = new HashSet<Book>();
        }
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        [Index(IsUnique = true)]
        public string GenreName { get; set; }

        public virtual ICollection<Book> Books
        {
            get { return this.books; }
            set { this.books = value; }
        }
    }
}
