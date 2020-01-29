using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAplicada2ProjectFinal.Data
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; } = 0;
        [Required(ErrorMessage ="El campo Nombre es requerido")]
        public string Nombres { get; set; }
        [Required(ErrorMessage ="El campo Apellido no puede estar vacio")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage ="El campo Cedula no puede estar vacio")]
        [StringLength(11,ErrorMessage ="La cedula tiene 11 digitos")]
        public string Cedula { get; set; }
        [Required(ErrorMessage ="El campo Nacionalidad no puede estar vacio")]
        public string Nacionalidad { get; set; }
        [Required(ErrorMessage ="El campo Celular no puede estar vacio")]
        [StringLength(10,ErrorMessage ="El celular tiene 10 digitos")]
        public string Celular { get; set; }
        [Required(ErrorMessage ="El campo Telefono no puede estar vacio")]
        [StringLength(10,ErrorMessage ="El telefono tiene 10 digitos")]
        [MinLength(10,ErrorMessage ="El telefono debe tener al menos 10 digitos")]
        public string Telefono { get; set; }
        [Required(ErrorMessage ="El campo Salario no puede estar vacio")]
        public decimal Salario { get; set; }
        [Required(ErrorMessage ="El campo Estado Civil no puede estar vacio")]
        public string EstadoCivil { get; set; }

        [Required(ErrorMessage ="El campo de Fecha de Nacimiento no puede estar vacio")]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage ="El campo Fecha de creacion no puede estar vacio")]
        public DateTime FechaIngreso { get; set; }

        [Required(ErrorMessage ="El campo Sexo no puede estar vacio")]
        public string Sexo { get; set; }


        public Employees()
        {
            EmployeeId = 0;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Cedula = string.Empty;
            Nacionalidad = string.Empty;
            Celular = string.Empty;
            Telefono = string.Empty;
            this.Salario = 0;
            EstadoCivil = string.Empty;
            FechaIngreso = DateTime.Now;
            FechaNacimiento = DateTime.Now;
        }
    }
}
