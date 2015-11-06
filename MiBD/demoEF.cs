using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio01.MiBD
{
    public class demoEF : DbContext {

        public DbSet<Empleado> Empleados { get; set; } //<clase> Empleados(tablas)
        public DbSet<Departamento> Departamentos { get; set; }
    }
}
