using Microsoft.EntityFrameworkCore;
using SSBlogs.Models;

namespace SSBlogs
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed initial data
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Title = "Introduction to ASP.NET Core",
                    AuthorName = "John Doe",
                    Description = "Learn the basics of ASP.NET Core framework",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishedOn = DateTime.Now.AddDays(-10)
                },
                new Blog
                {
                    Id = 2,
                    Title = "Getting Started with Entity Framework Core",
                    AuthorName = "Jane Smith",
                    Description = "A beginner's guide to Entity Framework Core",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishedOn = DateTime.Now.AddDays(-9)
                },
                new Blog
                {
                    Id = 3,
                    Title = "Building RESTful APIs with ASP.NET Core",
                    AuthorName = "Mike Johnson",
                    Description = "Learn how to create RESTful APIs using ASP.NET Core",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishedOn = DateTime.Now.AddDays(-8)
                },
                new Blog
                {
                    Id = 4,
                    Title = "Introduction to ASP.NET Core",
                    AuthorName = "John Doe",
                    Description = "Learn the basics of ASP.NET Core framework",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishedOn = DateTime.Now.AddDays(-10)
                },
                new Blog
                {
                    Id = 5,
                    Title = "Getting Started with Entity Framework Core",
                    AuthorName = "Jane Smith",
                    Description = "A beginner's guide to Entity Framework Core",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishedOn = DateTime.Now.AddDays(-9)
                },
                new Blog
                {
                    Id = 6,
                    Title = "Building RESTful APIs with ASP.NET Core",
                    AuthorName = "Mike Johnson",
                    Description = "Learn how to create RESTful APIs using ASP.NET Core",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishedOn = DateTime.Now.AddDays(-8)
                },
                new Blog
                {
                    Id = 7,
                    Title = "Introduction to ASP.NET Core",
                    AuthorName = "John Doe",
                    Description = "Learn the basics of ASP.NET Core framework",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishedOn = DateTime.Now.AddDays(-10)
                },
                new Blog
                {
                    Id = 8,
                    Title = "Getting Started with Entity Framework Core",
                    AuthorName = "Jane Smith",
                    Description = "A beginner's guide to Entity Framework Core",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishedOn = DateTime.Now.AddDays(-9)
                },
                new Blog
                {
                    Id = 9,
                    Title = "Building RESTful APIs with ASP.NET Core",
                    AuthorName = "Mike Johnson",
                    Description = "Learn how to create RESTful APIs using ASP.NET Core",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishedOn = DateTime.Now.AddDays(-8)
                },
                new Blog
                {
                    Id = 10,
                    Title = "Introduction to ASP.NET Core",
                    AuthorName = "John Doe",
                    Description = "Learn the basics of ASP.NET Core framework",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishedOn = DateTime.Now.AddDays(-10)
                },
                new Blog
                {
                    Id = 11,
                    Title = "Getting Started with Entity Framework Core",
                    AuthorName = "Jane Smith",
                    Description = "A beginner's guide to Entity Framework Core",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishedOn = DateTime.Now.AddDays(-9)
                },
                new Blog
                {
                    Id = 12,
                    Title = "Building RESTful APIs with ASP.NET Core",
                    AuthorName = "Mike Johnson",
                    Description = "Learn how to create RESTful APIs using ASP.NET Core",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishedOn = DateTime.Now.AddDays(-8)
                },
                new Blog
                {
                    Id = 13,
                    Title = "Building RESTful APIs with ASP.NET Core",
                    AuthorName = "Mike Johnson",
                    Description = "Learn how to create RESTful APIs using ASP.NET Core",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishedOn = DateTime.Now.AddDays(-8)
                },
                new Blog
                {
                    Id = 14,
                    Title = "Introduction to ASP.NET Core",
                    AuthorName = "John Doe",
                    Description = "Learn the basics of ASP.NET Core framework",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishedOn = DateTime.Now.AddDays(-10)
                },
                new Blog
                {
                    Id = 15,
                    Title = "Getting Started with Entity Framework Core",
                    AuthorName = "Jane Smith",
                    Description = "A beginner's guide to Entity Framework Core",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishedOn = DateTime.Now.AddDays(-9)
                }
            );
        }
    }
}