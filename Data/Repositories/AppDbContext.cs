using ContactManager.Domain.Entities;
using System.Collections.Generic;

namespace ContactManager.Data.Repositories
{
    /// <summary>
    /// My originial idea was using a context, but I`ve discaterd because of time
    /// </summary>
    internal class AppDbContext
    {
        public List<Contact> _contacts { get; set; }
        public List<Contact> Contacts
        {
            get
            {
                return _contacts;
            }

        }
    }
}