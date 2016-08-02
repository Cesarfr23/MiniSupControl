using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entidades;

namespace DAL
{
    public class MiniSubControlDb : DbContext
    {
        public MiniSubControlDb() : base("name=MiniSubControl")
        {
        }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Detalle_Ingreso> Detalle_Ingreso { get; set; }
        public virtual DbSet<Detalle_Venta> Detalle_Venta { get; set; }
        public virtual DbSet<Ingreso> Ingreso { get; set; }
        public virtual DbSet<Presentacion> Presentacion { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Usuario> Usuario { set; get; }
        public virtual DbSet<venta> venta { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
               .HasMany<Categoria>(c => c.Categoria)
               .WithMany(p => p.Producto)
               .Map(pa =>
               {
                   pa.MapLeftKey("ProductoId");
                   pa.MapRightKey("CategoriaId");
                   pa.ToTable("ProductoCategoria");
               });

            modelBuilder.Entity<Producto>()
               .HasMany<Presentacion>(p => p.Presentacion)
               .WithMany(pr => pr.Producto)
               .Map(pa =>
               {
                   pa.MapLeftKey("ProductoId");
                   pa.MapRightKey("PresentacionId");
                   pa.ToTable("ProductoPresentacion");
               });
        }

    }
}
