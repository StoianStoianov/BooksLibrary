namespace BooksLibrary.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Book
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        [Index(IsUnique = true)]
        public string Title { get; set; }
        [Required]
        [Range(1,10000)]
        public int PageCount { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        [Required]
        public virtual Genre Genre { get; set; }
        [Required]
        public string Url { get; set; }
    }
}
