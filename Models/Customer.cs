﻿using Microsoft.EntityFrameworkCore;

namespace AccountManagement.Models
{
    public class Customer
    {
        public int Id { get; set; }

        public string? FullName { get; set; }

        public string? Email { get; set; }
        
        public string? Phone { get; set; }

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
