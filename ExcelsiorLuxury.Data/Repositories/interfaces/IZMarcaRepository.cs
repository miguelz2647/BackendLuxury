using ExcelsiorLuxury.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Data.Repositories.interfaces
{
    public interface IZMarcaRepository
    {
        Task<List<ZMarca>> GetAllAsync();
        Task<ZMarca?> GetByIdAsync(int id);
        Task<ZMarca> AddAsync(ZMarca marca);
        Task<ZMarca?> UpdateAsync(ZMarca marca);
        Task<bool> DeleteAsync(int id);
    }
}
