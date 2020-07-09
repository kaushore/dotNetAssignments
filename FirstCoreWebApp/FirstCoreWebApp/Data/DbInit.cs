using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstCoreWebApp.Models;

namespace FirstCoreWebApp.Data
{
    public static class DbInit
    {
        // this function creates and polulates the database
        public static void InitializeWithFakeData(AppDBContext context)
        {
            context.Database.EnsureCreated(); // ensures that a database exists. if doesn't, it will be created.

            if(!context.Products.Any())
            {
                context.Products.Add(new Product(){Pname = "Example Product_1", Price = 100, Stock = 10 });
                context.Products.Add(new Product() { Pname = "Example Product_2", Price = 150, Stock = 30 });
            }

        }
    }
}
