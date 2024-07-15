﻿using System.ComponentModel.DataAnnotations;


namespace dotSkog.Data.Models
{
    public class User
    {
        [Key] 
        public int UserId { get; set; }
        [Required]

        public string UserName { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        public List<Post> Posts { get; set; } = new();
        public List<Comment> Comments { get; set; } = new();


    }
}
