
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
    public class ProductoService : IProductoService
    {
        private readonly IZProductoRepository _ProductoRepository;
        public ProductoService(IZProductoRepository ProductoRepository) //Esto permite que .NET inyecte automáticamente el repository.
        {
            _ProductoRepository = ProductoRepository;
        }
        public Task<ZProducto> AddAsync(ZProducto producto)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ZProducto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ZProducto?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ZProducto?> UpdateAsync(ZProducto producto)
        {
            throw new NotImplementedException();
        }
    }
}
