using ExcelsiorLuxury.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelsiorLuxury.Data.Context
{
    public class ExcelsiorLuxuryDbContext : DbContext
    {
        public ExcelsiorLuxuryDbContext(DbContextOptions<ExcelsiorLuxuryDbContext> options)
            : base(options)
        {
        }
        public DbSet<ZUsuario> ZUsuarios { get; set; }
        public DbSet<ZDireccion> ZDirecciones { get; set; }
        public DbSet<ZMarca> ZMarcas { get; set; }
        public DbSet<ZModelo> ZModelos { get; set; }
        public DbSet<ZCategoria> ZCategorias { get; set; }
        public DbSet<ZProducto> ZProductos { get; set; }
        public DbSet<ZEnvio> ZEnvios { get; set; }
        public DbSet<ZOrden> ZOrdenes { get; set; }
        public DbSet<ZOrdenDetalle> ZOrdenDetalles { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<ZOrden>()
                .HasOne(o => o.Usuario)
                .WithMany(u => u.Ordenes)
                .HasForeignKey(o => o.Id_Usuario)
                .OnDelete(DeleteBehavior.NoAction);
        }



    }
}
