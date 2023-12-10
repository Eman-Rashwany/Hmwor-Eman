
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomWork_EF_Eman
{
    public class Sale
    {
        
        
            public int Id { get; set; }
            public string Total { get; set; }
            public int CarId {  get; set; }
            public Car Car { get; set; }


           public int CustomerId {  get; set; }
           public Customer Customer { get; set; }//reference navigation property
        
    }
}
