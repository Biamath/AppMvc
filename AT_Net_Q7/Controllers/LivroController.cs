
using Microsoft.AspNetCore.Mvc;
using AT_Net_Q7.Models;
using AT_Net_Q7.Data;
using System.Linq;

namespace AT_Net_Q7.Controllers
{
    public class LivroController : Controller
    {
        private readonly Contexto _contexto;

        public LivroController(Contexto contexto)
        {
            _contexto = contexto;
        }

        // This action will handle requests to /Livro
        public IActionResult Index()
        {
            // Fetching livros from the database
            var livros = _contexto.Livro.ToList();
            return View(livros);
        }

        // GET: Livro/Create
        public IActionResult Criar()
        {
            return View(); // Show the form to create a new Livro
        }

        [HttpPost]
        public IActionResult Criar(Livro livro)
        {
            if (ModelState.IsValid)
            {
                // Add the livro to the database
                _contexto.Livro.Add(livro);
                _contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(livro);
        }

        // GET: Livro/Delete/5
        public IActionResult Delete(int id)
        {
            var livro = _contexto.Livro.Find(id);
            if (livro == null)
            {
                return NotFound();
            }
            return View(livro); // Show the delete confirmation view
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var livro = _contexto.Livro.Find(id);
            if (livro != null)
            {
                _contexto.Livro.Remove(livro);
                _contexto.SaveChanges();
            }
            return RedirectToAction("Index"); // Redirect to the index after deletion
        }

        // GET: Livro/Consultar/5
        public IActionResult Consultar(int id)
        {
            var livro = _contexto.Livro.Find(id);
            if (livro == null)
            {
                return NotFound();
            }
            return View(livro); // Show details of the selected Livro
        }
    }
}