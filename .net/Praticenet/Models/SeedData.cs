using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Praticenet.Models
{
    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Trần Văn Phú",
                        Luong = 123 ,
                        Category = "lười làm không có lương đâu lương ít",
                        Image = "https://file.tinnhac.com/resize/600x-/2019/06/30/20190630131610-d3df.jpg"



                    },
                  
                    new Product
                    {
                        Name = "Mai xuân Lập",
                        Luong = 123,
                        Category = "lười làm không có lương đâu lương ít",
                        Image = "https://file.tinnhac.com/resize/600x-/2019/06/30/20190630131610-d3df.jpg"
                    },
                     new Product
                     {
                         Name = "Mai xuân Thu",
                         Luong = 123,
                         Category = "lười làm không có lương đâu lương ít",
                         Image = "https://file.tinnhac.com/resize/600x-/2019/06/30/20190630131610-d3df.jpg"
                     },
                      new Product
                      {
                          Name = "Mai xuân Đông",
                          Luong = 123,
                          Category = "lười làm không có lương đâu lương ít",
                          Image = "https://file.tinnhac.com/resize/600x-/2019/06/30/20190630131610-d3df.jpg"
                      },
                       new Product
                       {
                           Name = "Mai xuân Tây",
                           Luong = 123,
                           Category = "lười làm không có lương đâu lương ít",
                           Image = "https://file.tinnhac.com/resize/600x-/2019/06/30/20190630131610-d3df.jpg"
                       }
                );
                context.SaveChanges();
            }
        }
    }
}
