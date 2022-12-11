using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace proyectofinal.Models.Entidades
{
    public class FacturaEntity
    {
        public int IdFactura { get; set; }

        public int IdCustomer { get; set; }
        public DateTime fechaCreacion  { get; set; }
        public List<Product> Products { get; set; }
        public bool estado { get; set; }

    }
}