using System;
using API_Colectivos.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Colectivos.Persistence.Context
{
	public class ApplicationDbContext: DbContext
	{
#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {
		}
		public DbSet<User> User { get; set; }
		public DbSet<Departamento> Departamento { get; set; }
		public DbSet<Provincia> Provincia { get; set; }
		public DbSet<Distrito> Distrito { get; set; }
		public DbSet<Ruta> Ruta { get; set; }
		public DbSet<TipoTransporte> TipoTransporte { get; set; }
		public DbSet<Colectivo> Colectivo { get; set; }
		public DbSet<RutaColectivo> RutaColectivo { get; set; }
	}
}

