using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Empleado : Persona
    {
        private Supervisor supervisor;

        public Empleado(Supervisor supervisor, string nombre, string apellido, int dni, string direccion, int edad, double salario, int telefono) : base(nombre, apellido, dni, direccion,  edad,  salario,  telefono)

        {
            this.supervisor = supervisor;
        }

        public override void incrementarSalario()
        {
            double salarioAnterior = this.salario;
            this.salario *= 1.1;
            Console.WriteLine("El salario de " + this.nombre + " " + this.apellido + " se aumentó un 10%. Salario anterior: $" + salarioAnterior + ". Nuevo salario: $" + this.salario);
        }

        public double mostrarSalario()
        {
            return this.salario;
        }

        public void cambiarSupervisor(Supervisor supervisor)
        {
            Supervisor supervisorAnterior = this.supervisor;
            this.supervisor = supervisor;
            Console.WriteLine( this.nombre + " " + this.apellido + " cambió de supervisor. Supervisor anterior: " + supervisorAnterior.getNombre() + ". Nuevo supervisor: " + this.supervisor.getNombre() + ".");
        }

        public string mostrarSupervisor()
        {
             return "Mi supervisor es: " + this.supervisor.getNombre();
        }
    }
}
