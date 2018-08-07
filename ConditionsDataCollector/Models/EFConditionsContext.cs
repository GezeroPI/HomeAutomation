using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConditionsDataCollector.Models
{
    class EFConditionsContext: DbContext
    {
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Alarm> Alarms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Server=.\;Database=HomeReports;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}
