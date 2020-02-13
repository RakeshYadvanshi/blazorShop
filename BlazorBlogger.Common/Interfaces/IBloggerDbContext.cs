using BlazorBlogger.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorBlogger.DB
{
    public interface IBloggerDbContext
    {
        DbSet<Author> Authors { get; set; }
        DbSet<Post> Posts { get; set; }

        void SaveChanges();
    }
}