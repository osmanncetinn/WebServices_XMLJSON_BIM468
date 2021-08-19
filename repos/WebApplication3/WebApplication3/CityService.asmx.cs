using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication3
{
    /// <summary>
    /// WebService1 için özet açıklama
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Bu Web Hizmeti'nin, ASP.NET AJAX kullanılarak komut dosyasından çağrılmasına, aşağıdaki satırı açıklamadan kaldırmasına olanak vermek için.
    // [System.Web.Script.Services.ScriptService]
    public class CityService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<City> GetCities()
        {
            var list = CityDL.GetCities();
            return list;
        }

        [WebMethod]
        public City GetCity(int Id)
        {
            var list = CityDL.GetCities();
            var item = list.Where(x => x.InCityId == Id).FirstOrDefault();
            return item;
        }


        [WebMethod]
        public List<County> GetCounties(int Id)
        {
            var list = CountyDL.GetCounties(Id);
            return list;
        }

        [WebMethod]
        public County GetCounty(int Id)
        {
            var list = CountyDL.GetCounty(Id);
            return list;
        }

    }
}
