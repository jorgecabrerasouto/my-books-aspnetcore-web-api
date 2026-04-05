using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using my_books.Data.Models;
using System;
using System.Linq;

namespace my_books.Data
{
    public class AppDbInitializer
    {
        public static void Seed (IApplicationBuilder applicationBuilder)
        {
            using var serviceScope = applicationBuilder.ApplicationServices.CreateScope();
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.Books.Any())
                {
                    context.Books.AddRange(
                    new Book()
                    {
                        Title = "JAVASCRIPT & JQUERY",
                        Description = "Interactive front-end web development",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-250),
                        Rate = 4,
                        Genre = "Web programming",
                        Author = "Jon Ducket",
                        CoverUrl = "https:...",
                        DateAdded = DateTime.Now

                    },
                    new Book()
                    {
                        Title = "HTML & CSS",
                        Description = "Design and buil websites",
                        IsRead = false,
                        Genre = "Web programming",
                        Author = "Jon Ducket",
                        CoverUrl = "https:...",
                        DateAdded = DateTime.Now

                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
