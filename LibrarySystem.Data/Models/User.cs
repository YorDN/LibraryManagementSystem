
using System.ComponentModel.DataAnnotations;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LibrarySystem.Data.Models
{
    /// <summary>
    ///     This is the User model, which represents a user in the LMS
    /// </summary>
    class User : IdentityUser<int>
    {
        
        [Required]
        [Comment("The user's profile picture")]
        // The profile picture is required because every user must have one 
        // If the user doesn't have a profile picture, a default profile picture will be used
        public required string ProfilePicture { get; set; }

        [Required]
        [Comment("When was the user created")]
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [Required]
        [Comment("When did the user last log in")]
        public DateTime LastLogin { get; set; }

        [Comment("A collection of the books taken by the user")]
        public ICollection<Borrow> Borrows { get; set; } = new List<Borrow>();

        [Comment("A collection of the reviews written by the user")]
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
    }
}
