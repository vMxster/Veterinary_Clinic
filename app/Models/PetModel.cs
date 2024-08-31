using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Veterinary_Clinic.Models
{
    public class PetModel
    {
        [DisplayName("Pet Id")]
        [Required(ErrorMessage = "Pet Id is required")]
        public int Id { get; set; }

        [DisplayName("Pet Name")]
        [Required(ErrorMessage = "Pet name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("Pet Type")]
        [Required(ErrorMessage = "Pet Type is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet Type must be between 3 and 50 characters")]
        public string Type { get; set; }

        [DisplayName("Pet Colour")]
        [Required(ErrorMessage = "Pet Colour is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pet Colour must be between 3 and 50 characters")]
        public string Colour { get; set; }
    }
}
