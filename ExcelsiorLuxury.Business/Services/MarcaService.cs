using ExcelsiorLuxury.Business.Interfaces;
using ExcelsiorLuxury.Data.Entities;
using ExcelsiorLuxury.Data.Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Business.Services
{
    public class MarcaService : IMarcaService
    {
        private readonly IZMarcaRepository _MarcaRepository;
        public MarcaService(IZMarcaRepository MarcaRepository) //Esto permite que .NET inyecte automáticamente el repository.
        {
            _MarcaRepository = MarcaRepository;
        }
        public Task<ZMarca> AddAsync(ZMarca marca)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ZMarca>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ZMarca?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ZMarca?> UpdateAsync(ZMarca marca)
        {
            throw new NotImplementedException();
        }
    }
}
