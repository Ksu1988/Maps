using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelTest.Models
{
    public class Place
    {
        //public Place(string name, double lat, double pLong)
        //{
        //    Name = name;
        //    Latitude = lat;
        //    Longitude = pLong;
        //}

        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Широта
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Долгота
        /// </summary>
        public double Longitude { get; set; }
    }
}
