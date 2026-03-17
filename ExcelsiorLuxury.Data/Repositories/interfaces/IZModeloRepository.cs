using ExcelsiorLuxury.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Data.Repositories.interfaces
{
    public interface IZModeloRepository
    {
        Task<List<ZModelo>> GetAllAsync();
        Task<ZModelo?> GetByIdAsync(int id);
        Task<ZModelo> AddAsync(ZModelo modelo);
        Task<ZModelo?> UpdateAsync(ZModelo modelo);
        Task<bool> DeleteAsync(int id);
    }
}
