using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotSkog.Data.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }

        [ForeignKey("Users")]
        public int UserId { get; set; } // Foreign key for the User who created the comment
        public User? User { get; set; } // Navigation property to the User

        [ForeignKey("Posts")]
        public int PostId { get; set; } // Foreign key for the Post the comment is on
        public Post? Post { get; set; } // Navigation property to the Post
    }
}
