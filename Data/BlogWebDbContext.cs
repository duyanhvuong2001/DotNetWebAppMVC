using DotNetWebAppMVC.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace DotNetWebAppMVC.Data
{
    public class BlogWebDbContext : DbContext
    {
        public BlogWebDbContext(DbContextOptions options) : base(options)
        {
            
        }

        //Tables that EntityFrameworkCore will create
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}
