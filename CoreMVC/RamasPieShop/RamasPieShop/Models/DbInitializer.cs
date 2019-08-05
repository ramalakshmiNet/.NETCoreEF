using System.Linq;

namespace RamasPieShop.Models
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Pies.Any())
            {
                context.AddRange
                    (
                     new Pie {  Name = "Apple Pie", Price = 12.95M, ShortDescription = "Our famous apple pies!", LongDescription = "Our famous apple pies!", ImageThumbnailUrl = "/images/1.png", ImageUrl = "https://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png" },
                  new Pie {  Name = "Blue Cheese Cake", Price = 12.95M, ShortDescription = "Our famous apple pies!", LongDescription = "Our famous apple pies!", ImageThumbnailUrl = "/images/2.png", ImageUrl = "https://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png" },
                    new Pie {  Name = "Cheese Cake", Price = 12.95M, ShortDescription = "Our famous apple pies!", LongDescription = "Our famous apple pies!", ImageThumbnailUrl = "/images/3.png", ImageUrl = "https://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png" },
                      new Pie {  Name = "Cherry Pie", Price = 12.95M, ShortDescription = "Our famous apple pies!", LongDescription = "Our famous apple pies!", ImageThumbnailUrl = "/images/4.png", ImageUrl = "https://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png" },
                       new Pie { Name = "Christmas Pie", Price = 12.95M, ShortDescription = "Our famous apple pies!", LongDescription = "Our famous apple pies!", ImageThumbnailUrl = "/images/1.png", ImageUrl = "https://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png" },
                  new Pie { Name = "Chocolate Cake", Price = 12.95M, ShortDescription = "Our famous apple pies!", LongDescription = "Our famous apple pies!", ImageThumbnailUrl = "/images/2.png", ImageUrl = "https://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png" },
                    new Pie { Name = "Cranberry Pie", Price = 12.95M, ShortDescription = "Our famous apple pies!", LongDescription = "Our famous apple pies!", ImageThumbnailUrl = "/images/3.png", ImageUrl = "https://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png" },
                      new Pie { Name = "Peach Pie", Price = 12.95M, ShortDescription = "Our famous apple pies!", LongDescription = "Our famous apple pies!", ImageThumbnailUrl = "/images/4.png", ImageUrl = "https://openclipart.org/image/300px/svg_to_png/27070/egore911_saw.png" }


                      );
                context.SaveChanges();
            }
        }
    }
}
