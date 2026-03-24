using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        [Column(TypeName = "numeric(18, 2)")]
        public decimal PrecioUnitario { get; set; }

        [Column(TypeName = "numeric(18, 2)")]
        public decimal Subtotal { get; set; }

        [ForeignKey("Id_Orden")]
        public ZOrden Orden { get; set; }
        
        [ForeignKey("Id_Producto")]
        public ZProducto Producto { get; set; }
    }
}