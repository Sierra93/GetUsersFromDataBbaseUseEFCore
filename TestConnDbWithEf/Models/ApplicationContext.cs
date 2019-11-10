using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TestConnDbWithEf.Models {
    public class ApplicationContext : DbContext {
        public DbSet<User> Users { get; set; }
        public ApplicationContext() {
            // Если БД не создана, то создает ее
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Server=SIERRAF4C1;Database=TestDB;Trusted_Connection=True;");
        }
    }
}
