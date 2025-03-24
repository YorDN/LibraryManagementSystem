
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data.Models
{
    class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        [Comment("The title of the book")]
        public required string Title { get; set; }

        [MaxLength(20)]
        [Comment("The ISBN of the book")]
        // The ISBN is optional because not all books have one (e.g. some older books or audio books)
        public required string ISBN { get; set; }

        [Comment("The release date of the book")]
        public DateOnly ReleaseDate { get; set; }
            
        [MaxLength(50)]
        [Comment("The edition of the book")]
        // The edition is a string because it can be a number or a word (e.g. "First") and
        // also it can be special editions like "Special Edition" or "Anniversary Edition"
        public string? Edition { get; set; }

        [MaxLength(100)]
        [Comment("The language of the book")]
        public string? Language { get; set; }

        [MaxLength(100)]
        [Comment("The genre of the book")]
        public string? Genre { get; set; }

        // Limitating the types of books to only 3 types: Physical, Digital and Audio
        public enum BookType
        {
            Physical,
            Digital,
            Audio
        }

        [Required]
        [Comment("What type is the book")]
        // The Type is required because every book must have a type
        // The default value is Physical because most books are physical
        public BookType Type { get; set; } = BookType.Physical;

        [Comment("The duration of the book")]
        public TimeSpan? Duration { get; set; }

        [MaxLength(1000)]
        [Comment("A short description of the book")]
        public string? Description { get; set; }

        [Required]
        [Comment("The cover of the book")]
        // The cover is required because every book must have a cover
        // If a book does not have a cover, a default cover will be used
        public required string Cover { get; set; }

        [Comment("The URL of the audio/digital book")]
        // This FileURL is optional because only digital and audio books have a file with a URL
        public string? FileURL { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; } = null!;

        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; } = null!;

        public ICollection<Borrow> Borrows { get; set; } = new List<Borrow>();
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
