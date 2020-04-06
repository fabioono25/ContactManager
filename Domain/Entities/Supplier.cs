using System.ComponentModel.DataAnnotations;

namespace ContactManager.Domain.Entities
{
    public class Supplier : Contact
    {
        [Required(ErrorMessage = "Please enter the phone number")]
        [Display(Name = "Zip code")]
        [StringLength(12, MinimumLength = 7)]
        public string PhoneNumber { get; set; }
    }
}
