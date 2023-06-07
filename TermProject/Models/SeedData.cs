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
                }
            };
                List<Book> dummyBooks = new List<Book>()
                {
                new Book
                {
                   Title = "Ezel",
                    Author = "Oscar Wilde",
                    Description = "bla bla",
                    PageCount = 123,
                    Price = 12312312,
                    Category = dummyCategories[1],
                },
                new Book
                {
                   Title = "Ezel",
                    Author = "Oscar Wilde",
                    Description = "bla bla",
                    PageCount = 123,
                    Price = 12312312,
                    Category = dummyCategories[1],
                },
                new Book
                {
                    Title = "Ezel",
                    Author = "Oscar Wilde",
                    Description = "bla bla",
                    PageCount = 123,
                    Price = 12312312,
                    Category = dummyCategories[1],
                },};
                context.Books.AddRange(dummyBooks);
                context.Categories.AddRange(dummyCategories);
            }
            context.SaveChanges();
        }
    }

}