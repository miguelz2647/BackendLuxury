using System;
using System.Collections.Generic;
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
        public string Costo { get; set; }

        public ZModelo Modelos { get; set; }
        public ZMarca Marcas { get; set; }
        public ZCategoria Categoria { get; set; }

        public ICollection<ZOrdenDetalle> OrdenDetalles { get; set; } = new List<ZOrdenDetalle>();
    }
}
