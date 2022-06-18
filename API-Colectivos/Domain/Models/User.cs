using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Colectivos.Domain.Models
{
	public class User
	{
		public int Id { get; set; }
		[Required]
		[Column(TypeName = "varchar(30)")]
		public string NameUser { get; set; } = string.Empty;
		[Required]
		[Column(TypeName = "varchar(100)")]
		public string Password { get; set; } = string.Empty;
	}
}

