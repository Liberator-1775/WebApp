using Domain.Contacts;
using Domain.Interests;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Contact> Contacts { get; set; }

    DbSet<Interest> Interests { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = new());
}