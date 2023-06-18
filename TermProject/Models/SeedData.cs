using Microsoft.EntityFrameworkCore;
namespace TermProject.Models
{
    public class SeedData
    {
        public static void SeedDatabase(AppDbContext context)
        {
            context.Database.Migrate();
            if (context.Books.Count() == 0 && context.Categories.Count() == 0)
            {
                List<Category> dummyCategories = new List<Category>() {
                  new Category
                {
                    Title = "Roman"
                },
                 new Category
                {
                    Title = "Şiir"
                },
                 new Category
                {
                    Title = "Makale"
                },
                new Category
                {
                    Title = "Deneme"
                },
            };
                List<Book> dummyBooks = new List<Book>()
                {
                new Book
                {
                   Title = "Kinyas ve Kayra",
                    Author = "Hakan Günday",
                    Description = "Kinyas ve Kayranın hayatı",
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:210061/wh:true/wi:800",
                    PageCount = 123,
                    Price = 12312312,
                    Category = dummyCategories[1],
                },
                new Book
                {
                   Title = "Fareler vs İnsanlar",
                    Author = "Franz Kafka",
                    Description = "fare olmuş adam",
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:210061/wh:true/wi:800",
                    PageCount = 123,
                    Price = 12312312,
                    Category = dummyCategories[1],
                },
                new Book
                {
                    Title = "Aşk",
                    Author = "Elif Şafak",
                    ImageUrl = "https://img.kitapyurdu.com/v1/getImage/fn:210061/wh:true/wi:800",
                    Description = "Mevlana & Şemsi",
                    PageCount = 123,
                    Price = 12312312,
                    Category = dummyCategories[0],
                },
                };
                context.Books.AddRange(dummyBooks);
                context.Categories.AddRange(dummyCategories);
            }
            context.SaveChanges();
        }
    }

}