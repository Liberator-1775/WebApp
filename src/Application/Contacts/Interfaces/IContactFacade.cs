using Application.Common.Models;
using Application.Contacts.Models;

namespace Application.Contacts.Interfaces;

public interface IContactFacade
{
    Task<List<ContactDto>> GetAllAsync(string? filter);

    Task<ContactDto> CreateAsync(CreateContactDto input);

    Task<ContactDto> UpdateAsync(UpdateContactDto input);

    Task DeleteAsync(EntityDto input);
}