// This file links the db server to the data model classes in an asp.NEt app. it has to be present in the data folder for dynamic pages

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using QuoteApp.Models;

namespace QuoteApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<QuoteApp.Models.Quote>? Quote { get; set; }
    }
}