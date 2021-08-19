using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication4
{
    /// <summary>
    /// Summary description for CityService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
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
        public List<County> GetCounties()
        {
            var list = CountyDL.GetCounties();
            return list;
        }

    }
}
