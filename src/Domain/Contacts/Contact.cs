using Domain.Common;
using Domain.Interests;

namespace Domain.Contacts;

public class Contact : Entity
{
    public string Name { get; set; }

    public Gender Gender { get; set; }

    public DateOnly DateOfBirth { get; set; }

    public PreferredContactMethod PreferredContactMethod { get; set; }

    public ICollection<Interest> Interests { get; set; }
}