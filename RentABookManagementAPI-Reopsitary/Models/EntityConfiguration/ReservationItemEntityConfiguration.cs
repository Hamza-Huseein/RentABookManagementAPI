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
    public class ReservationItemEntityConfiguration : IEntityTypeConfiguration<ReservationItem>
    {
        public void Configure(EntityTypeBuilder<ReservationItem> builder)
        {
            builder.HasKey(x => new { x.BookId, x.ReservationId });
            builder.Property(x => x.BookId).IsRequired();
            builder.Property(x => x.ReservationId).IsRequired();
            builder.Property(x => x.Price).IsRequired();
        }
    }
}
