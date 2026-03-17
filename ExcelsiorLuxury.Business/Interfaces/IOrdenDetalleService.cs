using ExcelsiorLuxury.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Business.Interfaces
{
    public interface IOrdenDetalleService
    {
        Task<List<ZOrdenDetalle>> GetAllAsync();
        Task<ZOrdenDetalle?> GetByIdAsync(int id);
        Task<ZOrdenDetalle> AddAsync(ZOrdenDetalle ordenDetalle);
        Task<ZOrdenDetalle?> UpdateAsync(ZOrdenDetalle ordenDetalle);
        Task<bool> DeleteAsync(int id);
    }
}
