using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab22.Models
{
    public class MovieGenreModel
    {
        public List<MovieModel> Movies { get; set; }
        public string Genre { get; set; }
        public SelectList Genres { get; set; }
        public string Search { get; set; }
    }
}
