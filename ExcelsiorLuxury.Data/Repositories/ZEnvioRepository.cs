using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelsiorLuxury.Data.Context;
using ExcelsiorLuxury.Data.Entities;
using ExcelsiorLuxury.Data.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;

namespace ExcelsiorLuxury.Data.Repositories
{
    public class ZEnvioRepository : IZEnvioRepository
    {
        private readonly ExcelsiorLuxuryDbContext _context;

        public ZEnvioRepository(ExcelsiorLuxuryDbContext context)
        {
            _context = context;
        }

        #region Methods

        public async Task<List<ZEnvio>> GetAllAsync()
        {
            return await _context.ZEnvios
                                 .Include(e => e.Direccion)
                                 .Include(e => e.Ordenes)
                                 .ToListAsync();
        }

        public async Task<ZEnvio?> GetByIdAsync(int id)
        {
            return await _context.ZEnvios
                                 .Include(e => e.Direccion)
                                 .Include(e => e.Ordenes)
                                 .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<ZEnvio> AddAsync(ZEnvio envio)
        {
            _context.ZEnvios.Add(envio);
            await _context.SaveChangesAsync();
            return envio;
        }

        public async Task<ZEnvio?> UpdateAsync(ZEnvio envio)
        {
            var existing = await _context.ZEnvios.FindAsync(envio.Id);
            if (existing == null) return null;

            existing.Id_Direccion = envio.Id_Direccion;
            existing.Fecha_Salida = envio.Fecha_Salida;
            existing.Fecha_Entrada = envio.Fecha_Entrada;
            existing.Costo_Envio = envio.Costo_Envio;
            existing.Estado_Envio = envio.Estado_Envio;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var envio = await _context.ZEnvios.FindAsync(id);
            if (envio == null) return false;

            _context.ZEnvios.Remove(envio);
            await _context.SaveChangesAsync();
            return true;
        }

        #endregion
    }
}