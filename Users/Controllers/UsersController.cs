using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Users.Controllers
{
    //[Route("[controller]/")]
    //[Route("[controller]/[action]")]
    //[Route("Usuarios/")]
    public class UsersController : Controller
    {
        [HttpGet("[controller]/[action]/{data:double}")]
        public IActionResult Index(double data)
        {
            return View("Index", data);
        }

        ////[HttpPost]
        ////[HttpGet]
        //// Estas son las rutas que nuestra accion puede utlizar
        //[Route("/Usuarios/Hugo")]
        ////[Route("/Usuarios/Enrique/{data}")]
        ////[Route("[action]/{data}")]
        ////[Route("[controller]/[action]/{data}/")]
        //[HttpGet("[controller]/[action]/{data:int}")]
        //public IActionResult Index(int data)
        //{
        //    // Estos parametros se pasan por la url y son parametros
        //    // distintos a los declarados
        //    //ViewData["id"] = data + " " + age;

        //    // Instanciamos un nuevo objeto, el cual tambien puede ser pasado a la
        //    // vista el emtodo sobrecargado de view, que acepta una vista y un modelo(objeto)
        //    //String datos = data;
        //    return View("Index", data);
        //}

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}