using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagement.Entities
{
    public class Car
    {
        public static int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Cost { get; set; }
        public bool ForRent { get; set; }
        public bool Rented { get; set; }

       
        public Car(string brand,string model,int year,bool forrent) { 
            Brand = brand;
            Model = model;
            Year = year;
            ForRent = forrent;
            Id++;                     
        }

      
    }
}
