using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Colectivos.Domain.Models
{
	public class Colectivo
	{
		public int Id { get; set; }
		[Required]
		[Column(TypeName ="varchar(100)")]
		public string Nombre { get; set; } = string.Empty;
		[Required]
		[Column(TypeName = "varchar(50)")]
		public string Paradero { get; set; } = string.Empty;
		[Required]
		[Column(TypeName ="datetime")]
		public DateTime FechaCreacion { get; set; }
		[Required]
		[Column(TypeName = "varchar(100)")]
		public string Horario { get; set; } = string.Empty;
		[Required]
		public int IdTipoTranposrte { get; set; }
		[Required]
		public int IdDistrito { get; set; }
		[ForeignKey("IdTipoTransporte")]
		public virtual TipoTransporte? TipoTransporte { get; set; }
		[ForeignKey("IdDistrito")]
		public virtual Distrito? Distrito { get; set; }

	}
}

