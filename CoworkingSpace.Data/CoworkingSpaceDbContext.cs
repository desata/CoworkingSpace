using CoworkingSpace.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoworkingSpace.Data
{
    public class CoworkingSpaceDbContext : IdentityDbContext<Aperson, IdentityRole<Guid>, Guid>
    {
        public CoworkingSpaceDbContext(DbContextOptions<CoworkingSpaceDbContext> options)
            : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; } = null!;
        public DbSet<Amenity> Amenities { get; set; } = null!;
        public DbSet<Cathegory> Cathegories { get; set; } = null!;
        public DbSet<Space> Spaces { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {           

            builder.Entity<Space>()
                .HasOne(s => s.Cathegory)
                .WithMany(c => c.Spaces)
                .HasForeignKey(s => s.CathegoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Space>()
                .HasOne(s => s.Admin)
                .WithMany(a => a.SpacesToMange)
                .HasForeignKey(s => s.AdminId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Space>()
                .HasOne(s => s.Renter)
                .WithMany(r => r.RentedSpaces)
                .HasForeignKey(s => s.RenterId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);

        }
    }
}