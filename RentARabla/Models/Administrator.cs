using RentARabla.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentARabla.Models
{
    public class Administrator
    {
        public Role Role { get; set; }

        public virtual Person Person { get; set; }
    }
}