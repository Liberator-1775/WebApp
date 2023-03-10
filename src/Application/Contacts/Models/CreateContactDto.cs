using Application.Common.Mappings;
using AutoMapper;
using Domain.Contacts;
using Domain.Interests;

namespace Application.Contacts.Models;

public class CreateContactDto : IMap<Contact>
{
    public string Name { get; set; }

    public Gender Gender { get; set; }

    public DateOnly DateOfBirth { get; set; }

    public PreferredContactMethod PreferredContactMethod { get; set; }

    public List<int> InterestsIds { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<CreateContactDto, Contact>()
            .ForMember(contact => contact.Interests,
                expression => expression.MapFrom(dto => dto.InterestsIds.Select(id => new Interest { Id = id })));
    }
}