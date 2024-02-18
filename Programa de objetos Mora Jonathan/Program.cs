using Programa_de_objetos_Mora_Jonathan;
using System;
using System.Collections.Generic;


class Program
{
    static List<Empleado> empleados = new List<Empleado>();
    static List<Departamento> departamentos = new List<Departamento>();

    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Dar de alta empleado");
            Console.WriteLine("2. Dar de alta departamento");
            Console.WriteLine("3. Desplegar empleados");
            Console.WriteLine("4. Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        AltaEmpleado();
                        break;
                    case 2:
                        AltaDepartamento();
                        break;
                    case 3:
                        DesplegarEmpleados();
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }

        } while (opcion != 4);
    }

    static void AltaEmpleado()
    {
        Console.Write("Ingrese número de nómina del empleado: ");
        int numeroNomina = int.Parse(Console.ReadLine());

        Console.Write("Ingrese nombre del empleado: ");
        string nombreEmpleado = Console.ReadLine();

        Console.Write("Ingrese id del departamento del empleado: ");
        int idDepartamento = int.Parse(Console.ReadLine());

        // Validar que el departamento exista
        if (DepartamentoExiste(idDepartamento))
        {
            Empleado nuevoEmpleado = new Empleado(numeroNomina, nombreEmpleado, idDepartamento);
            empleados.Add(nuevoEmpleado);
            Console.WriteLine("Empleado dado de alta correctamente.");
        }
        else
        {
            Console.WriteLine("Error: El departamento no existe.");
        }
    }

    static void AltaDepartamento()
    {
        Console.Write("Ingrese id del departamento: ");
        int idDepartamento = int.Parse(Console.ReadLine());

        Console.Write("Ingrese nombre del departamento: ");
        string nombreDepartamento = Console.ReadLine();

        Departamento nuevoDepartamento = new Departamento(idDepartamento, nombreDepartamento);
        departamentos.Add(nuevoDepartamento);
        Console.WriteLine("Departamento dado de alta correctamente.");
    }

    static void DesplegarEmpleados()
    {
        if (empleados.Count == 0)
        {
            Console.WriteLine("No hay empleados dados de alta.");
        }
        else
        {
            Console.WriteLine("Lista de empleados:");
            foreach (var empleado in empleados)
            {
                Console.WriteLine($"Número de nómina: {empleado.NumeroNomina}, Nombre: {empleado.Nombre}, Departamento: {ObtenerNombreDepartamento(empleado.IdDepartamento)}");
            }
        }
    }

    static bool DepartamentoExiste(int idDepartamento)
    {
        foreach (var departamento in departamentos)
        {
            if (departamento.IdDepartamento == idDepartamento)
            {
                return true;
            }
        }
        return false;
    }

    static string ObtenerNombreDepartamento(int idDepartamento)
    {
        foreach (var departamento in departamentos)
        {
            if (departamento.IdDepartamento == idDepartamento)
            {
                return departamento.NombreDepartamento;
            }
        }
        return "Departamento no encontrado";
    }
}