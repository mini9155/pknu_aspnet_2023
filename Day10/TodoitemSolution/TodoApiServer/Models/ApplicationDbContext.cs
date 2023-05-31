﻿using Microsoft.EntityFrameworkCore;

namespace TodoApiServer.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) :  base(options) 
        { 
        }

        public DbSet<Todoitem> TodoItems { get; set; }
    }
}
