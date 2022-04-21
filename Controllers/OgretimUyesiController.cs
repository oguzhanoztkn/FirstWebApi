using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OgretimUyesiController : ControllerBase
    {
        public OgretimUyesiController()
        {
        }

        [HttpGet]
        public List<OgretimUyesi> Get()
        {
            List<Ders> dersler = new List<Ders>();
            dersler.Add(new Ders { Id = 0, ad = "Matematik1", derKodu = "MM101", kontenjan = 5 });
            dersler.Add(new Ders { Id = 1, ad = "Matematik2", derKodu = "MM102", kontenjan = 30 });
            dersler.Add(new Ders { Id = 1, ad = "Fizik1", derKodu = "FF101", kontenjan = 30 });

            List<OgretimUyesi> hocalar = new List<OgretimUyesi>();
            hocalar.Add(new OgretimUyesi { Id = 0, persNo = 999, ad = "Zübeyde", soyad = "Açıkel", dTarihi = DateTime.Today, verdigiDersler = dersler });

            return hocalar;

        }
    }
}
