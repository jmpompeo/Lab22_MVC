using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab22.Models
{
    public class MovieModel
    {
       
        public string Title { get; set; }
        public string Genre { get; set; }
        public MovieModel(string title, string genre)
        {
            Title = title;
            Genre = genre; 
        }
    }
}
