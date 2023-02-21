using Application.Common.Interfaces;
using Domain.Interests;

namespace Infrastructure.Repositories;

public class InterestRepository : Repository<Interest>
{
    public InterestRepository(IApplicationDbContext context) : base(context.Interests, context)
    {
    }
}