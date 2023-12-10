using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HomWork_EF_Eman
{


    public class Car
    {
        public int CARId { get; set; }
        [Required, MaxLength(100)]
        public string Model { get; set; }

        public int Year { get; set; }
        public int Gear { get; set; }
        public int Km { get; set; }

        public Sale Sale { get; set; }
        public ICollection<Part> Parts { get; set; }
        public List<CarParte> CarPartes { get; set; }



    }

   
}
