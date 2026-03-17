using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Data.Entities
{
    public class ZDireccion
    {
        public int Id { get; set; }

        public int Id_Usuario { get; set; }

        public string Direccion { get; set; }

        public ZUsuario Usuario { get; set; }
        public ICollection<ZEnvio> Envios { get; set; } = new List<ZEnvio>();
    }
}
