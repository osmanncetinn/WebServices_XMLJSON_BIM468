using RestServisExample.Data;
using RestServisExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RestServisExample.Controllers
{
    public class dovizController : ApiController
    {
        private List<Doviz> _DovizData;

        public List<Doviz> Get()
        {
            var DovizKur = new DovizDL();
            return DovizKur.Get();

        }
        //public Doviz Get()
        //{
        //    Doviz kur = new Doviz();

        //    kur.DovizTipi = "Dolar";
        //    kur.DovizTarih = DateTime.Today;
        //    kur.DovizKur = 6.1234;
        //    return kur;
        //}



    }
}
