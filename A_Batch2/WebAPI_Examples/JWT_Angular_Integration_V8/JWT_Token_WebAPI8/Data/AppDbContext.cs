﻿using JWT_Token_WebAPI8.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace JWT_Token_WebAPI8.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}