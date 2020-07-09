using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstCoreWebApp.Models;
// using Microsoft.EntityFrameworkCore.Extensions;   //   :  shows errors

namespace FirstCoreWebApp.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }

    }
}
