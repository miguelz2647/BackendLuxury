
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
    public class ZProductoRepository : IZProductoRepository
    {
        private readonly ExcelsiorLuxuryDbContext _context;

        public ZProductoRepository(ExcelsiorLuxuryDbContext context)
        {
            _context = context;
        }

        public async Task<List<ZProducto>> GetAllAsync()
        {
            return await _context.ZProductos
                .Include(p => p.Modelos)
                .Include(p => p.Marcas)
                .ToListAsync();
        }

        public async Task<ZProducto?> GetByIdAsync(int id)
        {
            return await _context.ZProductos
                .Include(p => p.Modelos)
                .Include(p => p.Marcas)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<ZProducto> AddAsync(ZProducto producto)
        {
            _context.ZProductos.Add(producto);
            await _context.SaveChangesAsync();
            return producto;
        }

        public async Task<ZProducto?> UpdateAsync(ZProducto producto)
        {
            var existing = await _context.ZProductos.FindAsync(producto.Id);

            if (existing == null) return null;

            existing.Nombre = producto.Nombre;
            existing.Id_Modelo = producto.Id_Modelo;
            existing.Id_Marca = producto.Id_Marca;
            existing.Costo = producto.Costo;

            await _context.SaveChangesAsync();

            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var producto = await _context.ZProductos.FindAsync(id);

            if (producto == null) return false;

            _context.ZProductos.Remove(producto);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}