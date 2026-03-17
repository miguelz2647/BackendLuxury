using ExcelsiorLuxury.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Data.Repositories.interfaces
{
    public interface IZEnvioRepository
    {
        Task<List<ZEnvio>> GetAllAsync();
        Task<ZEnvio?> GetByIdAsync(int id);
        Task<ZEnvio> AddAsync(ZEnvio Envio);
        Task<ZEnvio?> UpdateAsync(ZEnvio Envio);
        Task<bool> DeleteAsync(int id);
    


    }
}
