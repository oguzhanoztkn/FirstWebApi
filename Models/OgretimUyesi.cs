using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class OgretimUyesi:Kisi
    {
        public int dersNo { get; set; }
        public List<Ders> verdigiDersler { get; set; }
        public int persNo { get; set; }
    }
}
