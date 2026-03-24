using ExcelsiorLuxury.Data.Context;
using ExcelsiorLuxury.Data.Entities;
using ExcelsiorLuxury.Data.Repositories.interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Data.Repositories
{
    public class ZOrdenRepository : IZOrdenRepository
    {
        private readonly ExcelsiorLuxuryDbContext _context;

        public ZOrdenRepository(ExcelsiorLuxuryDbContext context)
        {
            _context = context;
        }

        public async Task<List<ZOrden>> GetAllAsync()
        {
            return await _context.ZOrdenes
                .Include(o => o.Usuario)
                .Include(o => o.Envio)
                .Include(o => o.OrdenDetalles)
                .ToListAsync();
        }

        public async Task<ZOrden?> GetByIdAsync(int id)
        {
            return await _context.ZOrdenes
                .Include(o => o.Usuario)
                .Include(o => o.Envio)
                .Include(o => o.OrdenDetalles)
                .FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<ZOrden> AddAsync(ZOrden orden)
        {
            _context.ZOrdenes.Add(orden);
            await _context.SaveChangesAsync();
            return orden;
        }

        public async Task<ZOrden?> UpdateAsync(ZOrden orden)
        {
            var existing = await _context.ZOrdenes.FindAsync(orden.Id);

            if (existing == null) return null;

            existing.Id_Usuario = orden.Id_Usuario;
            existing.Id_Envio = orden.Id_Envio;
            existing.Fecha = orden.Fecha;
            existing.Valor_Neto = orden.Valor_Neto;

            await _context.SaveChangesAsync();

            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var orden = await _context.ZOrdenes.FindAsync(id);

            if (orden == null) return false;

            _context.ZOrdenes.Remove(orden);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
