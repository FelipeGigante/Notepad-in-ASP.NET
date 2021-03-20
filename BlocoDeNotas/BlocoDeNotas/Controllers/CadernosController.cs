using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlocoDeNotas.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models.Contexto;

namespace BlocoDeNotas.Controllers
{
    public class CadernosController : Controller
    {
        private readonly Contexto _contexto;

        public CadernosController(Contexto contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var lista = _contexto.Caderno.ToList();
            return View(lista);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var caderno = new Caderno();
            return View(caderno);
        }

        [HttpPost]
        public IActionResult Create(Caderno caderno)
        {
            if (ModelState.IsValid)
            {
                _contexto.Caderno.Add(caderno);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(caderno);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var caderno = _contexto.Caderno.Find(id);

            if(caderno != null)
            {
                
            }
            return View(caderno);
        }

        [HttpPost]
        public IActionResult Edit(Caderno caderno)
        {
            if (ModelState.IsValid)
            {
                _contexto.Caderno.Update(caderno);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                return View(caderno);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var caderno = _contexto.Caderno.Find(id);
            return View(caderno);
        }

        [HttpPost]
        public IActionResult Delete(Caderno _cadernos)
        {
            var caderno = _contexto.Caderno.Find(_cadernos.Id);
            if (caderno != null)
            {
                _contexto.Caderno.Remove(caderno);
                _contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(caderno);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var caderno = _contexto.Caderno.Find(id);
            return View(caderno);
        }
    }
}