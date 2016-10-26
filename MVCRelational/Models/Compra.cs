using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRelational.Models
{
    public class Compra
    {
        public int CompraId { get; set; }
        public float TotalCompra { get; set; }
        public DateTime FechaCompra { get; set; }
        public List<Producto> Productos { get; set; }
    }
}