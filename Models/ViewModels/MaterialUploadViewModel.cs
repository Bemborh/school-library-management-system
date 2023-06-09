﻿using System.ComponentModel.DataAnnotations;

namespace SchoolLIbrary.Models.ViewModels
{
    public class MaterialUploadViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        [Display(Name = "Material Type")]
        public string MaterialType { get; set; }

        [Required]
        public string Falculty { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public int? Quantity { get; set; }

        [Required]
        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }
        public int? QuantityLeft { get; set; }
        public string? MaterialUrl { get; set; }

        [Required]
        [MaxFileSize(9 * 1024 * 1024)]
        [Display(Name = "Select Material")]
        public IFormFile? MaterialFile { get; set; }
    }
}
