using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WONDERLUST_PROJECT_ADMINs.Models
{
    public partial class DBWONDERLUSTContext : DbContext
    {
        public DBWONDERLUSTContext()
        {
        }

        public DBWONDERLUSTContext(DbContextOptions<DBWONDERLUSTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Blog> Blog { get; set; }
        public virtual DbSet<Bus> Bus { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Enquiry> Enquiry { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<Package> Package { get; set; }
        public virtual DbSet<PackageBooking> PackageBooking { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Travellers> Travellers { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=D;Initial Catalog=DBWONDERLUST;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>(entity =>
            {
                entity.Property(e => e.BlogImage).IsRequired();

                entity.Property(e => e.BlogTitle).IsRequired();

                entity.Property(e => e.Description).IsRequired();
            });

            modelBuilder.Entity<Bus>(entity =>
            {
                entity.Property(e => e.BusName).IsRequired();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Image).IsRequired();
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasIndex(e => e.StateId);

                entity.Property(e => e.CityName).IsRequired();

                entity.HasOne(d => d.State)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Enquiry>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.EmailId).IsRequired();

                entity.Property(e => e.Message).IsRequired();

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Enquiry)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Hotel>(entity =>
            {
                entity.HasIndex(e => e.CityId);

                entity.HasIndex(e => e.CountryId);

                entity.HasIndex(e => e.StateId);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.HotelName).IsRequired();

                entity.Property(e => e.Image).IsRequired();

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Hotel)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Hotel)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Hotel)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Package>(entity =>
            {
                entity.HasIndex(e => e.BusId);

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.CityId);

                entity.HasIndex(e => e.CountryId);

                entity.HasIndex(e => e.HotelId);

                entity.HasIndex(e => e.StateId);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Image).IsRequired();

                entity.Property(e => e.PackageName).IsRequired();

                entity.HasOne(d => d.Bus)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.BusId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Hotel)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.HotelId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Package)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<PackageBooking>(entity =>
            {
                entity.HasIndex(e => e.PackageId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.EmailId).IsRequired();

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.PackageBooking)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PackageBooking)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.PaymetId);

                entity.HasIndex(e => e.PackageBookingId);

                entity.HasIndex(e => e.PackageId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.PackageBooking)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.PackageBookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasIndex(e => e.CountryId);

                entity.Property(e => e.StateName).IsRequired();

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Travellers>(entity =>
            {
                entity.HasIndex(e => e.PackageBookingId);

                entity.HasIndex(e => e.PackageId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.BloodGroup).IsRequired();

                entity.Property(e => e.FullName).IsRequired();

                entity.Property(e => e.Gender).IsRequired();

                entity.Property(e => e.UserId).IsRequired();

                entity.HasOne(d => d.PackageBooking)
                    .WithMany(p => p.Travellers)
                    .HasForeignKey(d => d.PackageBookingId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Package)
                    .WithMany(p => p.Travellers)
                    .HasForeignKey(d => d.PackageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Travellers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.Email).IsRequired();

                entity.Property(e => e.FirstName).IsRequired();

                entity.Property(e => e.LastName).IsRequired();

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.Role).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
