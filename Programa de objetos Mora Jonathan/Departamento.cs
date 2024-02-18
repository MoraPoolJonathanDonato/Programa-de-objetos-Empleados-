using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_de_objetos_Mora_Jonathan
{
    class Departamento
    {
        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }

        public Departamento(int idDepartamento, string nombreDepartamento)
        {
            IdDepartamento = idDepartamento;
            NombreDepartamento = nombreDepartamento;
        }
    }
}
