using ExcelsiorLuxury.Business.Interfaces;
using ExcelsiorLuxury.Data.Entities;
using ExcelsiorLuxury.Data.Repositories.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Business.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IZUsuarioRepository _usuarioRepository;

        public UsuarioService(IZUsuarioRepository usuarioRepository) //Esto permite que .NET inyecte automáticamente el repository.
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<List<ZUsuario>> GetAllAsync()
        {
            return await _usuarioRepository.GetAllAsync();
        }

        public async Task<ZUsuario?> GetByIdAsync(int id)
        {
            return await _usuarioRepository.GetByIdAsync(id);
        }

        public async Task<ZUsuario> AddAsync(ZUsuario usuario)
        {
            return await _usuarioRepository.AddAsync(usuario);
        }

        public async Task<ZUsuario?> UpdateAsync(ZUsuario usuario)
        {
            return await _usuarioRepository.UpdateAsync(usuario);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _usuarioRepository.DeleteAsync(id);
        }
    }
}
