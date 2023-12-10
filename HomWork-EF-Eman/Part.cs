using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomWork_EF_Eman
{
    public  class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public  int  price { get; set; }
        public int Quantity {  get; set; }

        public int SupplierId { get; set; }//Foreign Key
        public Suppliers Suppliers { get; set; }

        public ICollection<Car> Cars { get; set; }
        public List<CarParte> CarPartes { get; set; }
   

    }
}
