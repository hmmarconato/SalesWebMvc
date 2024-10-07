﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options) : DbContext(options)
    {
        public DbSet<SalesWebMvc.Models.Department> Department { get; set; } = default!;
    }
}