using RentARabla.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentARabla.Models
{
    public class Price
    {
        public double PriceValue { get; set; }
        public Currency Currency { get; set; }

        public override string ToString()
        {
            return PriceValue + " " + Currency;
        }
    }
}