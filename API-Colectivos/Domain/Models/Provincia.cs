using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Colectivos.Domain.Models
{
	public class Provincia
	{
		public int Id { get; set; }
		[Required]
		[Column(TypeName = "varchar(50)")]
		public string Nombre { get; set; } = string.Empty;
		[Required]
		public int IdDepto { get; set; }
		[ForeignKey("IdDepto ")]
		public virtual Departamento? Departamento { get; set; }
	}
}

