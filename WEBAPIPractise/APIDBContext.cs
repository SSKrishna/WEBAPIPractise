using Microsoft.EntityFrameworkCore;
using WEBAPIPractise.Models;

namespace WEBAPIPractise
{
    public class APIDBContext:DbContext
    {
        public APIDBContext(DbContextOptions options) : base(options) { }
        public DbSet<Contact> Contacts
        {
            get;
            set;
        }

        public DbSet<Product> Products { get;set; }


        public DbSet<Customer> Customers { get;set; }

        public DbSet<Order> orders { get; set; }
    }
}
