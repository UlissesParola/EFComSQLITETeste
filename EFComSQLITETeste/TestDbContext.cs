using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFComSQLITETeste
{
	class TestDbContext : DbContext
	{
		public DbSet<Visitante> Visitantes { get; set; }
		public DbSet<Contato> Contatos { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Filename=Teste.db");
			base.OnConfiguring(optionsBuilder);
		}
	}
}
