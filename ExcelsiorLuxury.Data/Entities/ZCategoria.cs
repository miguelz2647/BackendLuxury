using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Data.Entities
{
    public class ZCategoria
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public ICollection<ZProducto> Productos { get; set; } = new List<ZProducto>();
    }
}
