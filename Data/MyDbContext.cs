using Microsoft.EntityFrameworkCore;
using dotSkog.Data.Models;


namespace dotSkog.Data
{
    public class MyDbContext : DbContext
    {
        // DbSet Properties for your Entities
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }   
    
        //Constructor
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User to Posts Relationship (One-to-Many)
            modelBuilder.Entity<User>()
                .HasMany(u => u.Posts)  // A user has many posts
                .WithOne(p => p.User)   // Each post belongs to one user
                .HasForeignKey(p => p.UserId)  // Specify the foreign key in the Post entity
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes (optional)

            // User to Comments Relationship (One-to-Many)
            modelBuilder.Entity<User>()
                .HasMany(u => u.Comments)  // A user has many comments
                .WithOne(c => c.User)   // Each comment belongs to one user
                .HasForeignKey(c => c.UserId) // Specify the foreign key in the Comment entity
                .OnDelete(DeleteBehavior.Restrict); // Prevent cascading deletes (optional)

            // Post to Comments Relationship (One-to-Many)
            modelBuilder.Entity<Post>()
                .HasMany(p => p.Comments) // A post has many comments
                .WithOne(c => c.Post)  // Each comment belongs to one post
                .HasForeignKey(c => c.PostId)  // Specify the foreign key in the Comment entity
                .OnDelete(DeleteBehavior.Cascade); // Optionally, allow cascading deletes for comments when a post is deleted
        }


    }

}

