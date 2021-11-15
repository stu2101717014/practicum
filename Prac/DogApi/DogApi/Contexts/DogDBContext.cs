using DogApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DogApi.Contexts
{
    public class DogDBContext : DbContext
    {
        public DbSet<Dog> Dogos { get; set; }

        public DogDBContext(DbContextOptions<DogDBContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
        }
    }
}
