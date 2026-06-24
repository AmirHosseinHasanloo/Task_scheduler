using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task_scheduler.Entities;

namespace Task_scheduler.Context
{
    public class DataBaseContext : DbContext
    {
        public DbSet<TaskEntity> Task { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }
    }
}