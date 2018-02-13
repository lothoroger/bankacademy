using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using bankacademy.Models;

namespace bankacademy.ViewModels
{
    public class MovieViewModel
    {

        public IEnumerable<Genremodel> Genrelist { get; set; }
        public Moviemodel Moviemodel { get; set; }
    }
}