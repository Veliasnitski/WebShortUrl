using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Mapping;

namespace WebApplication1.Data
{
    public class ShortUrlContext : DbContext
    {
        public DbSet<Url> Urls { get; set; }

        public ShortUrlContext(DbContextOptions<ShortUrlContext> dbContextOptions): base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .ApplyConfiguration(new UrlMapping());
        }
    }
}
