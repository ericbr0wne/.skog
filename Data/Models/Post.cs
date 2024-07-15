using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dotSkog.Data.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime Timestamp { get; set; }

        [ForeignKey("User")]
        public int UserId {  get; set; } //FK UserId
        public User? User { get; set; }

        public List<Comment> Comments { get; set; } = new();
    }
}
