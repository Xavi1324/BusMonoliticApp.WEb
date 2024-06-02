using BusMonoliticApp.Web.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BusMonoliticApp.Web.Data.Context
{
    public class BoletosBusContext : DbContext
    {
        #region "Constructor"
        public BoletosBusContext(DbContextOptions<BoletosBusContext> options) : base(options)
        {
        }
        #endregion
        #region "Db Sets"
         public DbSet<Asiento> Asiento { get; set; }
        public DbSet<Bus> Bus { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<DetallePedido> DetallePedido { get; set; }
        public DbSet<Empleado> Empleado { get; set; }  
        public DbSet<Factura> Factura {get; set;}
        public DbSet<Menu> Menu {get; set;}
        public DbSet<Mesa> Mesa {get; set;}
        public DbSet<Pedido> Pedido {get; set;} 
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<ReservaDetalle> ReservaDetalle {get; set;}
        public DbSet<Ruta> Ruta {get; set;}
        public DbSet<Usuario> Usuario {get; set;}
        public DbSet<Viaje> Viaje {get; set;}
        
        #endregion
       
    }
}
