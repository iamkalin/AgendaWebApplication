using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ContatoController : Controller
    {

        private DatabaseContext _db;
        
        public ContatoController(DatabaseContext db) 
        {
            _db = db;
        }
        public List<Contato> contatos()
        {
            var contatos = _db.Contatos.ToList();
            contatos = contatos.OrderBy(p => p.Nome).ToList();
            return contatos;
        }
        public IActionResult Index()
        {
            
            return View(contatos());
        }

        [HttpGet]
        public IActionResult Cadastrar()
        { 
            
                return View(new Contato());
            
        }
        [HttpPost]
        public IActionResult Cadastrar([FromForm] Contato contato)
        {
            
            if (ModelState.IsValid)
            {
                _db.Contatos.Add(contato);
                
                _db.SaveChanges();
                return RedirectToAction("Index", "Contato");
            }


                return View(contato);
           
        }
        [HttpGet]
        public IActionResult Modificar(int Id)
        {
            Contato contato = _db.Contatos.Find(Id);

            return View("Modificar", contato);

        }
        [HttpPost]
        public IActionResult Modificar([FromForm] Contato contato)
        {
            if (ModelState.IsValid) {
                _db.Contatos.Update(contato);
                _db.SaveChanges();
            }

            return RedirectToAction("Index", "Contato", contatos());
        }
        public IActionResult Excluir(int Id)
        {
            _db.Contatos.Remove(_db.Contatos.Find(Id));
            _db.SaveChanges();
            return RedirectToAction("Index", "Contato");
        }
    }
}
