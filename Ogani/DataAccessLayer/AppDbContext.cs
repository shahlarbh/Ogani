﻿using Microsoft.EntityFrameworkCore;
using Ogani.DataAccessLayer.Entities;

namespace Ogani.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
                
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Filter> Filters { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<HomeTopBanner> HomeTopBanners { get; set; }
    }
}
