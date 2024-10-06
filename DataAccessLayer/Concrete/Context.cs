using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-08VSUMT; initial Catalog = TraversalDb; integrated Security =true; TrustServerCertificate=True; ");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<FAQS> Faqs { get; set; }
        public DbSet<Hotels> Hotels { get; set; }
        public DbSet<ContactUs> ContactUses { get; set; }
        public DbSet<Newsleter> Newsleters { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Restuarant> Resturants { get; set; }
        public DbSet<SubAbout> SubAbouts { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Guide> Guides { get; set; }
        public DbSet<Announcement> Announcements { get; set; }

    }
}
