using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorAplicada2ProjectFinal.Data
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Nacionalidad { get; set; }
        public string Celular { get; set; }
        public string Telefono { get; set; }
        public decimal Salario { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public DateTime FechaCreacion { get; set; }


        public Employees()
        {
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Cedula = string.Empty;
            Nacionalidad = string.Empty;
            Celular = string.Empty;
            Telefono = string.Empty;
            Salario = 0;
            EstadoCivil = string.Empty;
            FechaCreacion = DateTime.Now;
            FechaNacimiento = DateTime.Now;
        }
    }
}
