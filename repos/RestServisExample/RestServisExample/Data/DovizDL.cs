using RestServisExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestServisExample.Data
{
    public class DovizDL
    {
        private static List<Doviz> _DovizData = new List<Doviz>(){
            new Doviz() {DovizTipi="Dolar", DovizTarih = DateTime.Today.AddDays(-1), DovizKur = 6.1234 },
            new Doviz() {DovizTipi="Euro", DovizTarih = DateTime.Today.AddDays(-1), DovizKur = 7.1234 },
            new Doviz() {DovizTipi="Sterlin", DovizTarih = DateTime.Today.AddDays(-1), DovizKur = 8.1234 }

        };

        public List<Doviz> Get()
        {
            return _DovizData;
        }

        public List<Doviz> Get(DateTime Tarih)
        {
            return _DovizData.Where(x => x.DovizTarih == Tarih).ToList();
        }
        public Doviz Get(string DovizTipi, DateTime Tarih)
        {
            return _DovizData.Where(x => x.DovizTarih == Tarih && x.DovizTipi == DovizTipi).Single();
        }
    }
}