
using ETicaratApp.Entities;
using ETicaratApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.DAL.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server= (localdb)\\MSSQLLocalDB; database=EcommerceDb; Integrated Security=True; TrustServerCertificate=True");
        }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<SalesVaultAction> SalesVaultActions { get; set; }
        public DbSet<SellingAction> SellingActions { get; set; }
        public DbSet<WorkTask> WorkTasks { get; set; }





    }
}
