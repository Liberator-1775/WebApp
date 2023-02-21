using Application.Common.Mappings;
using Application.Common.Models;
using Domain.Interests;

namespace Application.Interests.Models;

public class InterestDto : EntityDto, IMap<Interest>
{
    public string Name { get; set; }
}