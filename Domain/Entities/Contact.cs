using System;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Domain.Entities
{
    /// <summary>
    /// My idea here is to use contact as an Aggregate root, and add the logic for mandatory fields to other entities (Customer and Supplier)
    /// </summary>
    public class Contact : IAggregateRoot
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the name")]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string Name { get; set; }

        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
    }
}
