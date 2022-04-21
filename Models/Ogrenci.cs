using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Ogrenci:Kisi
    {
        public int ogrNo { get; set; }
        public List<Ders> aldigiDersler { get; set; }
    }
}
