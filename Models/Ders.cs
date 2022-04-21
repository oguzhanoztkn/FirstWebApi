using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Ders:Entity
    {
        public string derKodu { get; set; }
        public string ad { get; set; }
        public int kontenjan { get; set; }
    }
}
