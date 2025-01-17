using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Test1.Configurations.Entities;
using Test1.Data;

namespace Test1.Data
{
    public class Test1Context(DbContextOptions<Test1Context> options) :
        IdentityDbContext<Test1User>(options)

    {
        public DbSet<Test1.Domain.Make> Make { get; set; } = default!;
        public DbSet<Test1.Domain.Model> Model { get; set; } = default!;
        public DbSet<Test1.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<Test1.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<Test1.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<Test1.Domain.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());

        }
    }
}
