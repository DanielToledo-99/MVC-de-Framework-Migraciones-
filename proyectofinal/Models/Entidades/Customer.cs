using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectofinal.Models.Entidades
{
    public class Customer
    {
        public int IdCustomer { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public int Phone { get; set; }
        public string Email { get; set; }

        public List<FacturaEntity> Factura { get; set; }
    }
}