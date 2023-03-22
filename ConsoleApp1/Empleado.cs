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
            this.salario *= 1.1;
        }

        public double mostrarSalario()
        {
            return this.salario;
        }

        public void cambiarSupervisor(Supervisor supervisor)
        {
            this.supervisor = supervisor;
        }

        public string mostrarSupervisor()
        {
             return this.supervisor.presentarse();
        }
    }
}
