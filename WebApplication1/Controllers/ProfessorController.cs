using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProfessorController : Controller
    {
        private static List<ProfessorModel> professores;

        public ProfessorController()
        {
            professores = new List<ProfessorModel>()
            {
                new ProfessorModel()
                {
                    Nome="Alex",
                    Id=1,
                    Aulas=50
                },
                new ProfessorModel()
                {
                    Nome="Anderson",
                    Id=2,
                    Aulas=100
                }
            };
        }

        // GET: ProfessorController
        public ActionResult Index()
        {
            return View(professores);
        }

        // GET: ProfessorController/Details/5
        public ActionResult Details(int id)
        {
            var prof = professores.Find(e => e.Id == id);
            return View(prof);
        }

        // GET: ProfessorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProfessorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var prof = new ProfessorModel();
                prof.Nome = collection["Nome"];
                prof.Aulas = int.Parse(collection["Aulas"]);
                prof.Materia = collection["Materia"];
                prof.Id = professores.Count + 1;
                professores.Add(prof);
                return View("Index",professores);
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfessorController/Edit/5
        public ActionResult Edit(int id)
        {
            var prof = professores.Find(e => e.Id == id);
            return View(prof);
        }

        // POST: ProfessorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var prof = professores.Find(e => e.Id == id);
                prof.Aulas = int.Parse(collection["Aulas"]);
                prof.Materia = collection["Materia"];
                return View("Index", professores);
            }
            catch
            {
                return View();
            }
        }

        // GET: ProfessorController/Delete/5
        public ActionResult Delete(int id)
        {
            var prof = professores.Find(e => e.Id == id);
            return View(prof);
        }

        // POST: ProfessorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var prof = professores.Find(e => e.Id == id);
                professores.Remove(prof);

                return View("Index", professores);
            }
            catch
            {
                return View();
            }
        }
    }
}
