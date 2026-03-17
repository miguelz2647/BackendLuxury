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
    public class ModeloService : IModeloService
    {
        private readonly IZModeloRepository _ModelRepository;
        public ModeloService(IZModeloRepository ModeloRepository) //Esto permite que .NET inyecte automáticamente el repository.
        {
            _ModelRepository = ModeloRepository;
        }
        public Task<ZModelo> AddAsync(ZModelo modelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ZModelo>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ZModelo?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ZModelo?> UpdateAsync(ZModelo modelo)
        {
            throw new NotImplementedException();
        }
    }
}
