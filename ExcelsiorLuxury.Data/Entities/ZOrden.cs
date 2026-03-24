using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Data.Entities
{
    public class ZOrden
    {
        public int Id { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Envio { get; set; }
        public DateTime Fecha { get; set; }

        [Column(TypeName = "numeric(18, 2)")]
        public decimal Valor_Neto { get; set; }

        [ForeignKey("Id_Usuario")]
        public ZUsuario Usuario { get; set; }

        [ForeignKey("Id_Envio")]
        public ZEnvio Envio { get; set; }

        public ICollection<ZOrdenDetalle> OrdenDetalles { get; set; } = new List<ZOrdenDetalle>();
    }
}
