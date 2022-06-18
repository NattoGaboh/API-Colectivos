using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Colectivos.Domain.Models
{
	public class RutaColectivo
	{
		public int Id { get; set; }
		[Required]
		public int IdColectivo { get; set; }
		[Required]
		public int IdRuta { get; set; }
		[Required]
		public double Tarifa { get; set; }
		[ForeignKey("IdColectivo")]
		public virtual Colectivo? Colectivo { get; set; }
		[ForeignKey("IdRuta")]
		public virtual Ruta? Ruta { get; set; }
	}
}

