using DogApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DogApi.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions<ApiDbContext>options) : base(options)
        {

        }

        public DbSet<Dog> Dogs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Dog>(entity => {
                entity.HasIndex(e => e.Name).IsUnique();
            });

            builder.Entity<Dog>().HasData(
                new Dog
                {
                    Id = 1,
                    Name = "Neo",
                    Color = "red & amber",
                    Tail_length = 22,
                    Weight = 32
                },
                 new Dog
                 {
                     Id = 2,
                     Name = "Jessy",
                     Color = "black & white",
                     Tail_length = 7,
                     Weight = 14
                 }
                );
        }
    }
}
