using Application.Common.Interfaces;
using Domain.Contacts;

namespace Infrastructure.Repositories;

public class ContactRepository : Repository<Contact>
{
    private readonly IApplicationDbContext _context;

    public ContactRepository(IApplicationDbContext context) : base(context.Contacts, context)
    {
        _context = context;
    }

    public override async Task<Contact> CreateAsync(Contact entity)
    {
        _context.Interests.AttachRange(entity.Interests);
        return await base.CreateAsync(entity);
    }

    public override async Task<Contact> UpdateAsync(Contact entity)
    {
        _context.Interests.AttachRange(entity.Interests);
        return await base.UpdateAsync(entity);
    }
}