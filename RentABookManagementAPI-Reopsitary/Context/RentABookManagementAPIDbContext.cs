using Microsoft.EntityFrameworkCore;
using RentABookManagementAPI_Reopsitary.Models.Entity;
using RentABookManagementAPI_Reopsitary.Models.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentABookManagementAPI_Reopsitary.Context
{
    public class RentABookManagementAPIDbContext : DbContext
    {
        public RentABookManagementAPIDbContext(DbContextOptions<RentABookManagementAPIDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new BookEntityConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeEntityConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ReservationItemEntityConfiguration());
        }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Reservation> Reservations  { get; set; }
        public virtual DbSet<ReservationItem> ReservationItems { get; set; }

    }
}
