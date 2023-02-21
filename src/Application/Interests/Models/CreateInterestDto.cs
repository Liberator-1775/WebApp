using Application.Common.Mappings;
using Domain.Interests;

namespace Application.Interests.Models;

public class CreateInterestDto : IMap<Interest>
{
    public string Name { get; set; }
}