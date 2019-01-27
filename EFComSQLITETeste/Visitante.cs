using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFComSQLITETeste
{
	class Visitante
	{
		public int Id { get; set; }
		public string NomeCompleto { get; set; }
		public Contato Contato { get; set; }
	}
}
