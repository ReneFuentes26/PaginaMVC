using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PaginaMVC.Models;

namespace PaginaMVC.Controllers
{
    public class PersonalController : Controller
    {
        public IActionResult Index()
        {
            Personal personal = new Personal();
            personal.name="Rene Ismael";
            personal.lastname="Fuentes Benítez";
            personal.age=18;
            personal.email="ismafuentes2003@gmail.com";
            personal.telefone=72164889;
            personal.direction="Residencial San Francisco Final 13 Calle OTE. POL.7 #2 y 4";
            return View(personal);
        }
    }
}