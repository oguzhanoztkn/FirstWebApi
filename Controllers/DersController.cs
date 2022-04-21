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
    public class DersController : ControllerBase
    {
        public DersController()
        {

        }

        [HttpGet]
        public List<Ders> Get()
        {
            List<Ders> dersler = new List<Ders>();
            dersler.Add(new Ders { Id = 0, ad = "Matematik1", derKodu = "MM101", kontenjan = 5 });
            dersler.Add(new Ders { Id = 1, ad = "Matematik2", derKodu = "MM102", kontenjan = 30 });
            dersler.Add(new Ders { Id = 2, ad = "Fizik1", derKodu = "FF101", kontenjan = 30 });
            return dersler;
        }
    }
  
}
