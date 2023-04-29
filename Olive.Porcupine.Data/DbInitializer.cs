using Olive.Porcupine.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Olive.Porcupine.Data
{


    public static class DbInitializer
    {

        public static void Initialize(ModelBuilder builder)
        {
            builder.Entity<Item>().HasData(
                new Item("Shirt", "Ohio State Shirt.", "Nike", 29.99M)
                {
                    Id = 1
                },
                new Item("Shorts", "Ohio State Shorts.", "Nike", 44.99m)
                {
                    Id = 2
                }
            );
        }
    }
}