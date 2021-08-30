﻿using FronttoBack.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FronttoBack.DAL
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext>options):base(options)
        {

        }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Introduction> Introductions { get; set; }
    }
}
