using Application.Common.Interfaces;
using Domain;
using Domain.Contacts;
using Domain.Interests;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Contact> Contacts { get; set; }
    
    public DbSet<Interest> Interests { get; set; }
}