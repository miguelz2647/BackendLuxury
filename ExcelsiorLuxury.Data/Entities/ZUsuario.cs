using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Data.Entities
{
    public class ZUsuario
    {
        public int Id { get; set; }

        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public string Email { get; set; }

        public string Contraseña { get; set; }

        public ICollection<ZDireccion> Direcciones { get; set; } = new List<ZDireccion>();

        public ICollection<ZOrden> Ordenes { get; set; } = new List<ZOrden>();
    }
}
