using Core.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class DbSeeder
    {
        public static async Task SeedAsync(ApplicationDbContext context,
            ILoggerFactory loggerFactory)
        {
            try
            {
                if (!context.Products.Any())
                {
                    var products = new List<Product>
                    {
                        new Product
                        {
                            Name = "Test Product 1",
                            Description = "Very good test product if this works!",
                            Price = 19.99m
                        },
                        new Product
                        {
                            Name = "Test Product 2",
                            Description = "Another very good test product!",
                            Price = 29.99m
                        },
                        new Product
                        {
                            Name = "Test Product 3",
                            Description = "The 3rd test product and it's rad!",
                            Price = 39.99m
                        }
                    };

                    foreach(var product in products)
                    {
                        context.Products.Add(product);
                    }
                }

                await context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                var logger = loggerFactory.CreateLogger<DbSeeder>();
                logger.LogError(ex, "There was an error seeding the database");
            }
        }
    }
}
