﻿using Microsoft.EntityFrameworkCore;
using Pronia.Models;

namespace Pronia.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            


        }

        public DbSet<Slide> Sliders { get; set; }
        public DbSet<Product> Products { get; set; }
       
    }
}
