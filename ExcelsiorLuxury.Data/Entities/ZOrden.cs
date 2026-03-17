using System;
using System.Collections.Generic;
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
        public decimal Valor_Neto { get; set; }

        public ZUsuario Usuario { get; set; }
        public ZEnvio Envio { get; set; }

        public ICollection<ZOrdenDetalle> OrdenDetalles { get; set; } = new List<ZOrdenDetalle>();
    }
}
