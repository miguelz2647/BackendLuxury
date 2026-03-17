using ExcelsiorLuxury.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Data.Repositories.interfaces
{
    public interface IZUsuarioRepository
    {
        Task<List<ZUsuario>> GetAllAsync();
        Task<ZUsuario?> GetByIdAsync(int id);
        Task<ZUsuario> AddAsync(ZUsuario usuario);
        Task<ZUsuario?> UpdateAsync(ZUsuario usuario);
        Task<bool> DeleteAsync(int id);
    }
}
