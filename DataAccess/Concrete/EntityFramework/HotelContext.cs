using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataAccess.Concrete.EntityFramework
{
    public class HotelContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Types> RoomTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Res_Services> Res_Services { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server = GULSHAN\SQLEXPRESS; Database = HotelDb; Trusted_connection = True; TrustServerCertificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminMap());
            modelBuilder.ApplyConfiguration(new ContactMap());
            modelBuilder.ApplyConfiguration(new ResServicesMap());
            modelBuilder.ApplyConfiguration(new ReservationMap());
            modelBuilder.ApplyConfiguration(new ServiceMap());
            modelBuilder.ApplyConfiguration(new RoomMap());
            modelBuilder.ApplyConfiguration(new TypesMap());
            modelBuilder.ApplyConfiguration(new UserMap());
        }

    }

    class AdminMap : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admins");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).HasColumnName("Id");
            builder.Property(a => a.Name).HasColumnName("name");
            builder.Property(a => a.Username).HasColumnName("username");
            builder.Property(a => a.Password).HasColumnName("password");
        }
    }

    class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contacts");
            builder.HasKey(c => c.Id);

            builder.Property(c=>c.Id).HasColumnName("Id");
            builder.Property(c => c.Heading).HasColumnName("heading");
            builder.Property(c => c.Content).HasColumnName("content");
            builder.Property(c => c.dataPosted).HasColumnName("data_posted");
            builder.Property(c => c.UserId).HasColumnName("users_id");
        }
    }

    class ResServicesMap : IEntityTypeConfiguration<Res_Services>
    {
        public void Configure(EntityTypeBuilder<Res_Services> builder)
        {
            builder.ToTable("Res_Services");
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Id).HasColumnName("Id");
            builder.Property(r => r.Res_Id).HasColumnName("res_id");
            builder.Property(r => r.Ser_Id).HasColumnName("services_id");
            builder.Property(r => r.Quantity).HasColumnName("quantity");
        }
    }

    class ReservationMap : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable("Reservations");
            builder.HasKey(r => r.Id);

            builder.Property(r=>r.Id).HasColumnName("Id");
            builder.Property(r => r.UserId).HasColumnName("users_id");
            builder.Property(r => r.RoomId).HasColumnName("rooms_id");
            builder.Property(r => r.checkIn).HasColumnName("checkin");
            builder.Property(r => r.res_Date).HasColumnName("res_date");
            builder.Property(r => r.totalCost).HasColumnName("totalcost");
            builder.Property(r => r.dayCount).HasColumnName("dayCount");
        }
    }

    class RoomMap : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.ToTable("Rooms");
            builder.HasKey(r => r.Id);

            builder.Property(r=>r.Id).HasColumnName("Id");
            builder.Property(r => r.TypeId).HasColumnName("type_id");
            builder.Property(r => r.Name).HasColumnName("name");
            builder.Property(r => r.Price).HasColumnName("price");
            builder.Property(r => r.Rate).HasColumnName("rate");
            builder.Property(r => r.MaxOccupants).HasColumnName("maxoccupants");
            builder.Property(r => r.Area).HasColumnName("Area");
        }
    }

    class ServiceMap : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder.ToTable("Services");
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id).HasColumnName("Id");
            builder.Property(s => s.Name).HasColumnName("name");
            builder.Property(s => s.Price).HasColumnName("price");
        }
    }

    class TypesMap : IEntityTypeConfiguration<Types>
    {
        public void Configure(EntityTypeBuilder<Types> builder)
        {
            builder.ToTable("RoomTypes");
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Id).HasColumnName("Id"); 
            builder.Property(t => t.Name).HasColumnName("name");
        }
    }

    class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).HasColumnName("Id");
            builder.Property(u => u.FirstName).HasColumnName("FirstName");
            builder.Property(u => u.LastName).HasColumnName("LastName");
            builder.Property(u => u.Age).HasColumnName("Age");
            builder.Property(u => u.Phone).HasColumnName("phone_number");
            builder.Property(u => u.Email).HasColumnName("mail");
            builder.Property(u => u.Address).HasColumnName("address");
            builder.Property(u => u.Username).HasColumnName("username");
            builder.Property(u => u.Password).HasColumnName("passcode");
        }
    }
}
