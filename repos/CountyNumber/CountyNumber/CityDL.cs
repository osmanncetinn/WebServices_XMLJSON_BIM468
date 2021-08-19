using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CountyNumber
{
    public class CityDL
    {
        public static List<City> cities = new List<City>(){
            new City() { InCityTelNo = 222, InCityId = 1, StCityName = "Adana" },
            new City() { InCityTelNo = 333, InCityId = 2, StCityName = "Adiyaman " },
            new City() { InCityTelNo = 444, InCityId = 3, StCityName = "Afyonkarahisar" },
            new City() { InCityTelNo = 555, InCityId = 4, StCityName = "Ağrı" }
        };

        public static List<City> GetCities()
        {
            var list = cities;
            return list;
        }
        public static City GetCity(string Name)
        {
            var item = cities.Where(x => x.StCityName == Name).FirstOrDefault();
            //var item = 
            return item;
        }
    }


    public class City
    {
        public int InCityTelNo { get; set; }
        public int InCityId { get; set; }
        public string StCityName { get; set; }
    }

}
