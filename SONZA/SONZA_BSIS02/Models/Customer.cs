using System.ComponentModel.DataAnnotations;

namespace aspcustomer.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        public string CustomerName { get; set; } = "";

        [Required]
        public string ContactName { get; set; } = "";

        [Required]
        [EmailAddress]
        public string Email { get; set; } = "";

        [Required]
        public string Phone { get; set; } = "";

        [Required]
        public string Address { get; set; } = "";

        [Required]
        public string City { get; set; } = "";

        [Required]
        public string State { get; set; } = "";

        [Required]
        public string ZipCode { get; set; } = "";
    }
}