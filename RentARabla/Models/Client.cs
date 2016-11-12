using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentARabla.Models
{
    public class Client : Person
    {
        [DataType(DataType.PostalCode)]
        public int Age { get; set; }
        public string NationalId { get; set; }

        public virtual Person Person { get; set; }
        public virtual Address Address { get; set; }
    }
}