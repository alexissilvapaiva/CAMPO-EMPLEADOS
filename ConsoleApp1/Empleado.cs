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
       

        public Empleado(Supervisor supervisor, string nombre,int aniosDeAntiguedad, string apellido, int dni, string direccion, int edad, double salario, int telefono) : base(aniosDeAntiguedad, nombre, apellido, dni, direccion,  edad,  salario,  telefono)

        {
            this.supervisor = supervisor;
           
        }

        public override void incrementarSalario()
        {
            double salarioAnterior = this.salario;
            double aumentoPorAnio = 0.01 * this.aniosDeAntiguedad;
            double aumentoTotal = (1.1 + aumentoPorAnio) * this.salario;
            double aumentoExtra = (1.1 + aumentoPorAnio + 0.05) * this.salario;
            int anioDeNacimiento = 2023 - this.edad;
            if(this.aniosDeAntiguedad == 0)
            {
                this.salario *= 1.1;
                Console.WriteLine("El salario de " + this.nombre + " " + this.apellido + " se aumentó un 10%. Salario anterior: $" + salarioAnterior + ". Nuevo salario: $" + this.salario);
                return;
            }
            if (anioDeNacimiento<1964)
            {
                this.salario = aumentoExtra;
                Console.WriteLine("El salario de " + this.nombre + " " + this.apellido + " se aumentó un " + aumentoExtra + "%. Salario anterior: $" + salarioAnterior + ". Nuevo salario: $" + this.salario);
            }
            else
            {
                this.salario = aumentoTotal;
                Console.WriteLine("El salario de " + this.nombre + " " + this.apellido + " se aumentó un " + aumentoTotal + "%. Salario anterior: $" + salarioAnterior + ". Nuevo salario: $" + this.salario);
            }
            
           
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
