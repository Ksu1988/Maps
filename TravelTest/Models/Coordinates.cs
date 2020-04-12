using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace TravelTest.Models
{
    public class Coordinates
    {
       
            public List<Place> Places { get; set; }
            public SelectList MapPoint { get; set; }
            public string PlaceName { get; set; }
            public string SearchString { get; set; }

        //public class MovieGenreViewModel
        //{
        //    public List<Movie> Movies { get; set; }
        //    public SelectList Genres { get; set; }
        //    public string MovieGenre { get; set; }
        //    public string SearchString { get; set; }
        //}

    }
}
