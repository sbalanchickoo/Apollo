﻿using System;
using Apollo.EFCore.EF.Models;
using Apollo.EFCore.Module5.UI;

namespace Apollo.EFCore.Module5.Bootstrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantContext ctx = new RestaurantContext();
            //ctx.ConnectionString = @"Server = (localdb)\MSSQLLocalDB; Database = RestaurantReviews; Trusted_Connection = True; ";
            //ctx.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());
            RestaurantReviewsRepository repo = new RestaurantReviewsRepository();
            //repo.Context = ctx;

            Viewer vw = new Viewer();
            vw.RestaurantReviews = repo;
            vw.StartApp();

            Console.ReadLine();
        }
    }
}
