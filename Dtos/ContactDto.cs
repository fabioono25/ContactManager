using System;

namespace ContactManager.Dtos
{
    /// <summary>
    /// everything is exposed as Contact
    /// </summary>
    public class ContactDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public bool IsCustomer { get; set; } //the idea here is to add a flag do indicate if it`s supplier os customer
    }
}
