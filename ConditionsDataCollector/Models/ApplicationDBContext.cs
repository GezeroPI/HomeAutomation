using MySql.Data.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionsDataCollector.Models
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Alarm> Alarms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Server=.\;Database=HomeReports;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        
    }
}
