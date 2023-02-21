using Application.Common.Models;
using Application.Interests.Models;

namespace Application.Interests.Interfaces;

public interface IInterestFacade
{
    Task<List<InterestDto>> GetAllAsync();

    Task<InterestDto> CreateAsync(CreateInterestDto input);

    Task<InterestDto> UpdateAsync(UpdateInterestDto input);

    Task DeleteAsync(EntityDto input);
}