using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Data.Entities
{
    public class ZProducto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public int Id_Modelo { get; set; }

        public int Id_Marca { get; set; }
        public int Id_Categoria { get; set; }

        [Column(TypeName = "numeric(18, 2)")]
        public decimal Costo { get; set; }

        [ForeignKey("Id_Modelo")]
        public ZModelo Modelos { get; set; }

        [ForeignKey("Id_Marca")]
        public ZMarca Marcas { get; set; }

        [ForeignKey("Id_Categoria")]
        public ZCategoria Categoria { get; set; }

        public ICollection<ZOrdenDetalle> OrdenDetalles { get; set; } = new List<ZOrdenDetalle>();
    }
}
