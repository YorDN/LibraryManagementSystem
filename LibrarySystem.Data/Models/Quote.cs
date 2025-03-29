
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data.Models
{
    /// <summary>
    ///     This is the quote model, which is used for the quotes on the books page
    /// </summary>
    public class Quote
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Comment("The text of the quote")]
        public required string QuoteText { get; set; }

        [Required]
        [Comment("The name of the author, that said the quote")]
        public required string AuthorName { get; set; }
    }
}
