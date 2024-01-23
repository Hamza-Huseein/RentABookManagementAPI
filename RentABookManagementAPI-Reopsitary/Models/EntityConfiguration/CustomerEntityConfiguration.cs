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
    public class CustomerEntityConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.CustomerId);
            builder.Property(x => x.CustomerId).UseIdentityColumn();
            builder.Property(x => x.CustomerName).IsRequired();
            builder.HasIndex(x => x.CustomerName).IsUnique();
            builder.Property(x => x.Email).IsRequired();
            builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x => x.Phone).IsRequired();
            builder.Property(x => x.Phone).HasMaxLength(13);
        }
    }
}
