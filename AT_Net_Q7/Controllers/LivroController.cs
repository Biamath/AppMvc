﻿
using Microsoft.AspNetCore.Mvc;
using AT_Net_Q7.Models;
using AT_Net_Q7.Data;


namespace AT_Net_Q7.Controllers
{
    public class LivroController : Controller
    {
        Contexto Contexto;
        public LivroController(Contexto contexto)
        {
            this.Contexto = contexto;
        }
        
        public IActionResult Criar (Livro livro)
        {
            var livros = GetProducts();
            return View(livros);
        }

        private List<Livro> GetProducts()
        {
            return new List<Livro>
            {
                new Livro { Id = 1, Titulo = "Dom Casmurro", Autor = "Machado de Assis" },
                new Livro { Id = 2, Titulo = "O Cortiço", Autor = "Aluísio Azevedo" },
                new Livro { Id = 3, Titulo = "Memórias Póstumas de Brás Cubas", Autor = "Machado de Assis" },
                new Livro { Id = 4, Titulo = "A Moreninha", Autor = "Joaquim Manuel de Macedo" },
                new Livro { Id = 5, Titulo = "Iracema", Autor = "José de Alencar" }
            };

        }

    }
}
