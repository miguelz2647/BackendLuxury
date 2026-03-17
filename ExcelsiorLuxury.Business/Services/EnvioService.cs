using ExcelsiorLuxury.Business.Interfaces;
using ExcelsiorLuxury.Data.Entities;
using ExcelsiorLuxury.Data.Repositories.Intefaces;
using ExcelsiorLuxury.Data.Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Business.Services
{
    public class EnvioService : IEnvioService
    {
        private readonly IZEnvioRepository _EnvioRepository;
        public EnvioService(IZEnvioRepository EnvioRepository) //Esto permite que .NET inyecte automáticamente el repository.
        {
            _EnvioRepository = EnvioRepository;
        }

        public Task<ZEnvio> AddAsync(ZEnvio Envio)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ZEnvio>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ZEnvio?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ZEnvio?> UpdateAsync(ZEnvio Envio)
        {
            throw new NotImplementedException();
        }
    }
}
