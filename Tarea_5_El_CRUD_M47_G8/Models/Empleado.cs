using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tarea_5_El_CRUD_M47_G8.Models
{
    public class Empleado
    {               
        //******Propiedad codigo *********     
        [Key]
        public int Codigo { get; set; }
        //********************************  
        
        //******Propiedad Nombre *********
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(50, ErrorMessage ="El maximo de caracteres es 50", MinimumLength =3)]
        [Display(Name ="Nombre")]
        public string Nombre { get;  set; }
        //********************************

        //******Propiedad Fecha de Ingreso********
        [Required(ErrorMessage = "El Fecha de Ingreso es obligatorio")]
        [DataType(DataType.Date)]
        public DateTime FechaIngreso { get; set; }
        //****************************************

        //******Propiedad Sueldo Bruto ***********
        [Required(ErrorMessage = "El Sueldo Bruto es obligatorio")]
        public decimal SueldoBruto { get; set ; }
        //****************************************

        //******Propiedad Sueldo Bruto ***********        
        public decimal SueldoNeto {get; set;}
        //****************************************

    }
}
