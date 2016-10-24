using RentARabla.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentARabla.Models
{
    public class Car
    {
        public int Id { get; set; }
        public double PricePerDay { get; set; }
        public DateTime ManufactureDate { get; set; }
        public FuelType FuelType { get; set; }
        public CarType Type { get; set; }
        public CarBrand Brand { get; set; }
        public CarModel Model { get; set; }
    }
}