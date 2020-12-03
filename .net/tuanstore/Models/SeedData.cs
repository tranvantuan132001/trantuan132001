using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using tuanstore.Models;

namespace tuanstore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope()
                .ServiceProvider.GetRequiredService<StoreDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "KAYAK",
                        Description = "A boát ăn shit k >?",
                        Category = "water ăn shit",
                        Price = 234
                    },
                    new Product
                    {
                        Name = "KAYAK",
                        Description = "A boát ăn shit k >?",
                        Category = "Phú béo abw ",
                        Price = 234
                    },
                    new Product
                    {
                        Name = "KAYAK",
                        Description = "A boát ăn shit k >?",
                        Category = "hiếu ôn con thằn lằn",
                        Price = 234
                    },
                    new Product
                    {
                        Name = "KAYAK",
                        Description = "A boát ăn shit k >?",
                        Category = "Mai Xuaan Nập",
                        Price = 234
                    },
                    new Product
                    {
                        Name = "KAYAK",
                        Description = "A boát ăn shit k >?",
                        Category = "Hiếu bồn cầu",
                        Price = 234
                    },
                    new Product
                    {
                        Name = "KAYAK",
                        Description = "A boát ăn shit k >?",
                        Category = "hoàng tru miu",
                        Price = 234
                    },
                    new Product
                    {
                        Name = "KAYAK",
                        Description = "A boát ăn shit k >?",
                        Category = "hemmrt",
                        Price = 234
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
