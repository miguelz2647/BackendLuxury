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
    public class CategoriaService : ICategoriaService
    {
        private readonly IZCategoriaRepository _CategoriaRepository;
        public CategoriaService(IZCategoriaRepository  categoriaRepository) //Esto permite que .NET inyecte automáticamente el repository.
        {
            _CategoriaRepository = categoriaRepository;
        }

        public Task<ZCategoria> AddAsync(ZCategoria categoria)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ZCategoria>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ZCategoria?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ZCategoria?> UpdateAsync(ZCategoria categoria)
        {
            throw new NotImplementedException();
        }
    }
}
