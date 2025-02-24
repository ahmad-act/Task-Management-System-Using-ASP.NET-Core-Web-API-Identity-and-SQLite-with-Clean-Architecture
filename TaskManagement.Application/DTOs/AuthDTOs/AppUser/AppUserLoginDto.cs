﻿namespace TaskManagement.Application.DTOs.AuthDTOs.AppUser
{
    public class AppUserLoginDto
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        public bool RememberMe { get; set; } = false;
    }
}
