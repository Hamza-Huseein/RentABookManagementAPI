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
    public class EmployeeEntityConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.EmployeeId);
            builder.Property(x => x.EmployeeId).UseIdentityColumn();
            builder.Property(x => x.EmployeeName).IsRequired();
            builder.HasIndex(x => x.EmployeeName).IsUnique();
            builder.Property(x => x.Position).IsRequired();

        }
    }
}
