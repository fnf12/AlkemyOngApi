using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OngProject.Core.Entities;
using OngProject.Core.Entities.AuthModel;

#nullable disable

namespace OngProject.Infrastructure.Data
{
    public partial class ApplicationDbContext : IdentityDbContext<User, Rol, string>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Activity> Activities { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Slide> Slides { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.SeedRoles(builder);
            this.SeedUsers(builder);
            this.SeedUserRoles(builder);
            this.SeedActivities(builder);
            this.SeedOng(builder);
        }

        private void SeedUsers(ModelBuilder builder)
        {

            for (int i = 10; i < 20; i++)
            {
                User _user = new User()
                {
                    Id = "b74ddd14-6340-4840-95c2-db12554843" + i.ToString(),
                    FirstName = "User " + i.ToString(),
                    LastName = "LastName " + i.ToString(),
                    Email = "mail" + i + "@mail.com",
                    NormalizedEmail = "mail" + i + "@mail.com",
                    UserName = "mail" + i + "@mail.com",
                    LockoutEnabled = false,
                    PhoneNumber = "No Available",
                    Photo = "https://placeimg.com/640/480/any"

                };
                PasswordHasher<User> _passwordHasher = new PasswordHasher<User>();
                _user.PasswordHash = _passwordHasher.HashPassword(_user, "Admin123");
                builder.Entity<User>().HasData(_user);
            }

            for (int i = 30; i < 40; i++)
            {
                User _user = new User()
                {
                    Id = "b74ddd14-6340-4840-95c2-db12554843" + i.ToString(),
                    FirstName = "User " + i.ToString(),
                    LastName = "LastName " + i.ToString(),
                    Email = "mail" + i + "@mail.com",
                    NormalizedEmail = "mail" + i + "@mail.com",
                    UserName = "mail" + i + "@mail.com",
                    LockoutEnabled = false,
                    PhoneNumber = "No Available",
                    Photo = "https://placeimg.com/640/480/any"
                };
                PasswordHasher<User> _passwordHasher = new PasswordHasher<User>();
                _user.PasswordHash = _passwordHasher.HashPassword(_user, "Common123");
                builder.Entity<User>().HasData(_user);
            }
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<Rol>().HasData(
                new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7330", Name = "Admin", ConcurrencyStamp = "3", NormalizedName = "Admin" },
                new IdentityRole() { Id = "c7b013f0-5201-4317-abd8-c211f91b7033", Name = "Common", ConcurrencyStamp = "4", NormalizedName = "Common" }
                );
        }

        private void SeedUserRoles(ModelBuilder builder)
        {
            for (int i = 10; i < 20; i++)
            {
                builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "c7b013f0-5201-4317-abd8-c211f91b7330", UserId = "b74ddd14-6340-4840-95c2-db12554843" + i.ToString() }
                );
            }

            for (int i = 30; i < 40; i++)
            {
                builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "c7b013f0-5201-4317-abd8-c211f91b7033", UserId = "b74ddd14-6340-4840-95c2-db12554843" + i.ToString() }
                );
            }
        }

        private void SeedActivities(ModelBuilder builder)
        {
            for (int i = 1; i < 11; i++)
            {
                builder.Entity<Activity>().HasData(
                    new Activity()
                    {
                        Id = i,
                        Name = "Activity number " + i,
                        Content = "Test number " + i,
                        Image = "https://placeimg.com/640/480/any",
                        IsDeleted = false,
                        CreatedAt = System.DateTime.Now
                    }
                );
            }
        }
        private void SeedOng(ModelBuilder builder)
        {
            builder.Entity<Organization>().HasData(
                new Organization()
                {
                    Id = 1,
                    Name = "ONG",
                    AboutUsText = "About Ong",
                    Address = "Address Ong",
                    Email = "Email Ong",
                    FacebookUrl = "Facebook Url",
                    InstagramUrl = "Instagram Url",
                    LinkedInUrl = "Linedin Url",
                    Phone = "+54112563256",
                    WelcomeText = "Welcome Ong",
                    Image = "https://placeimg.com/640/480/any",
                    IsDeleted = false,
                    CreatedAt = System.DateTime.Now
                }
            );
        }
    }
}
