using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WEBAPICRUD.Models;

using Microsoft.EntityFrameworkCore;
    public class AppDbContext : DbContext
    {   
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
