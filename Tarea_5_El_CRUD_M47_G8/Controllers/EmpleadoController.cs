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
using Tarea_5_El_CRUD_M47_G8.Servicios;

namespace Tarea_5_El_CRUD_M47_G8.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: EmpleadoController
        public ActionResult Index()
        {
            //https://docs.microsoft.com/es-es/aspnet/core/fundamentals/app-state?view=aspnetcore-3.1

            string cadena;
            List<Models.Empleado> lista = new List<Empleado>();            

            if (HttpContext.Session.GetString("milista") != null)
            {
                cadena = HttpContext.Session.GetString("milista");

                lista = JsonSerializer.Deserialize<List<Empleado>>(cadena);
            }

            var EmpleadosServicios = new EmpleadosServicios();
            lista = EmpleadosServicios.obtenerEmpleados();
            

            cadena = JsonSerializer.Serialize(lista);
            HttpContext.Session.SetString("milista", cadena);                      


            return View(lista);
        }

        // GET: EmpleadoController/Details/5
        public ActionResult Details(int id)
        {

            var clientesServicios = new EmpleadosServicios();
            var lista = clientesServicios.obtenerEmpleados();
            var cli = lista.Where(x => x.Codigo == id).SingleOrDefault();
            return View(cli);
        }

        // GET: EmpleadoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmpleadoController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoController/Edit/5
        public ActionResult Edit(int id)
        {
            var clientesServicios = new EmpleadosServicios();
            var lista = clientesServicios.obtenerEmpleados();
            var cli = lista.Where(x => x.Codigo == id).SingleOrDefault();
            return View(cli);
        }

        // POST: EmpleadoController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmpleadoController/Delete/5
        public ActionResult Delete(int id)
        {
            var clientesServicios = new EmpleadosServicios();
            var lista = clientesServicios.obtenerEmpleados();
            var cli = lista.Where(x => x.Codigo == id).SingleOrDefault();
            return View(cli);
        }

        // POST: EmpleadoController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
