using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceOpenCallMVC.Controllers
{
    public class OpenCallController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Perfil()
        {
            return View();
        }


    }
}
