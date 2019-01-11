using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sistema.Models;

namespace Sistema.Data
{
    public class DbInitializer
    {
        public static void Initialize(SistemaContext context)
        {
            context.Database.EnsureCreated();

            //buscar si exsten registros en la tabla categoria
            if (context.Categoria.Any())
            {
                return;
            }

            var categorias = new Categoria[]
            {
                new Categoria{ Nombre="Programacion", Descripcion="Cursos de Programacion", Estado = true},
                new Categoria{ Nombre="Diseño Grafico", Descripcion="Cursos de diseño Grafico", Estado = true}
            };

            foreach(Categoria c in categorias)
            {
                context.Categoria.Add(c);
            }

            context.SaveChanges();
        }
    }
}
