using ContactManager.Dtos;
using System.Collections.Generic;

namespace ContactManager.Models
{
    public class ContactViewModel
    {
        public IEnumerable<ContactDto> Contacts { get; set; }
    }
}
