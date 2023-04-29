using Olive.Porcupine.Domain.Catalog;
using Olive.Porcupine.Domain.Orders;
using Microsoft.EntityFrameworkCore;

namespace Olive.Porcupine.Data

{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) 
            : base(options)
            { }

            public DbSet<Item> Items {get; set;} =null!;
            public DbSet<Order> Orders {get;set;} =null!;

            protected override void OnModelCreating(ModelBuilder builder)
            {
                base.OnModelCreating(builder);
                DbInitializer.Initialize(builder);
            }
    }
}

