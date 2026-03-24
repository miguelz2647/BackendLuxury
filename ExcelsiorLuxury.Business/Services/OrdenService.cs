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
    public class OrdenService : IOrdenService
    {
        private readonly IZOrdenRepository _OrdenRepository;
        public OrdenService(IZOrdenRepository OrdenRepository) //Esto permite que .NET inyecte automáticamente el repository.
        {
            _OrdenRepository = OrdenRepository;
        }

        public Task<ZOrden> AddAsync(ZOrden orden)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ZOrden>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ZOrden?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ZOrden?> UpdateAsync(ZOrden orden)
        {
            throw new NotImplementedException();
        }
    }
}
