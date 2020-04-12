using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace TravelTest.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TravelTestContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TravelTestContext>>()))
            {
                // Look for any movies.
                if (context.Place.Any())
                {
                    return;
                }
                readXML();
                context.Place.AddRange(Coordinates);
                context.SaveChanges();
            }
        }


        public static List<Place> Coordinates { get; private set; }


        static void readXML()
        {

            Coordinates = new List<Place>();
            //Load xml
            XDocument xdoc = XDocument.Load("Travel.xml");
            var places = xdoc.Descendants("place");
            foreach (var xElem in places)
            {
                var name = xElem.Descendants("name").FirstOrDefault().Value;
                var lat = xElem.Descendants("lat").FirstOrDefault().Value;
                var pLong = xElem.Descendants("long").FirstOrDefault().Value;
                double dLat = 0;
                double dLong = 0;
                if (double.TryParse(lat, out dLat))
                    dLat = double.Parse(lat);
                else
                    dLat = double.Parse(lat.Replace('.', ','));

                if (double.TryParse(pLong, out dLong))
                    dLong = double.Parse(pLong);
                else
                    dLong = double.Parse(pLong.Replace('.', ','));


                Coordinates.Add(new Place
                {
                    Name = name,
                    Latitude = dLat,
                    Longitude = dLong
                });
            }



        }
    }
}
