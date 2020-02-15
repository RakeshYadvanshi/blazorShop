using BlazorShop.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop.DB
{
    public interface IBloggerDbContext
    {
        DbSet<Author> Authors { get; set; }
        DbSet<Post> Posts { get; set; }

        void SaveChanges();
    }
}