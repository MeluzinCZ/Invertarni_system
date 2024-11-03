﻿using Microsoft.EntityFrameworkCore;

namespace Inventarni_system.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Budova> Budovy { get; set; }
        public DbSet<Sklad> Sklady { get; set; }
        public DbSet<Predmet> Predmety { get; set; }
    }
}
