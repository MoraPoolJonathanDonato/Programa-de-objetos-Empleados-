using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_de_objetos_Mora_Jonathan
{
    class Empleado
    {
        public int NumeroNomina { get; set; }
        public string Nombre { get; set; }
        public int IdDepartamento { get; set; }

        public Empleado(int numeroNomina, string nombre, int idDepartamento)
        {
            NumeroNomina = numeroNomina;
            Nombre = nombre;
            IdDepartamento = idDepartamento;
        }
    }
}
