using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace bankacademy.Models
{
    public class Moviemodel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name.")]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        public DateTime? ReleaseDate { get; set; }

        [Display(Name = "Date Added")]
        public DateTime? DateAdded { get; set; }


        [MinStockNumber]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }

        [Display(Name = "Genre")]
        public int GenreId { get; set; }

        public Genremodel Genrelist { get; set; }

        public string Description { get; set; }
    }
}