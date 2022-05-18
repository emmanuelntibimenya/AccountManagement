using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        public string? FullName { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [Phone]
        public string? Phone { get; set; }
        [Required]
        public string? Address { get; set; }
        public Customer()
        {
            
        }

        public static implicit operator DbSet<object>(Customer v)
        {
            throw new NotImplementedException();
        }
    }
}
