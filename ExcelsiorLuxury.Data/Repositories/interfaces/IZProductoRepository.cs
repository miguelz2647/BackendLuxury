using ExcelsiorLuxury.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Data.Repositories.interfaces
{
    public interface IZProductoRepository
    {
        Task<List<ZProducto>> GetAllAsync();
        Task<ZProducto?> GetByIdAsync(int id);
        Task<ZProducto> AddAsync(ZProducto producto);
        Task<ZProducto?> UpdateAsync(ZProducto producto);
        Task<bool> DeleteAsync(int id);
    }
}
