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
    public class OgrenciController : ControllerBase
    {
        public OgrenciController()
        {
        }
        [HttpGet]
        public List<Ogrenci>Get()
        {
            List<Ders> dersler1 = new List<Ders>();
            dersler1.Add(new Ders { Id = 0, ad = "Matematik1", derKodu = "MM101", kontenjan = 5 });
            dersler1.Add(new Ders { Id = 1, ad = "Matematik2", derKodu = "MM102", kontenjan = 30 });

            List<Ders> dersler2 = new List<Ders>();
            dersler2.Add(new Ders { Id = 0, ad = "Matematik1", derKodu = "MM101", kontenjan = 5 });

            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            ogrenciler.Add(new Ogrenci { Id = 0, ogrNo = 111, ad = "Oğuzhan", soyad = "Öztekin", dTarihi = DateTime.Today, aldigiDersler = dersler1 });
            ogrenciler.Add(new Ogrenci { Id = 1, ogrNo = 222, ad = "Ayşe", soyad = "Yılmaz", dTarihi = DateTime.Today, aldigiDersler = dersler2 });

            return ogrenciler;


        }
    }
}
