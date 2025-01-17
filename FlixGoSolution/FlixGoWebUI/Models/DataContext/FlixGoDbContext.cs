﻿
using FlixGoWebUI.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace FlixGoWebUI.Models.DataContext
{

    public class FlixGoDbContext : DbContext
    {
        public FlixGoDbContext()
            : base()
        {

        }


        public FlixGoDbContext(DbContextOptions options)
            : base(options)
        {

        }
        



        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=FlixGoDb;User Id=sa;Password=query;MultipleActiveResultSets=True");
            }
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ProductImage> Images { get; set; }
        public DbSet<Quality> Qualities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<ReleaseYear> ReleaseYears { get; set; }
        public DbSet<ProductReleaseYear> ProductReleaseYears { get; set; }
        public DbSet<ProductQuality> ProductQualities { get; set; }
        public DbSet<ProductGenre> ProductGenres { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}
