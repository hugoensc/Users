using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Users.Controllers
{
    public class UsersController : Controller
    {   
        //[HttpPost]
        [HttpGet]
        public IActionResult Index(string data, int age)
        {
            // Estos parametros se pasan por la url y son parametros
            // distintos a los declarados
            //ViewData["id"] = data + " " + age;

            // Instanciamos un nuevo objeto, el cual tambien puede ser pasado a la
            // vista el emtodo sobrecargado de view, que acepta una vista y un modelo(objeto)
            String datos = data + " " + age;
            return View("Index", datos);
        }
    }
}