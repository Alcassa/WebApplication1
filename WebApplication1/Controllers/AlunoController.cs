using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Create()
        {
            return View(new AlunoModel());
        }
        public IActionResult Delete()
        {
            return View(AlunoModel.CriarNeri());
        }
        public IActionResult Details()
        {
            return View(new AlunoModel());
        }
        public IActionResult Edit()
        {
            return View(new AlunoModel());
        }
        public IActionResult List()
        {
            return View(new AlunoModel());
        }

    }
}