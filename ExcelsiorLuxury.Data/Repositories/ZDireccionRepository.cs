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
    public class ZDireccionRepository : IZDireccionRepository
    {
        private readonly ExcelsiorLuxuryDbContext _context;

        public ZDireccionRepository(ExcelsiorLuxuryDbContext context)
        {
            _context = context;
        }
        public async Task<List<ZDireccion>> GetAllAsync()
        {
            return await _context.ZDirecciones.ToListAsync();
        }

        public async Task<ZDireccion?> GetByIdAsync(int id)
        {
            return await _context.ZDirecciones.FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<ZDireccion> AddAsync(ZDireccion direccion)
        {
            _context.ZDirecciones.Add(direccion);
            await _context.SaveChangesAsync();
            return direccion;
        }

        public async Task<ZDireccion?> UpdateAsync(ZDireccion direccion)
        {
            var existing = await _context.ZDirecciones.FindAsync(direccion.Id);
            if (existing == null) return null;

            existing.Direccion = direccion.Direccion;
            existing.Id_Usuario = direccion.Id_Usuario;

            await _context.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var direccion = await _context.ZDirecciones.FindAsync(id);
            if (direccion == null) return false;

            _context.ZDirecciones.Remove(direccion);
            await _context.SaveChangesAsync();
            return true;
        }
    }

}

