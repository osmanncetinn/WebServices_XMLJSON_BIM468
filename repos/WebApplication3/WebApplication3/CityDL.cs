using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class CityDL
    {
        public static List<City> cities = new List<City>(){
            new City() { InCityId = 1, StCityName = "Adana" },
            new City() { InCityId = 2, StCityName = "Adiyaman " },
            new City() { InCityId = 3, StCityName = "Afyonkarahisar" },
            new City() { InCityId = 4, StCityName = "Ağrı" },
            new City() { InCityId = 5, StCityName = "Amasya" },
            new City() { InCityId = 6, StCityName = "Ankara" },
            new City() { InCityId = 7, StCityName = "Antalya" },
            new City() { InCityId = 8, StCityName = "Artvin" },
            new City() { InCityId = 9, StCityName = "Aydın" },
            new City() { InCityId = 10, StCityName = "Balıkesir" },
            new City() { InCityId = 11, StCityName = "Bilecik" },
            new City() { InCityId = 12, StCityName = "Bingöl" },
            new City() { InCityId = 13, StCityName = "Bitlis" },
            new City() { InCityId = 14, StCityName = "Bolu" },
            new City() { InCityId = 15, StCityName = "Burdur" },
            new City() { InCityId = 16, StCityName = "Bursa" },
            new City() { InCityId = 17, StCityName = "Çanakkale" },
            new City() { InCityId = 18, StCityName = "Çankırı" },
            new City() { InCityId = 19, StCityName = "Çorum" },
            new City() { InCityId = 20, StCityName = "Denizli" },
            new City() { InCityId = 21, StCityName = "Diyarbakır" },
            new City() { InCityId = 22, StCityName = "Edirne" },
            new City() { InCityId = 23, StCityName = "Elazığ" },
            new City() { InCityId = 24, StCityName = "Erzincan" },
            new City() { InCityId = 25, StCityName = "Erzurum" },
            new City() { InCityId = 26, StCityName = "Eskişehir" },
            new City() { InCityId = 27, StCityName = "Gaziantep" },
            new City() { InCityId = 28, StCityName = "Giresun" },
            new City() { InCityId = 29, StCityName = "Gümüşhane" },
            new City() { InCityId = 30, StCityName = "Hakkari" },
            new City() { InCityId = 31, StCityName = "Hatay" },
            new City() { InCityId = 32, StCityName = "Isparta" },
            new City() { InCityId = 33, StCityName = "Mersin" },
            new City() { InCityId = 34, StCityName = "İstanbul" },
            new City() { InCityId = 35, StCityName = "İzmir" },
            new City() { InCityId = 36, StCityName = "Kars" },
            new City() { InCityId = 37, StCityName = "Kastamonu" },
            new City() { InCityId = 38, StCityName = "Kayseri" },
            new City() { InCityId = 39, StCityName = "Kırklareli" },
            new City() { InCityId = 40, StCityName = "Kırşehir" },
            new City() { InCityId = 41, StCityName = "Kocaeli" },
            new City() { InCityId = 42, StCityName = "Konya" },
            new City() { InCityId = 43, StCityName = "Kütahya" },
            new City() { InCityId = 44, StCityName = "Malatya" },
            new City() { InCityId = 45, StCityName = "Manisa" },
            new City() { InCityId = 46, StCityName = "Kahramanmaraş" },
            new City() { InCityId = 47, StCityName = "Mardin" },
            new City() { InCityId = 48, StCityName = "Muğla" },
            new City() { InCityId = 49, StCityName = "Muş" },
            new City() { InCityId = 50, StCityName = "Nevşehir" },
            new City() { InCityId = 51, StCityName = "Niğde" },
            new City() { InCityId = 52, StCityName = "Ordu" },
            new City() { InCityId = 53, StCityName = "Rize" },
            new City() { InCityId = 54, StCityName = "Sakarya" },
            new City() { InCityId = 55, StCityName = "Samsun" },
            new City() { InCityId = 56, StCityName = "Siirt" },
            new City() { InCityId = 57, StCityName = "Sinop" },
            new City() { InCityId = 58, StCityName = "Sivas" },
            new City() { InCityId = 59, StCityName = "Tekirdağ" },
            new City() { InCityId = 60, StCityName = "Tokat" },
            new City() { InCityId = 61, StCityName = "Trabzon" },
            new City() { InCityId = 62, StCityName = "Tunceli" },
            new City() { InCityId = 63, StCityName = "Şanlıurfa" },
            new City() { InCityId = 64, StCityName = "Uşak" },
            new City() { InCityId = 65, StCityName = "Van" },
            new City() { InCityId = 66, StCityName = "Yozgat" },
            new City() { InCityId = 67, StCityName = "Zonguldak" },
            new City() { InCityId = 68, StCityName = "Aksaray" },
            new City() { InCityId = 69, StCityName = "Bayburt" },
            new City() { InCityId = 70, StCityName = "Karaman" },
            new City() { InCityId = 71, StCityName = "Kırıkkale" },
            new City() { InCityId = 72, StCityName = "Batman" },
            new City() { InCityId = 73, StCityName = "Şırnak" },
            new City() { InCityId = 74, StCityName = "Bartın" },
            new City() { InCityId = 75, StCityName = "Ardahan" },
            new City() { InCityId = 76, StCityName = "Iğdır" },
            new City() { InCityId = 77, StCityName = "Yalova" },
            new City() { InCityId = 78, StCityName = "Karabük" },
            new City() { InCityId = 79, StCityName = "Kilis" },
            new City() { InCityId = 80, StCityName = "Osmaniye" },
            new City() { InCityId = 81, StCityName = "Düzce" }
        };

        public static List<City> GetCities()
        {
            var list = cities;
            return list;
        }
        public static City GetCity(int Id)
        {
            var item = cities.Where(x => x.InCityId == Id).FirstOrDefault();
            return item;
        }
    }


    public class City
    {
        public int InCityId { get; set; }
        public string StCityName { get; set; }
    }


}
