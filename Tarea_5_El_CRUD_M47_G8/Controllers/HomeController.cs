using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tarea_5_El_CRUD_M47_G8.Models;

namespace Tarea_5_El_CRUD_M47_G8.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //https://docs.microsoft.com/es-es/aspnet/core/fundamentals/app-state?view=aspnetcore-3.1

            string cadena;
            List<Models.Empleado> lista = new List<Empleado>();
            
            if (HttpContext.Session.GetString("milista") != null)
            {
                cadena = HttpContext.Session.GetString("milista");

                lista = JsonSerializer.Deserialize<List<Empleado>>(cadena);
            }

            lista.Add(new Empleado() { Codigo = 1, Nombre = "Carlos", SueldoBruto = 5000, FechaIngreso = DateTime.Parse("12/2/2000"),SueldoNeto=4850}) ;
            lista.Add(new Empleado() { Codigo = 2, Nombre = "Juan", SueldoBruto = 6000, FechaIngreso = DateTime.Parse("10/4/2001"), SueldoNeto = 5800});
            lista.Add(new Empleado() { Codigo = 3, Nombre = "Maria", SueldoBruto = 5300, FechaIngreso = DateTime.Parse("22/6/2001"), SueldoNeto = 4900 });

            cadena = JsonSerializer.Serialize(lista);
            HttpContext.Session.SetString("milista", cadena);

            return View(lista);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
