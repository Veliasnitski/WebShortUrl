using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApplication1.Data.Mapping
{
    public class UrlMapping : IEntityTypeConfiguration<Url>
    {
        public void Configure(EntityTypeBuilder<Url> builder)
        {
            builder.ToTable("Urls");

            builder.HasKey(e => e.IdShortUrl);

            builder.Property(e => e.IdShortUrl).HasColumnName("IdShortUrl");
            builder.Property(e => e.FullUrl).HasColumnName("FullUrl");
            builder.Property(e => e.DateCreate).HasColumnName("DateCreate");
            builder.Property(e => e.Count).HasColumnName("Count");
        }
    }
}
