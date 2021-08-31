﻿using FlixGoWebUI.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace FlixGoWebUI.Models.DataContext
{

    public class FlixGoDbContext : DbContext
    {
        public FlixGoDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}
