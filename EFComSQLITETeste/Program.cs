using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFComSQLITETeste
{
	class Program
	{
		static void Main(string[] args)
		{
			var visitante1 = new Visitante();
			visitante1.NomeCompleto = "João";
			var contato1 = new Contato();
			contato1.Email = 2299221144.0f;
			visitante1.Contato = contato1;

			using (var contexto = new TestDbContext())
			{
				contexto.Visitantes.Add(visitante1);
				contexto.SaveChanges();
			}

			using (var contexto = new TestDbContext())
			{
				var visitante = contexto.Visitantes.Include("Contato").FirstOrDefault();
				Console.WriteLine(visitante.NomeCompleto);
				Console.WriteLine(visitante.Contato.Email);
				Console.ReadKey();
			}
		}
	}
}
