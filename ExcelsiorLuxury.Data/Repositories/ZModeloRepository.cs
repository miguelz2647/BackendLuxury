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
    public class ZModeloRepository : IZModeloRepository
    {
        private readonly ExcelsiorLuxuryDbContext _context;

        public ZModeloRepository(ExcelsiorLuxuryDbContext context)
        {
            _context = context;
        }

        public async Task<List<ZModelo>> GetAllAsync()
        {
            return await _context.ZModelos.ToListAsync();
        }

        public async Task<ZModelo?> GetByIdAsync(int id)
        {
            return await _context.ZModelos.FindAsync(id);
        }

        public async Task<ZModelo> AddAsync(ZModelo modelo)
        {
            _context.ZModelos.Add(modelo);
            await _context.SaveChangesAsync();
            return modelo;
        }

        public async Task<ZModelo?> UpdateAsync(ZModelo modelo)
        {
            var existing = await _context.ZModelos.FindAsync(modelo.Id);

            if (existing == null)
                return null;

            existing.Nombre = modelo.Nombre;

            await _context.SaveChangesAsync();

            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var modelo = await _context.ZModelos.FindAsync(id);

            if (modelo == null)
                return false;

            _context.ZModelos.Remove(modelo);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
