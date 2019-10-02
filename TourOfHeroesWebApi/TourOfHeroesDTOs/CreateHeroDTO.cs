﻿using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace TourOfHeroesDTOs
{
    // ReSharper disable once InconsistentNaming
    public class CreateHeroDTO
    {
        [Required(ErrorMessage = "Field is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        public IFormFile Image { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        public IFormFile CoverImage { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        public string RealName { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        public DateTime Birthday { get; set; }

        [Required(ErrorMessage = "Field is required.")]
        public string Gender { get; set; }
    }
}
