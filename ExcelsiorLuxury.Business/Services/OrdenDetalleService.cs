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
    public class OrdenDetalleService : IOrdenDetalleService
    {
        private readonly IZOrdenDetalleRepository _OrdenDetalleRepository;
        public OrdenDetalleService(IZOrdenDetalleRepository ordenDetalleRepository) //Esto permite que .NET inyecte automáticamente el repository.
        {
            _OrdenDetalleRepository = ordenDetalleRepository;
        }

        public Task<ZOrdenDetalle> AddAsync(ZOrdenDetalle ordenDetalle)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ZOrdenDetalle>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ZOrdenDetalle?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ZOrdenDetalle?> UpdateAsync(ZOrdenDetalle ordenDetalle)
        {
            throw new NotImplementedException();
        }
    }
}
