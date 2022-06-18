using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Colectivos.Domain.Models
{
	public class Departamento
	{
		public int Id { get; set; }
		[Required]
		[Column(TypeName = "varchar(30)")]
		public string Nombre { get; set; } = string.Empty;
	}
}

