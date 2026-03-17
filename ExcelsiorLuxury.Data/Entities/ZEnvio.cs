using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Data.Entities
{
    public class ZEnvio
    {
        public int Id { get; set; }

       
        public int Id_Direccion { get; set; }

        public DateTime Fecha_Salida { get; set; }
        public DateTime? Fecha_Entrada { get; set; }  
        public decimal Costo_Envio { get; set; }
        public string Estado_Envio { get; set; }
        public ZDireccion Direccion { get; set; }
        public ICollection<ZOrden> Ordenes { get; set; } = new List<ZOrden>();
    }
}
