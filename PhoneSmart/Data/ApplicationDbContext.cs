using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhoneSmart.Models;
using System.Threading.Tasks;

namespace PhoneSmart.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<PhoneModel> PhoneModel { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public Task ComparePhoneModelOne { get; internal set; }
    }
}
