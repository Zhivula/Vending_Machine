using System.Data.Entity;

namespace VendingMachine.DataBase
{
    class MyDbContext : DbContext
    {
        public MyDbContext() : base("DbConnectionString")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
