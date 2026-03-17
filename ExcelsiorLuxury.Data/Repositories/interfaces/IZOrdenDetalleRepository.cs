using ExcelsiorLuxury.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Data.Repositories.interfaces
{
    public interface IZOrdenDetalleRepository
    {
        Task<List<ZOrdenDetalle>> GetAllAsync();
        Task<ZOrdenDetalle?> GetByIdAsync(int id);
        Task<ZOrdenDetalle> AddAsync(ZOrdenDetalle ordenDetalle);
        Task<ZOrdenDetalle?> UpdateAsync(ZOrdenDetalle ordenDetalle);
        Task<bool> DeleteAsync(int id);
    }
}
