using Project_NGO_HubConnect.Data;
using System.ComponentModel.DataAnnotations;

namespace Project_NGO_HubConnect.Models
{
    public class Donor
    {
        [Key]
        public int Donor_ID { get; set; }

        [Required(ErrorMessage = "The Name field is required")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        [RegularExpression(@"^[a-zA-Z\s]*$", ErrorMessage = "Name should only contain alphabets.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Date of birth is required")]
        [DataType(DataType.Date)]
        [Display(Name = "Date Of Birth")]
        public DateTime? DateOfBirth { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [StringLength(50, ErrorMessage = "Email cannot exceed 50 characters.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "The Phone field is required")]
        [RegularExpression(@"^[0-9]+$", ErrorMessage = "Phone should only contain numbers")]
        [StringLength(12, MinimumLength = 10, ErrorMessage = "Phone number cannot exceed 12 characters.")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "The Address field is required")]
        [StringLength(150, ErrorMessage = "Address cannot exceed 150 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "The Donor type is required")]
        [StringLength(100, ErrorMessage = "DonorType cannot exceed 100 characters")]
        [Display(Name = "Donor Type")]
        public string DonorType { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$", ErrorMessage = "Invalid password. It must have at least 8 characters, including uppercase, lowercase, digit, and special character.")]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }

}
