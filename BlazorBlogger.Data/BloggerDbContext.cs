using BlazorBlogger.Common.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorBlogger.DB
{
    public class BloggerDbContext : DbContext, IBloggerDbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }

        void IBloggerDbContext.SaveChanges()
        {
            this.SaveChanges();
        }
    }
}
