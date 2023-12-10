using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomWork_EF_Eman
{
    public class CarParte
    {
        public int PartId { get; set; }
        public Part Part { get; set; }
        public int CARId { get; set; }
        public Car Car { get; set; }
        public DateTime Addedon { get; set; }
    }
}
