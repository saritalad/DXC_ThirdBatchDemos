﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace WEBAPI_FlightExample.Models
{
    public class AppDbContext:DbContext
    {


        public AppDbContext(DbContextOptions options):base(options)
        {        }
        public DbSet<Flight> flights { get; set; }
    }
}
