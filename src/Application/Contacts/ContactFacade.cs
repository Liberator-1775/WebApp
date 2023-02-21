using Application.Common.Interfaces;
using Application.Common.Models;
using Application.Contacts.Interfaces;
using Application.Contacts.Models;
using AutoMapper;
using Domain.Contacts;
using Microsoft.EntityFrameworkCore;

namespace Application.Contacts;

public class ContactFacade : IContactFacade
{
    private readonly IRepository<Contact> _contactRepository;
    private readonly IMapper _mapper;

    public ContactFacade(IRepository<Contact> contactRepository, IMapper mapper)
    {
        _contactRepository = contactRepository;
        _mapper = mapper;
    }

    public async Task<List<ContactDto>> GetAllAsync(string? filter)
    {
        return _mapper.Map<List<ContactDto>>((await _contactRepository.GetAsync())
            .Include(contact => contact.Interests)
            .Where(contact => string.IsNullOrWhiteSpace(filter) || contact.Name.ToLower().Contains(filter.ToLower())));
    }

    public async Task<ContactDto> CreateAsync(CreateContactDto input)
    {
        return _mapper.Map<ContactDto>(await _contactRepository.CreateAsync(_mapper.Map<Contact>(input)));
    }

    public async Task<ContactDto> UpdateAsync(UpdateContactDto input)
    {
        return _mapper.Map<ContactDto>(await _contactRepository.UpdateAsync(_mapper.Map<Contact>(input)));
    }

    public async Task DeleteAsync(EntityDto input)
    {
        await _contactRepository.DeleteAsync(input.Id);
    }
}