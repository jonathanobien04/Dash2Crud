using System.ComponentModel.DataAnnotations;

namespace aspversion1.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Phone]
        public string Phone { get; set; } = string.Empty;

        [Required]
        public string Address { get; set; } = string.Empty;

        [Required]
        public string City { get; set; } = string.Empty;

        [Required]
        public string State { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; } = string.Empty;
    }
}