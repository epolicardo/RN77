using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RN77.BD.Datos
{
	using Datos.Entities;
	//a static class to be called from onmodelcreating on context to seed the db
		static class OnModelCreatingExtension
	{
		static string[] personNames = { "Juan", "Martin", "Jose" };
		static string[] personApellidos = { "Aguirre", "Perez", "Lopez" };
		static Random random;
		public static void Seed(ModelBuilder modelBuilder) {
			
			//generates a list with random persons objects
			List<Personas> persons = new List<Personas>(50);
			for (int i = 0; i < persons.Count; i++)
			{
				persons.Add(new Personas
				{
					Apellido = personApellidos[random.Next(personApellidos.Length)],
					Nombre = personNames[random.Next(personNames.Length)]
				});
			}
			//add the list of persons to the db
			modelBuilder.Entity<Personas>().HasData(persons);
				

		}

		

	}
}
