using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAplicada2ProjectFinal.Data
{
    public class EmployeeServices
    {
        public bool Crear(Employees employees)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            contexto.Employees.Add(employees);
            paso = contexto.SaveChanges() > 0;
            return paso;
        }

        public bool Actualizar(Employees employees)
        {

            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                contexto.Entry(employees).State = EntityState.Modified;
                paso = contexto.SaveChanges()>0;

            }catch
            {
                throw;
            }
            return paso;

        }

        public List<Employees> GetList(Expression<Func<Employees, bool>>expression)
        {
            List<Employees> employees = new List<Employees>();
            Contexto contexto = new Contexto();
            try
            {
                employees = contexto.Employees.Where(expression).ToList();
            }catch
            {
                throw;
            }
            return employees;
        }

        public Employees GetEmployeeId(int id)
        {
            Contexto contexto = new Contexto();
            Employees employees = contexto.Employees.FirstOrDefault(s => s.EmployeeId == id);
            return employees;
        }

        public bool DeleteEmployee(Employees employees)
        {
            Contexto contexto = new Contexto();
            bool paso = false;
            try
            {
                contexto.Employees.Remove(employees);
                paso = contexto.SaveChanges() > 0;
            }
            catch
            {
                throw;
            }     
            return paso;

        }

      

    }
}
