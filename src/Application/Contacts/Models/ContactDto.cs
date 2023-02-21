using Application.Common.Mappings;
using Application.Common.Models;
using Application.Interests.Models;
using AutoMapper;
using Domain.Contacts;

namespace Application.Contacts.Models;

public class ContactDto : EntityDto, IMap<Contact>
{
    public string Name { get; set; }

    public string GenderName { get; set; }

    public DateOnly DateOfBirth { get; set; }

    public string PreferredContactMethodName { get; set; }

    public List<InterestDto> Interests { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Contact, ContactDto>()
            .ForMember(dto => dto.GenderName, 
                expression => expression.MapFrom(contact => contact.Gender.ToString()))
            .ForMember(dto => dto.PreferredContactMethodName,
                expression => expression.MapFrom(contact => contact.PreferredContactMethod.ToString()));
    }
}