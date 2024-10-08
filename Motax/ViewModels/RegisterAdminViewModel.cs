﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Motax.ViewModels
{
    public class RegisterAdminViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter fullname *")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Please enter email *")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter password *")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please confirm your password *")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string? ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter phone *")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter address *")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Please enter Date of birth *")]
        public DateTime? Dob { get; set; }

        [Required(ErrorMessage = "Please enter Gender *")]
        public string? Gender { get; set; }

        public IFormFile? Image { get; set; }

        public string? ExistingImage { get; set; }

        public int? RoleId { get; set; }

        [Display(Name = "Role")]
        public IEnumerable<SelectListItem>? Roles { get; set; }
    }
}
