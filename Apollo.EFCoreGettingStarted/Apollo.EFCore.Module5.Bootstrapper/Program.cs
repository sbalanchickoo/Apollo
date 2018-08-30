using Apollo.EFCore.Shared.EF;
using System;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Apollo.EFCore.Module5.UI;

namespace Apollo.EFCore.Module5.Bootstrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            RestaurantContext ctx = new RestaurantContext();
            ctx.ConnectionString = @"Server = (localdb)\MSSQLLocalDB; Database = RestaurantReviews; Trusted_Connection = True; ";
            ctx.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());

            Viewer vw = new Viewer();
            vw.RestaurantReviews = ;
            vw.DisplayRestaurants();

            Console.ReadLine();
        }
    }
}
