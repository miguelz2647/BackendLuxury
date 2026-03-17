using ExcelsiorLuxury.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Business.Interfaces
{
    public interface IOrdenService
    {
        Task<List<ZOrden>> GetAllAsync();
        Task<ZOrden?> GetByIdAsync(int id);
        Task<ZOrden> AddAsync(ZOrden orden);
        Task<ZOrden?> UpdateAsync(ZOrden orden);
        Task<bool> DeleteAsync(int id);
    }
}
