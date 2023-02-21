using Application.Common.Interfaces;
using Application.Common.Models;
using Application.Interests.Interfaces;
using Application.Interests.Models;
using AutoMapper;
using Domain.Interests;

namespace Application.Interests;

public class InterestFacade : IInterestFacade
{
    private readonly IRepository<Interest> _interestRepository;
    private readonly IMapper _mapper;

    public InterestFacade(IRepository<Interest> interestRepository, IMapper mapper)
    {
        _interestRepository = interestRepository;
        _mapper = mapper;
    }

    public async Task<List<InterestDto>> GetAllAsync()
    {
        return _mapper.Map<List<InterestDto>>(await _interestRepository.GetAsync());
    }

    public async Task<InterestDto> CreateAsync(CreateInterestDto input)
    {
        return _mapper.Map<InterestDto>(await _interestRepository.CreateAsync(_mapper.Map<Interest>(input)));
    }

    public async Task<InterestDto> UpdateAsync(UpdateInterestDto input)
    {
        return _mapper.Map<InterestDto>(await _interestRepository.UpdateAsync(_mapper.Map<Interest>(input)));
    }

    public async Task DeleteAsync(EntityDto input)
    {
        await _interestRepository.DeleteAsync(input.Id);
    }
}