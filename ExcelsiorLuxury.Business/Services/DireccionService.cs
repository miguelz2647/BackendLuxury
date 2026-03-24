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
    public class DireccionService : IDireccionService
    {
        private readonly IZDireccionRepository _direccionRepository;
        public DireccionService(IZDireccionRepository direccionRepository) //Esto permite que .NET inyecte automáticamente el repository.
        {
            _direccionRepository = direccionRepository;
        }

        public async Task<List<ZDireccion>> GetAllAsync()
        {
            return await _direccionRepository.GetAllAsync();
        }

        public async Task<ZDireccion?> GetByIdAsync(int id)
        {
            return await _direccionRepository.GetByIdAsync(id);
        }

        public async Task<ZDireccion> AddAsync(ZDireccion direccion)
        {
            return await _direccionRepository.AddAsync(direccion);
        }

        public async Task<ZDireccion?> UpdateAsync(ZDireccion direccion)
        {
            return await _direccionRepository.UpdateAsync(direccion);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _direccionRepository.DeleteAsync(id);
        }
    }
}
