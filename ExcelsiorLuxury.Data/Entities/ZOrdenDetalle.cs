using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Data.Entities
{
    public class ZOrdenDetalle
    {
        public int Id { get; set; }
        public int Id_Orden { get; set; }
        public int Id_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }

        public ZOrden Orden { get; set; }
        public ZProducto Producto { get; set; }
    }
}