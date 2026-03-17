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
    public class ZOrdenDetalleRepository : IZOrdenDetalleRepository
    {
        private readonly ExcelsiorLuxuryDbContext _context;

        public ZOrdenDetalleRepository(ExcelsiorLuxuryDbContext context)
        {
            _context = context;
        }

        public async Task<List<ZOrdenDetalle>> GetAllAsync()
        {
            return await _context.ZOrdenDetalles
                .Include(od => od.Producto)
                .ToListAsync();
        }

        public async Task<ZOrdenDetalle?> GetByIdAsync(int id)
        {
            return await _context.ZOrdenDetalles
                .Include(od => od.Producto)
                .FirstOrDefaultAsync(od => od.Id == id);
        }

        public async Task<ZOrdenDetalle> AddAsync(ZOrdenDetalle detalle)
        {
            _context.ZOrdenDetalles.Add(detalle);
            await _context.SaveChangesAsync();
            return detalle;
        }

        public async Task<ZOrdenDetalle?> UpdateAsync(ZOrdenDetalle detalle)
        {
            var existing = await _context.ZOrdenDetalles.FindAsync(detalle.Id);

            if (existing == null) return null;

            existing.Id_Orden = detalle.Id_Orden;
            existing.Id_Producto = detalle.Id_Producto;
            existing.Cantidad = detalle.Cantidad;
            existing.PrecioUnitario = detalle.PrecioUnitario;
            existing.Subtotal = detalle.Subtotal;

            await _context.SaveChangesAsync();

            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var detalle = await _context.ZOrdenDetalles.FindAsync(id);

            if (detalle == null) return false;

            _context.ZOrdenDetalles.Remove(detalle);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
internal class ZOrdenDetalleRepository
    {
    }
}
