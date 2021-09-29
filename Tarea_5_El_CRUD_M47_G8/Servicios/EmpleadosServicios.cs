using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea_5_El_CRUD_M47_G8.Models;

namespace Tarea_5_El_CRUD_M47_G8.Servicios
{
    public class EmpleadosServicios
    {
        public Empleado ObtenerEmpleado()
        {
            return new Empleado()
            {
                Codigo = 1,
                Nombre = "Juan",
                FechaIngreso = DateTime.Parse("04/2/2000"),
                SueldoBruto= 5000,
                SueldoNeto= 4500
            };

        }

        public List<Empleado> obtenerEmpleados()
        {
            var empleado1 = new Empleado()
            {
                Codigo = 1,
                Nombre = "Juan",
                FechaIngreso = DateTime.Parse("21/4/2001"),
                SueldoBruto = 6000,
                SueldoNeto = 5600
            };

            var empleado2 = new Empleado()
            {
                Codigo = 2,
                Nombre = "Pablo",
                FechaIngreso = DateTime.Parse("14/5/2002"),
                SueldoBruto = 5000,
                SueldoNeto = 4500
            };

            var empleado3 = new Empleado()
            {
                Codigo = 3,
                Nombre = "Maria",
                FechaIngreso = DateTime.Parse("10/3/2003"),
                SueldoBruto = 6000,
                SueldoNeto = 5600
            };

            var empleado4 = new Empleado()
            {
                Codigo = 4,
                Nombre = "Julio",
                FechaIngreso = DateTime.Parse("5/8/2002"),
                SueldoBruto = 5000,
                SueldoNeto = 4500
            };

            return new List<Empleado> { empleado1, empleado2, empleado3, empleado4 };
        }




    }
}
