using ExcelsiorLuxury.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Business.Interfaces
{
    public interface IDireccionService
    {
        Task<List<ZDireccion>> GetAllAsync();
        Task<ZDireccion?> GetByIdAsync(int id);
        Task<ZDireccion> AddAsync(ZDireccion direccion);
        Task<ZDireccion?> UpdateAsync(ZDireccion direccion);
        Task<bool> DeleteAsync(int id);
    }
}
