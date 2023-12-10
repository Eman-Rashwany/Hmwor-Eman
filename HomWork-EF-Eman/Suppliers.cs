using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomWork_EF_Eman
{
    public class Suppliers
    { 
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }


        public List<Part> Parts { get; set; }



    }
}
