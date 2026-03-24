using ExcelsiorLuxury.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Business.Interfaces
{
    public interface ICategoriaService
    {
        Task<List<ZCategoria>> GetAllAsync();
        Task<ZCategoria?> GetByIdAsync(int id);
        Task<ZCategoria> AddAsync(ZCategoria categoria);
        Task<ZCategoria?> UpdateAsync(ZCategoria categoria);
        Task<bool> DeleteAsync(int id);
    }
}
