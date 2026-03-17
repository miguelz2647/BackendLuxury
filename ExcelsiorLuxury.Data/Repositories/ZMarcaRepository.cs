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
    public class ZMarcaRepository : IZMarcaRepository
    {
        private readonly ExcelsiorLuxuryDbContext _context;

        public ZMarcaRepository(ExcelsiorLuxuryDbContext context)
        {
            _context = context;
        }

        #region Methods

        public async Task<List<ZMarca>> GetAllAsync()
        {
            return await _context.ZMarcas.ToListAsync();
        }

        public async Task<ZMarca?> GetByIdAsync(int id)
        {
            return await _context.ZMarcas.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<ZMarca> AddAsync(ZMarca marca)
        {
            _context.ZMarcas.Add(marca);
            await _context.SaveChangesAsync();
            return marca;
        }

        public async Task<ZMarca?> UpdateAsync(ZMarca marca)
        {
            var existing = await _context.ZMarcas.FindAsync(marca.Id);

            if (existing == null)
                return null;

            existing.Nombre = marca.Nombre;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var marca = await _context.ZMarcas.FindAsync(id);

            if (marca == null)
                return false;

            _context.ZMarcas.Remove(marca);
            await _context.SaveChangesAsync();
            return true;
        }

        #endregion
    }
}
