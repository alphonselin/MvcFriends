using System;
using System.ComponentModel.DataAnnotations;

namespace MvcFriends.Models
{
    public class Friend
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Email { get; set; }
        public string Mobile { get; set; }
    }
}