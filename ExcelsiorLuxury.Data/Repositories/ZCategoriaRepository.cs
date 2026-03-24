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
    public class ZCategoriaRepository : IZCategoriaRepository
    {
        private readonly ExcelsiorLuxuryDbContext _context;
        public ZCategoriaRepository(ExcelsiorLuxuryDbContext context)
        {
            _context = context;
        }

 
        public async Task<List<ZCategoria>> GetAllAsync()
        {
            return await _context.ZCategorias.ToListAsync();
        }

        public async Task<ZCategoria?> GetByIdAsync(int id)
        {
            return await _context.ZCategorias.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<ZCategoria> AddAsync(ZCategoria categoria)
        {
            _context.ZCategorias.Add(categoria);
            await _context.SaveChangesAsync();
            return categoria;
        }

        public async Task<ZCategoria?> UpdateAsync(ZCategoria categoria)
        {
            var existing = await _context.ZCategorias.FindAsync( categoria.Id);

            if (existing == null)
                return null;

            existing.Nombre = categoria.Nombre;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var categoria = await _context.ZCategorias.FindAsync(id);

            if (categoria == null)
                return false;

            _context.ZCategorias.Remove(categoria);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
