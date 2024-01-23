using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentABookManagementAPI_Reopsitary.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABookManagementAPI_Reopsitary.Models.EntityConfiguration
{
    public class BookEntityConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(x => x.BookId);
            builder.Property(x => x.BookId).UseIdentityColumn();
            builder.Property(x => x.BookName).IsRequired();
            builder.HasIndex(x => x.BookName).IsUnique();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Author).IsRequired();
        }
    }
}
