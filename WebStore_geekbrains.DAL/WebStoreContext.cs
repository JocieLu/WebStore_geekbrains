using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebStore_geekbrains.Domain.Entities.Base;

namespace WebStore_geekbrains.DAL
{
    public class WebStoreContext : DbContext
    {
        public WebStoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}