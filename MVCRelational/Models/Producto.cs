using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCRelational.Models
{
    public class Producto
    {
        public int ProductoId { get; set; }
        public string  Nombre { get; set; }
        public float PrecioUnitario { get; set; }
        public Categoria Categoria { get; set; }
        public Compra MiCompra { get; set; }
        public int CompraId { get; set; }
        public List<Compra> Compras { get; set; }
    }

        public enum Categoria
    {
        Limpieza,
        Bebidas,
        Electrodomesticos,
        Comida
    }
    /* Uno a muchos: traslado la pk dentro de la tabla de muchos */
}