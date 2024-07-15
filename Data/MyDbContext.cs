using Microsoft.EntityFrameworkCore;


namespace dotSkog.Data
{
    public class MyDbContext : DbContext
    {
        // DbSet Properties for your Entities
        // public DbSet<User> Users { get; set; }
       // public DbSet<Post> Posts { get; set; }
       // public DbSet<Comment> Comments { get; set; }   
    
        //Constructor
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        // OnModelCreating Method (optional)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure entity relationships and constraints here
        }

    }
}
