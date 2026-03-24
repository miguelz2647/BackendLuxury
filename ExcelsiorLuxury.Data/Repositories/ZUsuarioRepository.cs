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
    public class ZUsuarioRepository : IZUsuarioRepository
    {

        private readonly ExcelsiorLuxuryDbContext _context;

        public ZUsuarioRepository(ExcelsiorLuxuryDbContext context) //contructor
        {
            _context = context;
        }

        #region Methods
        public async Task<List<ZUsuario>> GetAllAsync()
        {
            return await _context.ZUsuarios.ToListAsync();
        }

        public async Task<ZUsuario?> GetByIdAsync(int id)
        {
            return await _context.ZUsuarios
                                 .Include(u => u.Direcciones)
                                 .Include(u => u.Ordenes)
                                 .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<ZUsuario> AddAsync(ZUsuario usuario)
        {
            _context.ZUsuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }

        public async Task<ZUsuario?> UpdateAsync(ZUsuario usuario)
        {
            var existing = await _context.ZUsuarios.FindAsync(usuario.Id);
            if (existing == null) return null;

            existing.Nombres = usuario.Nombres;
            existing.Apellidos = usuario.Apellidos;
            existing.Email = usuario.Email;
            existing.Contraseña = usuario.Contraseña;

            await _context.SaveChangesAsync(); 
            return usuario;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var usuario = await _context.ZUsuarios.FindAsync(id);
            if (usuario == null) return false;

            _context.ZUsuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return true;
        }

        #endregion


    }
}

